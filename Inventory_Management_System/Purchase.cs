using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;
namespace Inventory_Management_System
{
    public partial class Purchase : Form
    {
        //DataTable dt;
        AddPurchase prr;
        //public int q;
        public Purchase()
        {
            InitializeComponent();

        }
        Form1 frm=new Form1();
        private void btnAddPurchase_Click(object sender, EventArgs e)
        {
            prr = new AddPurchase(this);
            prr.Show();
        }

        private void textboxSuppSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            //DataView dv = dt.DefaultView;
            //dv.RowFilter = string.Format("Purchase like '%{0}%'", textboxSuppSearch.Text);
            //datagridviewSupplier.DataSource = dv.ToTable();
        }

        private void btnDelPurchase_Click(object sender, EventArgs e)

        {
            int rowindex = datagridviewPurchase.CurrentCell.RowIndex;
                DataGridViewRow row = datagridviewPurchase.Rows[rowindex];
                prr.gt -= Convert.ToSingle(row.Cells["TotGV"].Value.ToString());
                Grosslable.Text = prr.gt.ToString();
                MessageBox.Show("Are You sure to delete this row ?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                datagridviewPurchase.Rows.RemoveAt(rowindex);
                if (datagridviewPurchase.Rows.Count == -1)
                {
                Grosslable.Text = "0.00";
                btnDelPurchase.Enabled = false;
                MessageBox.Show("Data Deleted");
                }
               
           
        }

        private void datagridviewPurchase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private Int64 PurchaseID;
        public Int64 insertPurchase(DateTime date, int doneBy, int suppID)
        {
            try
            {
                    SqlCommand cmd = new SqlCommand("st_insertPurchase", MainClass.sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@doneBy", Form1.getUserID);
                    cmd.Parameters.AddWithValue("@suppID", suppID);
                    MainClass.sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "st_getLastPurchaseID";
                    cmd.Parameters.Clear();
                    PurchaseID = Convert.ToInt64(cmd.ExecuteScalar());
                    MainClass.sqlcon.Close();
            }
            catch (Exception ex)
            {
                MainClass.sqlcon.Close();
                MessageBox.Show(ex.Message);
            }
            return PurchaseID;
        }
        int pidcount;
        public int insertPurchasedetails(Int64 PurID, Int64 proID,int Quan,float totPrice)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertPurchaseDetails", MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@purchaseID",PurID);
                cmd.Parameters.AddWithValue("@proID",proID);
                cmd.Parameters.AddWithValue("@Quan",Quan);
                cmd.Parameters.AddWithValue("@totPrice",totPrice);
                MainClass.sqlcon.Open();
               pidcount= cmd.ExecuteNonQuery();
                MainClass.sqlcon.Close();
            }
            catch (Exception)
            {
                MainClass.sqlcon.Close();
            }
            return pidcount;
        }
        int co;
        Stocks stk = new Stocks();
        Price pri = new Price();
        public void btnSavePurchase_Click(object sender, EventArgs e)
        {
            if (datagridviewPurchase.Rows.Count > 0)
            {
                Int64 purchaseId;
                using (TransactionScope sc = new TransactionScope())
                {
                    purchaseId = insertPurchase(DateTime.Today,  Form1.getUserID, Convert.ToInt32(prr.comboboxSupplier.SelectedValue));

                    foreach (DataGridViewRow row in datagridviewPurchase.Rows)
                    {
                        co += insertPurchasedetails(purchaseId, Convert.ToInt32(row.Cells["proIdGv"].Value.ToString()), Convert.ToInt32(row.Cells["quanGv"].Value.ToString()), Convert.ToSingle(row.Cells["TotGv"].Value.ToString()));
                        if (checkProductPriceExistance(Convert.ToInt32(row.Cells["proIdGv"].Value.ToString())))
                        {
                            pri.UpdateProductPrice(Convert.ToInt32(row.Cells["proIdGv"].Value.ToString()), Convert.ToSingle(row.Cells["pupGv"].Value.ToString()));
                        }
                        else
                        {
                            insertProductPrice(Convert.ToInt32(row.Cells["proIdGv"].Value.ToString()), Convert.ToSingle(row.Cells["pupGv"].Value.ToString()));
                        }
                        int q;
                        object ob = stk.getProductQuantity(Convert.ToInt32(row.Cells["proIdGv"].Value.ToString()));
                        if (ob != null)
                        {
                            q = Convert.ToInt32(ob);
                            q += Convert.ToInt32(row.Cells["quanGv"].Value.ToString());
                            stk.UpdateStock(Convert.ToInt32(row.Cells["proIdGv"].Value.ToString()), q);

                        }
                        else
                        {
                            stk.insertStock(Convert.ToInt32(row.Cells["proIdGv"].Value.ToString()), Convert.ToInt32(row.Cells["quanGv"].Value.ToString()));
                        }

                    }
                    if (co > 0)
                    {
                        MessageBox.Show("Purchase created Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //datagridviewPurchase.Rows.Clear();
                        //Grosslable.Text = "0.00";
                   
                    }
                    else
                    {
                        MessageBox.Show("Unable to create purchase", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    sc.Complete();
                }


            }
        }
        public void insertProductPrice(Int64 proID, float buyingAmount)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertProductPrice", MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@bp", buyingAmount);
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
            private void ViewbtnPurchase_Click(object sender, EventArgs e)
        {
            
        }

        private void btnViewSuppliers_Click(object sender, EventArgs e)
        {
        }

        private bool checkPPExistance;
        public bool checkProductPriceExistance(Int64 proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_checkProductPriceExist",MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("proID", proID);
                MainClass.sqlcon.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    checkPPExistance = true;
                }
                else
                {
                    checkPPExistance = false;
                }
                MainClass.sqlcon.Close();
            }
            catch(Exception)
            {

            }
            return checkPPExistance;
        }

        private void btnEditPurchase_Click(object sender, EventArgs e)
        {

        }
        private void Printbtn_Click(object sender, EventArgs e)
        {
            PurchaseReport pr = new PurchaseReport();
            pr.Show();
            UpdateStockReport usr = new UpdateStockReport();
            usr.Show();
        }

        private void datagridviewPurchase_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelPurchase.Enabled = true;
        }
    }

}