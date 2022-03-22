using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Products : Form
    {
        
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;
        //Int64 prodId;
        public int rowIndex;
        public Products()
        {
            InitializeComponent();
        }
        private void Products_Load(object sender, EventArgs e)
        {
            loadProductsData();
        }
        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            AddProducts ap = new AddProducts();
            ap.Show();
        }

        private void btnDelProducts_Click(object sender, EventArgs e)
        {
            try
            {
                int cateId;
                DataGridViewRow row = datagridviewProducts.Rows[rowIndex];
                cateId = Convert.ToInt32(row.Cells["proIdGV"].Value.ToString());
                SqlCommand cmd = new SqlCommand("st_productDelete", MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", cateId);
                MainClass.sqlcon.Open();
                cmd.ExecuteNonQuery();
                MainClass.sqlcon.Close();
                loadProductsData();
            }
            catch (Exception ex)
            {
                MainClass.sqlcon.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void loadProductsData()
        {
            try
            {
                cmd = new SqlCommand("st_getProductsData", MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                proIdGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proGV.DataPropertyName = dt.Columns["Product"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                expiryGV.DataPropertyName = dt.Columns["Expiry"].ToString();
                catGV.DataPropertyName = dt.Columns["Category"].ToString();
                catIdGV.DataPropertyName = dt.Columns["Category ID"].ToString();
                datagridviewProducts.DataSource = dt;
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            loadProductsData();
        }

        private void btnEditProducts_Click(object sender, EventArgs e)
        {
            if (rowIndex != -1)
            {
                UpdateProducts up = new UpdateProducts();
                up.Show();
                DataGridViewRow row = datagridviewProducts.Rows[rowIndex];
                up.productId = Convert.ToInt32(row.Cells["proIdGV"].Value.ToString());
                up.textboxProName.Text = row.Cells["proGV"].Value.ToString();
                up.textboxBarcode.Text = row.Cells["barcodeGV"].Value.ToString();
                up.dateExpiry.Value = Convert.ToDateTime(row.Cells["expiryGV"].Value.ToString());
                up.comboboxCategory.SelectedItem = row.Cells["CatGV"].Value.ToString();
            }
        }

        private void datagridviewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }
        
        private void textboxProSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Product like '%{0}%'", textboxProSearch.Text);
            datagridviewProducts.DataSource = dv.ToTable();
        }

        private void datagridviewProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelProducts.Enabled = true;
        }
    }
}
