using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class ViewPurchasetab : Form
    {
        Form1 frm = new Form1();
        public ViewPurchasetab()
        {
            InitializeComponent();
        }
        
     public void getlistWithTwoParameters(string proc,ComboBox cb, string displayMember, string valueMember,string param1,object val1, string param2,object val2)
        {
            try
            {
                cb.DataSource = null;
                SqlCommand cmd = new SqlCommand(proc, MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, val1);
                cmd.Parameters.AddWithValue(param2, val2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr, 0);
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
                cb.DataSource = dt;
            }
            catch (Exception)
            {

            }
        }

        private void Datepicker_onValueChanged(object sender, EventArgs e)
        {
        }
        private void ViewPurchasetab_Load(object sender, EventArgs e)
        {
            getlistWithTwoParameters("st_getPurchaseList", PurDD, "Company", "ID", "@month", Datepicker.Value.Month, "@year", Datepicker.Value.Year);

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void showPurchaseDetails (Int64 pid, DataGridView gv,DataGridViewColumn mPIDGV,DataGridViewColumn proIDGV,DataGridViewColumn proNameGV,DataGridViewColumn quanGV,DataGridViewColumn pupGV,DataGridViewColumn totGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getPurchaseDetails", MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pid", pid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                mPIDGV.DataPropertyName = dt.Columns["mPID"].ToString();
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proNameGV.DataPropertyName = dt.Columns["Product"].ToString();
                quanGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                pupGV.DataPropertyName = dt.Columns["Per Unit Price"].ToString();
                totGV.DataPropertyName = dt.Columns["Total Price"].ToString();
                gv.DataSource = dt;

            }
            catch (Exception) 
            {
                MessageBox.Show("Error");
            }
        }

        private void PurDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            float gt = 0;
            if(PurDD.SelectedIndex !=-1&& PurDD.SelectedIndex != 0)
            {
                showPurchaseDetails(Convert.ToInt64(PurDD.SelectedValue.ToString()),datagridviewPurchaseview,mPIDgv,proIdGv, Product, quanGv, pupGv, TotGv);
                foreach(DataGridViewRow row in datagridviewPurchaseview.Rows)
                {
                    gt += Convert.ToSingle(row.Cells["TotGv"].Value.ToString());
                }
                Grosslable.Text = gt.ToString();
                gt = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Datepicker_ValueChanged(object sender, EventArgs e)
        {
            getlistWithTwoParameters("st_getPurchaseList  ", PurDD, "Company", "ID", "@month", Datepicker.Value.Month, "@year", Datepicker.Value.Year);

        }
        public void insertDeletedItem(Int64 pid,Int64 proID,int quan,int userid,DateTime date)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertDeletedItemPI", MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pi",pid);
                cmd.Parameters.AddWithValue("@usrID",Form1.getUserID);
                cmd.Parameters.AddWithValue("@proID",proID);
                cmd.Parameters.AddWithValue("@quan",quan);
                cmd.Parameters.AddWithValue("@date",date);
                MainClass.sqlcon.Open();
                cmd.ExecuteNonQuery();
                MainClass.sqlcon.Close();
            }
            catch(Exception)
            {
                MainClass.sqlcon.Close();
            }
        }

        public void delete(object id, string proc, string param)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(proc,MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param, id);
                MainClass.sqlcon.Open();
                cmd.ExecuteNonQuery();
                MainClass.sqlcon.Close();
                MessageBox.Show("Data Deleted sucessfully");
            }
            catch (Exception ex)
            {
                MainClass.sqlcon.Close();
                MessageBox.Show(ex.Message,"Error");

            }

        }

        public int rowIndex;
        Stocks stk = new Stocks();
        private void btnDelPurchase_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = datagridviewPurchaseview.Rows[rowIndex];
            DialogResult dr = MessageBox.Show("Are you sure , you want to delete" + row.Cells["Product"].Value.ToString(),"from purchase? WARNING DELETION OF PRODUCT WILL EFFECT STOCK",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                using(TransactionScope sc = new TransactionScope())
                {
                    insertDeletedItem(Convert.ToInt64(PurDD.SelectedValue.ToString()), Convert.ToInt32(row.Cells["proIdGv"].Value.ToString()), Convert.ToInt32(row.Cells["quanGv"].Value.ToString()), Form1.getUserID, DateTime.Today);
                    int q;
                    object ob = stk.getProductQuantity(Convert.ToInt32(row.Cells["proIdGv"].Value.ToString()));
                    if (ob != null)
                    {
                        q = Convert.ToInt32(ob);
                        q -= Convert.ToInt32(row.Cells["quanGv"].Value.ToString());
                        stk.UpdateStock(Convert.ToInt32(row.Cells["proIdGv"].Value.ToString()), q);
                        float tot = Convert.ToSingle(Grosslable.Text) - Convert.ToSingle(row.Cells["TotGv"].Value.ToString());
                        Grosslable.Text = tot.ToString();
                        delete(Convert.ToInt64(row.Cells["mPIDgv"].Value.ToString()), "st_deleteProductFromPID","@mPID");
                        datagridviewPurchaseview.Rows.Remove(row);
                    }
                    sc.Complete();

                }

        }

        private void datagridviewPurchaseview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelPurchase.Enabled = true;
        }
    }


}
