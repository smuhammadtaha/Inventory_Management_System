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
    public partial class AddPurchase : Form
    {
        Purchase pr;
        public AddPurchase(Purchase prc)
        {
            InitializeComponent();
            pr = prc;
        }
        int productID;
        public float gt,tot;
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddPurchase_Load(object sender, EventArgs e)
        {
            try
            {
                comboboxSupplier.Items.Clear();
                SqlCommand cmd = new SqlCommand("st_getSupplierList", MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                comboboxSupplier.DataSource = dt;
                comboboxSupplier.DisplayMember = "Company";
                comboboxSupplier.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string[] productData = new string[3];
        public string[] getProductsWRTBarcode(String barcode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductByBarcode",MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                MainClass.sqlcon.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        productData[0] = sdr[0].ToString();
                        productData[1] = sdr[1].ToString();
                        productData[2] = sdr[2].ToString();
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
        string[] prodARR = new string[3];

        private void textboxBarcode_Validating(object sender, CancelEventArgs e)
        {
            if (textboxBarcode.Text != "")
            {
                prodARR = getProductsWRTBarcode(textboxBarcode.Text);
                productID = Convert.ToInt32(prodARR[0]);
                textboxProdName.Text = prodARR[1];
                string barco = prodARR[2];
                textboxProdName.Enabled = false;
                if (barco != null)
                {
                    textboxCostPrice.Focus();
                }

            }
            else
            {
                productID = 0;
                textboxProdName.Text = "";
                textboxCostPrice.Text = "";
                Array.Clear(prodARR, 0, prodARR.Length);
            }
        }


        private void textboxProdQty_OnValueChanged(object sender, EventArgs e)
        {
            if (textboxProdQty.Text != "")
            {
                if (rg.Match(textboxProdQty.Text).Success)
                {
                    float quan, price, total;
                    quan = Convert.ToSingle(textboxProdQty.Text);
                    price= Convert.ToSingle(textboxCostPrice.Text);
                    total = quan * price;
                    Totlable.Text = total.ToString("#########.##");
                    
                }
                else
                {
                    textboxProdQty.Select();
                }
                
            }
            else
            {
                Totlable.Text = "0.00";
            }
        }

        private void btnAddPurchase_Click(object sender, EventArgs e)
        {
            if (comboboxSupplier.SelectedIndex == -1 || textboxProdQty.Text == "" || textboxBarcode.Text == "")
            {
                textboxBarcode.BorderColorFocused = System.Drawing.Color.Red;
                textboxBarcode.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                textboxBarcode.BorderColorMouseHover = System.Drawing.Color.Red;
                textboxProdName.BorderColorFocused = System.Drawing.Color.Red;
                textboxProdName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                textboxProdName.BorderColorMouseHover = System.Drawing.Color.Red;
                textboxCostPrice.BorderColorFocused = System.Drawing.Color.Red;
                textboxCostPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                textboxCostPrice.BorderColorMouseHover = System.Drawing.Color.Red;
                textboxProdQty.BorderColorFocused = System.Drawing.Color.Red;
                textboxProdQty.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                textboxProdQty.BorderColorMouseHover = System.Drawing.Color.Red;
                Error1.Visible = true;
                Error2.Visible = true;
                Error3.Visible = true;
                Error4.Visible = true;
                MessageBox.Show("Error");

            }
            else
            {
                Error1.Visible = false;
                Error2.Visible = false;
                Error3.Visible = false;
                Error4.Visible = false;
                pr.datagridviewPurchase.Rows.Add(productID,textboxProdName.Text,textboxProdQty.Text,textboxCostPrice.Text,Totlable.Text);
                gt += Convert.ToSingle(Totlable.Text);
                pr.Grosslable.Text = gt.ToString();
                productID = 0;
                textboxProdName.Text = "";
                textboxCostPrice.Text = "";
                textboxBarcode.Text = "";
                Totlable.Text = "0.00";
                textboxProdQty.Text = "";
                Array.Clear(prodARR, 0, prodARR.Length);
                textboxBarcode.Focus();
            }
        }
        private void textboxCostPrice_OnValueChanged(object sender, EventArgs e)
        {
            if (textboxCostPrice.Text!="")
            {
                if (!rg.Match(textboxCostPrice.Text).Success)
                {
                    textboxCostPrice.Text = "";
                    textboxCostPrice.Focus();
                }
                
            }
        }

        
    }
}
