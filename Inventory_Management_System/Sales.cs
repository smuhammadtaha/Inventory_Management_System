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
using System.Transactions;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Sales : Form
    {
        AddSales prr;
        Regex rg = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        public Sales()
        {
            InitializeComponent();
            

        }
        public int productId;
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            prr = new AddSales(this);
            prr.Show();
        }

        //public void saler()

        //{
        //    if (datagridviewSales.Rows.Count != 0)
        //    {
        //        foreach (DataGridViewRow row in datagridviewSales.Rows)
        //        {
        //            if (row.Cells["proID"].Value.ToString() == productId.ToString())
        //            {
        //                float total;
        //                //int Quan = Convert.ToInt32(row.Cells[""])
        //            }
        //        }
        //    }

        //}

        private void Sales_Load(object sender, EventArgs e)
        {
            //AddSales ad = new AddSales();
            //ad.Show();

        }
        public string[] productData = new string[6];
        public string[] getProductsWRTBarcode(String barcode)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductByBarcode", MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                MainClass.sqlcon.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        productData[0] = sdr[0].ToString();//product id
                        productData[1] = sdr[1].ToString();//product
                        productData[2] = sdr[2].ToString();//barcode
                        productData[3] = sdr[3].ToString();//selling price
                        productData[4] = sdr[4].ToString();//discount
                        productData[5] = sdr[5].ToString();//final selling price
                    }
                }
                else
                {
                    Array.Clear(productData, 0, productData.Length);
                }
                MainClass.sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return productData;
        }
        Stocks stk = new Stocks();
        public float Gross=0;
        bool productCheck;
        public string[] prodARR = new String[6];
        public void condition()
        {
            if (prr.BarCodetxt.Text != "")
            {
                prr.Grosstxt.Text = "";
                prr.DiscTxt.Text = "";
                prr.AmtTxt.Text = "";
                prr.ChangeTxt.Text = "";
                int qCount = 0, sQuant = 0, nCount = 0;
                prodARR = getProductsWRTBarcode(prr.BarCodetxt.Text);
                foreach (DataGridViewRow row in datagridviewSales.Rows)
                {
                    if (prodARR[0] == row.Cells["proIdGv"].Value.ToString())
                    {
                        qCount = qCount + Convert.ToInt32(row.Cells["quanGv"].Value.ToString());
                    }
                }
                sQuant = Convert.ToInt32(stk.getProductQuantity(Convert.ToInt64(prodARR[0])));
                nCount = sQuant - qCount;
                if (nCount <= 0)
                {

                }
                else
                {
                    if (datagridviewSales.RowCount == 0)
                    {
                        
                       
                            datagridviewSales.Rows.Add(Convert.ToInt32(prodARR[0]), prodARR[1], 1, Convert.ToSingle(prodARR[3]), prodARR[4], Convert.ToSingle(prodARR[5]));
                        
                    }
                    else
                    {
                        foreach (DataGridViewRow row in datagridviewSales.Rows)
                        {
                            if (row.Cells["proIdGv"].Value.ToString() == prodARR[0])

                            {
                                productCheck = true;
                                break;

                            }
                            else
                            {
                                productCheck = false;
                                //datagridviewSales.Rows.Add(Convert.ToInt32(prodARR[0]), prodARR[1], 1, Convert.ToSingle(prodARR[3]), prodARR[4], Convert.ToSingle(prodARR[5]));
                            }

                        }

                        if (productCheck == true)
                        {
                            
                            foreach (DataGridViewRow row in datagridviewSales.Rows)
                            {
                                if (row.Cells["proIdGv"].Value.ToString() == prodARR[0])
                                {
                                    float disc = 0;
                                    if (row.Cells["discGV"].Value.ToString() != null)
                                    {
                                        disc = Convert.ToSingle(row.Cells["discGV"].Value.ToString()) + Convert.ToSingle(row.Cells["discGV"].Value.ToString());
                                        row.Cells["discGV"].Value = disc;
                                    }
                                        Convert.ToInt32(row.Cells["pupGv"].Value);
                                        row.Cells["quanGv"].Value = Convert.ToInt32(row.Cells["quanGv"].Value.ToString()) + 1;
                                        float tot = (Convert.ToSingle(row.Cells["pupGv"].Value.ToString()) * Convert.ToInt32(row.Cells["quanGv"].Value.ToString())) - Convert.ToSingle(row.Cells["discGV"].Value.ToString());
                                        row.Cells["TotGv"].Value = tot;
                                    
                                    
                                }

                            }
                        }
                        else
                        {
                            datagridviewSales.Rows.Add(Convert.ToInt32(prodARR[0]), prodARR[1], 1, Convert.ToSingle(prodARR[3]), prodARR[4], Convert.ToSingle(prodARR[5]));
                        }
                    }
                    foreach (DataGridViewRow item in datagridviewSales.Rows)
                    {
                        Gross += Convert.ToSingle(item.Cells["TotGv"].Value.ToString());
                    }
                    Grosslabel.Text = Math.Round(Gross, 0).ToString();
                    Gross = 0;
                    prr.BarCodetxt.Focus();
                    prr.BarCodetxt.Text = "";
                }

            }
        }


        public void checkbtn()
        {
            if (datagridviewSales.Rows.Count > 0)
            {
                float dis = 0, gross = 0;
                foreach(DataGridViewRow row in datagridviewSales.Rows)
                {
                    dis += Convert.ToSingle(row.Cells["discGV"].Value.ToString());
                    gross += Convert.ToSingle(row.Cells["TotGv"].Value.ToString());
                }
                prr.Grosstxt.Text = Math.Round(gross, 0).ToString();
                prr.DiscTxt.Text = Math.Round(dis,0).ToString();
            }
        }
        public void amtgiven()
        {
            if (prr.AmtTxt.Text != "")
            {
                if (!rg.Match(prr.AmtTxt.Text).Success)
                {
                    prr.AmtTxt.Text = "";
                    prr.AmtTxt.Focus();
                }
                
            }
        }
        public void validamtgiven()
        {
            if (prr.AmtTxt.Text != "" && prr.Grosstxt.Text != "")
            {
                if (!(Convert.ToSingle(prr.Grosstxt.Text) <= Convert.ToSingle(prr.AmtTxt.Text)))
                {
                    prr.AmtTxt.Text = "";
                    prr.ChangeTxt.Text = "";
                    prr.AmtTxt.Focus();
                }
                else
                {
                    float amountGiven = Convert.ToSingle(prr.AmtTxt.Text);
                    float amountReturn = amountGiven - Convert.ToSingle(prr.Grosstxt.Text);
                    prr.ChangeTxt.Text = Math.Round(amountReturn,0).ToString();
                }
            }
            else
            {
                prr.ChangeTxt.Text = "";
            }
        }
    

        private void textboxSuppSearch_Validating(object sender, CancelEventArgs e)
        {
           
        }
       
        private void btnDelSupplier_Click(object sender, EventArgs e)
        {
            int rowindex = datagridviewSales.CurrentCell.RowIndex;
            prr.Grosstxt.Text = "";
            prr.DiscTxt.Text = "";
            prr.AmtTxt.Text = "";
            prr.ChangeTxt.Text = "";
            float gt,tot,dis;
            DataGridViewRow row = datagridviewSales.Rows[rowindex];
            int q = Convert.ToInt32(row.Cells["quanGv"].Value.ToString());
            if (q == 1)
            {
                gt = Convert.ToSingle(Grosslabel.Text);
                gt = gt - Convert.ToSingle(row.Cells["TotGv"].Value.ToString());
                Grosslabel.Text = gt.ToString();
                MessageBox.Show("Are You sure to delete this row ?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                datagridviewSales.Rows.RemoveAt(rowindex);
                
            }
            else if (q > 1)
            {
                q--;
                row.Cells["quanGv"].Value = q;
                dis = Convert.ToSingle(row.Cells["discGV"].Value.ToString()) - Convert.ToSingle(prodARR[4]);
                row.Cells["discGV"].Value = dis;
                tot =Convert.ToSingle(row.Cells["quanGv"].Value.ToString())* Convert.ToSingle(row.Cells["pupGv"].Value.ToString())-dis;
                row.Cells["TotGv"].Value = tot;
                foreach (DataGridViewRow item in datagridviewSales.Rows)
                {
                    Gross += Convert.ToSingle(item.Cells["TotGv"].Value.ToString());
                }
                Grosslabel.Text = Gross.ToString();
                Gross = 0;
             

            }
        }

        private void datagridviewSales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
                btnDelSupplier.Enabled = true;
     
        }
        private object productStockCount = 0;

        public object getProductQuantity(Int64 proID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                productStockCount = cmd.ExecuteScalar();
            }
            catch (Exception)
            {

            }
            return productStockCount;
        }

        public void UpdateStock(Int64 proID, int Quan)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updatestock", MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@Quan", Quan);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MainClass.sqlcon.Close();
            }
        }

        int salCount = 0;
        Int64 salesID;
        public void insertSales(DataGridView gv, string proIDgv, string proQuan, int doneBy, DateTime dt, float tAmount, float tDiscount, float aGiven, float aReturned,string payType)
        {
            try
            {
                using(TransactionScope sc=new TransactionScope())
                {
                    SqlCommand cmd = new SqlCommand("insertsales", MainClass.sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@done", doneBy);
                    cmd.Parameters.AddWithValue("@date", dt);
                    cmd.Parameters.AddWithValue("@totamt", tAmount);
                    cmd.Parameters.AddWithValue("@totdis", tDiscount);
                    cmd.Parameters.AddWithValue("@given", aGiven);
                    cmd.Parameters.AddWithValue("@return", aReturned);
                    if(payType == "Cash")
                    {
                        cmd.Parameters.AddWithValue("@pyType", 1);
                    }
                    else if(payType == "Debit Card")
                    {
                        cmd.Parameters.AddWithValue("@pyType", 2);
                    }
                    else if (payType == "Credit Card")
                    {
                        cmd.Parameters.AddWithValue("@pyType", 3);
                    }

                    MainClass.sqlcon.Open();
                    salCount = cmd.ExecuteNonQuery();
                    if (salCount > 0)
                    {
                        SqlCommand cmd2 = new SqlCommand("st_getSalesID", MainClass.sqlcon);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        salesID = Convert.ToInt64(cmd2.ExecuteScalar());
                        foreach (DataGridViewRow row in gv.Rows)
                        {
                            SqlCommand cmd3 = new SqlCommand("st_insertSalesDetails", MainClass.sqlcon);
                            cmd3.CommandType = CommandType.StoredProcedure;
                            cmd3.Parameters.AddWithValue("@salID", salesID);
                            cmd3.Parameters.AddWithValue("@proID", Convert.ToInt64(row.Cells[proIDgv].Value.ToString()));
                            cmd3.Parameters.AddWithValue("@quan", Convert.ToInt32(row.Cells[proQuan].Value.ToString()));
                            cmd3.ExecuteNonQuery();
                            int stockofProduct =Convert.ToInt32(getProductQuantity(Convert.ToInt64(row.Cells[proIDgv].Value.ToString())));
                            int currentQuan = Convert.ToInt32(row.Cells[proQuan].Value.ToString());
                            int finalProductQty = stockofProduct - currentQuan;
                            UpdateStock(Convert.ToInt64(row.Cells[proIDgv].Value.ToString()), finalProductQty);
                        }
                    }
                    MainClass.sqlcon.Close();
                    MessageBox.Show("Sale Successfull","Success");
                    sc.Complete();
                }
                
            }
            catch (Exception ex)
            {
                MainClass.sqlcon.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void paybtn()
        {
            if (prr.AmtTxt.Text != "" && prr.DiscTxt.Text != "" && prr.Grosstxt.Text != "" && prr.paymentDD.SelectedIndex != -1 && prr.ChangeTxt.Text != "")
            {
                prr.Error1.Visible = false;
                prr.Error2.Visible = false;
                prr.Error3.Visible = false;
                prr.Error4.Visible = false;
                prr.Error5.Visible = false;
                DialogResult dr = MessageBox.Show("\n\tTotal Amount : "+prr.Grosstxt.Text+"\nTotal Discount : "+prr.DiscTxt.Text+"\n\tAmount Given : "+prr.AmtTxt.Text+ "\n\t Returned :"+prr.ChangeTxt.Text+ "\n\n Are You Sure, Submit Current Sales ?\n", "Question...",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                 insertSales(datagridviewSales, "proIdGv", "quanGv", Form1.getUserID, DateTime.Now, Convert.ToSingle(prr.Grosstxt.Text), Convert.ToSingle(prr.DiscTxt.Text), Convert.ToSingle(prr.AmtTxt.Text), Convert.ToSingle(prr.ChangeTxt.Text),prr.paymentDD.SelectedItem.ToString());
                    prr.AmtTxt.Text = "";
                    prr.DiscTxt.Text = "";
                    prr.Grosstxt.Text = "";
                    prr.paymentDD.SelectedIndex = 0;
                    prr.ChangeTxt.Text = "";
                    datagridviewSales.Rows.Clear();
                    Grosslabel.Text = "0.00";
                }
            }
            else
            {
                prr.BarCodetxt.BorderColorFocused = System.Drawing.Color.Red;
                prr.BarCodetxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                prr.BarCodetxt.BorderColorMouseHover = System.Drawing.Color.Red;
                prr.Grosstxt.BorderColorFocused = System.Drawing.Color.Red;
                prr.Grosstxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                prr.Grosstxt.BorderColorMouseHover = System.Drawing.Color.Red;
                prr.DiscTxt.BorderColorFocused = System.Drawing.Color.Red;
                prr.DiscTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                prr.DiscTxt.BorderColorMouseHover = System.Drawing.Color.Red;
                prr.AmtTxt.BorderColorFocused = System.Drawing.Color.Red;
                prr.AmtTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                prr.AmtTxt.BorderColorMouseHover = System.Drawing.Color.Red;
                prr.ChangeTxt.BorderColorFocused = System.Drawing.Color.Red;
                prr.ChangeTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                prr.ChangeTxt.BorderColorMouseHover = System.Drawing.Color.Red;
                prr.Error1.Visible = true;
                prr.Error2.Visible = true;
                prr.Error3.Visible = true;
                prr.Error4.Visible = true;
                prr.Error5.Visible = true;
            }
        }

        private void Printbtn_Click(object sender, EventArgs e)
        {
            SalesReport sr = new SalesReport();
            sr.Show();
        }
    }
}
    

