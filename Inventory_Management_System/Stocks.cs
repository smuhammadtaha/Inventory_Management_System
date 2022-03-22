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

namespace Inventory_Management_System
{
    public partial class Stocks : Form
    {
        public Stocks()
        {
            InitializeComponent();

        }

        public void insertStock(Int64 proID, int Quan)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertStock", MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@Quan", Quan);
                MainClass.sqlcon.Open();
                cmd.ExecuteNonQuery();
                MainClass.sqlcon.Close();
            }
            catch (Exception)
            {
                MainClass.sqlcon.Close();
            }
        }
        public void UpdateStock(Int64 proID, int Quan)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updatestock", MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@Quan", Quan);
                MainClass.sqlcon.Open();
                cmd.ExecuteNonQuery();
                MainClass.sqlcon.Close();
            }
            catch (Exception)
            {
                MainClass.sqlcon.Close();
            }
        }

        private object productStockCount = 0;

        public object getProductQuantity(Int64 proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                MainClass.sqlcon.Open();
                productStockCount = cmd.ExecuteScalar();
                MainClass.sqlcon.Close();
            }
            catch (Exception)
            {

            }
            return productStockCount;
        }
        public void showStock(DataGridView gv,DataGridViewColumn proIDGV,DataGridViewColumn proGV,DataGridViewColumn barcodeGV,DataGridViewColumn expiryGV,DataGridViewColumn bpGV,DataGridViewColumn spGV,DataGridViewColumn catGV,DataGridViewColumn availStGV,DataGridViewColumn statusGV,DataGridViewColumn totGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getAllStock", MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                proIdGv.DataPropertyName = dt.Columns["Product ID"].ToString();
                proGV.DataPropertyName = dt.Columns["Product"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                expiryGV.DataPropertyName = dt.Columns["Expiry Date"].ToString();
                bpGV.DataPropertyName = dt.Columns["Buying Price"].ToString();
                spGV.DataPropertyName = dt.Columns["Selling Price"].ToString();
                catGV.DataPropertyName = dt.Columns["Category"].ToString();
                availStGV.DataPropertyName = dt.Columns["Available Stock"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                totGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                gv.DataSource = dt;

            }
            catch (Exception)
            {
                MessageBox.Show("Unable to load Stock data", "Error");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void Stocks_Load(object sender, EventArgs e)
        {
            showStock(datagridviewStock, proIdGv, Product, barGV, expiryGV,bpGV,spGV,catGV,quanGv,statusGV,finalGV);
        }

    }
}
