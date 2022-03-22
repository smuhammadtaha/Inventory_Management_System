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
    public partial class AddSales : Form
    {
        Sales sa;
        public AddSales(Sales sal)
        {
            InitializeComponent();
            sa = sal;
        }
        
        private void AddSales_Load(object sender, EventArgs e)
        {

        }
        public string[] productData = new string[4];
        public string[] getProductsWRTBarcode(String barcode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductByBarcodeSales", MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                MainClass.sqlcon.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        productData[0] = sdr[0].ToString();
                        productData[2] = sdr[1].ToString();
                        productData[1] = sdr[2].ToString();
                        productData[3] = sdr[3].ToString();
                    }
                }
                else
                { //MessageBox.Show("No Product Available", "Error"); 
                }
                MainClass.sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return productData;
        }
        private void BarCodetxt_Validating(object sender, CancelEventArgs e)
        {

            sa.condition();

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAddCheck_Click(object sender, EventArgs e)
        {
            sa.checkbtn();
        }

        private void AmtTxt_OnValueChanged(object sender, EventArgs e)
        {
            sa.amtgiven();
        }

        private void AmtTxt_Validating(object sender, CancelEventArgs e)
        {
            sa.validamtgiven();
        }
        //Dashboard dsh;
        private void btnAddPay_Click(object sender, EventArgs e)
        {
            sa.paybtn();
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            BarcodeScanner bs = new BarcodeScanner();
            bs.Show();
        }
    }
}
