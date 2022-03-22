using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Price : Form
    {
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        public Price()
        {
            InitializeComponent();
            datagridviewPricing.AutoGenerateColumns = false;
            //try
            //{
            //    CatDD.Items.Clear();
            //    SqlCommand cmd = new SqlCommand("st_getCategoriesList", MainClass.sqlcon);
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    sda.Fill(dt);
            //    DataRow dr = dt.NewRow();
            //    dr.ItemArray = new object[] { 0, "Select..." };
            //    dt.Rows.InsertAt(dr, 0);
            //    CatDD.DataSource = dt;
            //    CatDD.DisplayMember = "Category";
            //    CatDD.ValueMember = "ID";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            loadCategory();
        }

        private void Price_Load(object sender, EventArgs e)
        {
            
        }
        public void loadCategory()
        {
            try
            {
                //CatDD.Items.Clear();
                SqlCommand cmd = new SqlCommand("st_getCategoriesList", MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr, 0);
                CatDD.DataSource = dt;
                CatDD.DisplayMember = "Category";
                CatDD.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void showProductWRTCategory(int cat_id, DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn Product, DataGridViewColumn bpGV,DataGridViewColumn spGV,DataGridViewColumn disGV,DataGridViewColumn profitPerGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductWRTCategory", MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@catID", cat_id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                proIdGv.DataPropertyName = dt.Columns["Product ID"].ToString();
                Product.DataPropertyName = dt.Columns["Product"].ToString();
                bpGV.DataPropertyName = dt.Columns["Buying Price"].ToString();
                spGV.DataPropertyName = dt.Columns["Selling Price"].ToString();
                disGV.DataPropertyName = dt.Columns["Discount"].ToString();
                profitPerGV.DataPropertyName = dt.Columns["Profit Percentage"].ToString();
                gv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CatDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CatDD.SelectedIndex != -1 && CatDD.SelectedIndex != 0)
            {
                showProductWRTCategory(Convert.ToInt32(CatDD.SelectedValue.ToString()), datagridviewPricing, proIdGv, Product, buyPriceGV,finalSellGV,discountGV,profMarginGV);
            }
        }

        private void datagridviewPricing_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex!=-1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = datagridviewPricing.Rows[e.RowIndex];
                if (row.Cells["profMarginGV"].Value != DBNull.Value && rg.Match(row.Cells["profMarginGV"].Value.ToString()).Success)
                {
                    float buyingPrice = Convert.ToSingle(row.Cells["buyPriceGV"].Value.ToString());
                    float profitMargin = Convert.ToSingle(row.Cells["profMarginGV"].Value.ToString())/100;
                    float amt = profitMargin * buyingPrice;
                    
                    float final = buyingPrice + amt;

                    float discountPer;
                    if (row.Cells["discountGV"].Value != null && rg.Match(row.Cells["discountGV"].Value.ToString()).Success)
                    {
                        discountPer = final * Convert.ToSingle(row.Cells["discountGV"].Value.ToString()) / 100;
                    }
                    else
                    {
                        discountPer = 0;
                    }

                    row.Cells["finalSellGV"].Value = final-discountPer;
                }
                else
                {
                    row.Cells["finalSellGV"].Value = null;
                    row.Cells["discountGV"].Value = null;
                    row.Cells["profMarginGV"].Value = null;
                }
            }
        }
        public void UpdateProductPrice(Int64 proID, float bp,float sp=0,float dis=0,float profitPerc=0)
        {
            try
            {
                SqlCommand cmd;
                if (sp == 0 && dis == 0 && profitPerc == 0)
                {
                    cmd = new SqlCommand("st_updateProductPrice", MainClass.sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@proID", proID);
                    cmd.Parameters.AddWithValue("@bp", bp);
                }
                cmd = new SqlCommand("st_updateProductPrice", MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@bp", bp);
                cmd.Parameters.AddWithValue("@sp", sp);
                cmd.Parameters.AddWithValue("@dis", dis);
                cmd.Parameters.AddWithValue("@profper", profitPerc);

                MainClass.sqlcon.Open();
                cmd.ExecuteNonQuery();
                MainClass.sqlcon.Close();
            }
            catch (Exception ex)
            {
                MainClass.sqlcon.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSavePurchase_Click(object sender, EventArgs e)
        {
            if (CatDD.SelectedIndex!=-1&&CatDD.SelectedIndex!=0)
            {
                foreach(DataGridViewRow row in datagridviewPricing.Rows)
                {
                    if ((bool)row.Cells["selectGV"].FormattedValue == false)
                    {
                        float disc, pm, bp, sp;
                        Int64 proID;
                        proID = Convert.ToInt32(row.Cells["proIdGv"].Value.ToString());
                        bp = Convert.ToSingle(row.Cells["buyPriceGV"].Value.ToString());
                        disc = row.Cells["discountGV"].Value == null ? 0 : Convert.ToSingle(row.Cells["discountGV"].Value.ToString());
                        pm= row.Cells["profMarginGV"].Value == null ? 0 : Convert.ToSingle(row.Cells["profMarginGV"].Value.ToString());
                        if (disc == 0 && pm == 0)
                        {
                            sp = bp;
                        }
                        else
                        {
                            sp = Convert.ToSingle(row.Cells["finalSellGV"].Value.ToString());

                        }
                        UpdateProductPrice(proID, bp, sp, disc, pm);
                    }
                }
                MessageBox.Show("Product Price Updated Successfully");

            }
        }

        private void datagridviewPricing_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void datagridviewPricing_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelPurchase.Enabled = true;
        }

    }
}
