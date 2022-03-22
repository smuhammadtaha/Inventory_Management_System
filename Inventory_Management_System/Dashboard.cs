using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
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
    public partial class Dashboard : Form
    {
        Categories c = new Categories();
        Products p = new Products();
        Supplier s = new Supplier();
        Purchase pp = new Purchase();
        Sales ss = new Sales();
        ViewPurchasetab vpt = new ViewPurchasetab();
        Stocks st = new Stocks();
        Price pri = new Price();
        Reports rp = new Reports();
        DashBoardUI ui = new DashBoardUI();
        Deleted_Stock ds = new Deleted_Stock();
        public Dashboard(string role)
        {
            InitializeComponent();
           
            labelRole.Text = role;
            pictureBox5.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (labelRole.Text == "moid")
            {
                c.btnAddCategory.Enabled = false;
                c.btnDelCat.Enabled = false;
                c.btnEditCat.Enabled = false;
            }
            txtWindowName.Text = "Categories";
            c.TopLevel = false;
            panel3.Controls.Add(c);
            c.BringToFront();
            c.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            txtWindowName.Text = "Dashboard";
            ui.TopLevel = false;
            panel3.Controls.Add(ui);
            ui.BringToFront();
            ui.Show();

            try
            {
                MainClass.sqlcon.Open();
                string qu = "select sum(purchase_details.pid_totprice) as finalprice from purchase_details";
                SqlCommand cmd = new SqlCommand(qu, MainClass.sqlcon);
                SqlDataAdapter ads = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ads.Fill(dt);
                cmd.ExecuteNonQuery();
                MainClass.sqlcon.Close();
                if (dt.Rows.Count > 0)
                {
                    ui.buyingprice = Convert.ToInt32(dt.Rows[0]["finalprice"]);
                }
            }
            catch (Exception)
            {

                throw;
            }


            try
            {
                MainClass.sqlcon.Open();
                string qu = "select sum(sales.sal_totAmt) as finalsale from sales";
                SqlCommand cmd = new SqlCommand(qu, MainClass.sqlcon);
                SqlDataAdapter ads = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ads.Fill(dt);
                cmd.ExecuteNonQuery();
                MainClass.sqlcon.Close();
                if (dt.Rows.Count > 0)
                {
                    ui.sellingprice = Convert.ToInt32(dt.Rows[0]["finalsale"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (ui.sellingprice >= ui.buyingprice)
            {
                ui.ProgressBarProfit.Width = 292;
                ui.ProgressBarLoss.Width = 80;
                ui.cartesianChart1.Series = new SeriesCollection
            {

                new LineSeries
                {

                    Values=new ChartValues<ObservablePoint>
                    {

                        new ObservablePoint(0,10),
                        new ObservablePoint(4,7),
                        new ObservablePoint(5,3),
                        new ObservablePoint(7,6),
                        new ObservablePoint(10,8),
                    },
                    PointGeometrySize=15
                },
                new LineSeries
                {
                    Values=new ChartValues<ObservablePoint>
                    {
                        //new ObservablePoint(0,2),
                        //new ObservablePoint(4,5),
                        //new ObservablePoint(5,6),
                        //new ObservablePoint(7,8),
                        //new ObservablePoint(10,6),
                    },
                    PointGeometrySize=15
                },
                };


            }

            else if (ui.buyingprice > ui.sellingprice)
            {
                ui.ProgressBarProfit.Width = 90;
                ui.ProgressBarLoss.Width = 292;
                ui.cartesianChart1.Series = new SeriesCollection
            {

                new LineSeries
                {

                    Values=new ChartValues<ObservablePoint>
                    {
                        
                        //new ObservablePoint(0,10),
                        //new ObservablePoint(4,7),
                        //new ObservablePoint(5,3),
                        //new ObservablePoint(7,6),
                        //new ObservablePoint(10,8),
                    },
                    PointGeometrySize=15
                },
                new LineSeries
                {
                    Values=new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,2),
                        new ObservablePoint(4,5),
                        new ObservablePoint(5,6),
                        new ObservablePoint(7,8),
                        new ObservablePoint(10,6),
                    },
                    PointGeometrySize=15
                },
              };
            }

            try
            {
                MainClass.sqlcon.Open();
                string qu = "select count(sup_id) as CsupID from supplier ";
                SqlCommand cmd = new SqlCommand(qu, MainClass.sqlcon);
                SqlDataAdapter ads = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ads.Fill(dt);
                cmd.ExecuteNonQuery();
                MainClass.sqlcon.Close();
                if (dt.Rows.Count > 0)
                {
                    ui.lblavaSup.Text = dt.Rows[0]["CsupID"].ToString();
                }

            }
            catch (Exception)
            {
                throw;
            }

            try
            {
                MainClass.sqlcon.Open();
                string qu = "select count(cat_id) as Ccat_ID from categories";
                SqlCommand cmd = new SqlCommand(qu, MainClass.sqlcon);
                SqlDataAdapter ads = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ads.Fill(dt);
                cmd.ExecuteNonQuery();
                MainClass.sqlcon.Close();
                if (dt.Rows.Count > 0)
                {
                    ui.lblAvaiCat.Text = dt.Rows[0]["Ccat_ID"].ToString();
                }

            }
            catch (Exception)
            {
                throw;
            }

            try
            {
                MainClass.sqlcon.Open();
                string qu = "select count(pro_id) as Cpro_ID from products";
                SqlCommand cmd = new SqlCommand(qu, MainClass.sqlcon);
                SqlDataAdapter ads = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ads.Fill(dt);
                cmd.ExecuteNonQuery();
                MainClass.sqlcon.Close();
                if (dt.Rows.Count > 0)
                {
                    ui.lblTotProd.Text = dt.Rows[0]["Cpro_ID"].ToString();
                }

            }
            catch (Exception)
            {
                throw;
            }

            try
            {
                MainClass.sqlcon.Open();
                string qu = "select sum(st_quan) as totQuan from stock";
                SqlCommand cmd = new SqlCommand(qu, MainClass.sqlcon);
                SqlDataAdapter ads = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ads.Fill(dt);
                cmd.ExecuteNonQuery();
                MainClass.sqlcon.Close();
                if (dt.Rows.Count > 0)
                {
                    ui.lblTotStock.Text = dt.Rows[0]["totQuan"].ToString();
                }


            }
            catch (Exception)
            {
                throw;
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (labelRole.Text == "moid")
            {
                p.btnAddProducts.Enabled = false;
                p.btnDelProducts.Enabled = false;
                p.btnEditProducts.Enabled = false;
            }
            txtWindowName.Text = "Products";
            p.TopLevel = false;
            panel3.Controls.Add(p);
            p.BringToFront();
            p.Show();
        }

        private void btnManageSuppliers_Click(object sender, EventArgs e)
        {
            if (labelRole.Text == "moid")
            {
                s.btnAddSupplier.Enabled = false;
                s.btnDelSupplier.Enabled = false;
                s.btnEditSupplier.Enabled = false;
            }
            txtWindowName.Text = "Suppliers";
            s.TopLevel = false;
            panel3.Controls.Add(s);
            s.BringToFront();
            s.Show();
        }

        private void btnManagePurchases_Click(object sender, EventArgs e)
        {
            if (labelRole.Text == "moid")
            {
                pp.btnAddPurchase.Enabled = false;
                pp.btnDelPurchase.Enabled = false;
                pp.btnSavePurchase.Enabled = false;
                pp.Printbtn.Enabled = false;
            }
            txtWindowName.Text = "Purchases";
            pp.TopLevel = false;
            panel3.Controls.Add(pp);
            pp.BringToFront();
            pp.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            txtWindowName.Text = "Sales";
            ss.TopLevel = false;
            panel3.Controls.Add(ss);
            ss.BringToFront();
            ss.Show();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            //if (labelRole.Text == "moid")
            //{
            //    vpt.btnDelPurchase.Enabled = false;
            //}
            txtWindowName.Text = "View Purchases";
            vpt.TopLevel = false;
            panel3.Controls.Add(vpt);
            vpt.BringToFront();
            vpt.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            txtWindowName.Text = "Stocks";
            st.TopLevel = false;
            panel3.Controls.Add(st);
            st.BringToFront();
            st.Show();
            st.showStock(st.datagridviewStock, st.proIdGv, st.Product, st.barGV, st.expiryGV, st.bpGV, st.spGV, st.catGV, st.quanGv, st.statusGV, st.finalGV);

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            pri.loadCategory();
            if (labelRole.Text == "moid")
            {
                pri.btnDelPurchase.Enabled = false;
                pri.btnSavePurchase.Enabled = false;
            }
            txtWindowName.Text = "Product Pricing";
            pri.TopLevel = false;
            panel3.Controls.Add(pri);
            pri.BringToFront();
            pri.Show();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            txtWindowName.Text = "Reports";
            rp.TopLevel = false;
            panel3.Controls.Add(rp);
            rp.BringToFront();
            rp.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (panel2.Width == 47)
            {
                panel2.Visible = false;
                panel2.Width = 200;
                pictureBox5.Hide();
                bunifuTransition1.ShowSync(panel2);
                bunifuTransition2.ShowSync(pictureBox2);
            }
            else
            {
                pictureBox2.Hide();
                pictureBox5.Show();
                panel2.Visible = false;
                panel2.Width = 47;
                bunifuTransition1.ShowSync(panel2);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            txtWindowName.Text = "Dashboard";
            ui.TopLevel = false;
            panel3.Controls.Add(ui);
            ui.BringToFront();
            ui.Show();
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            
            txtWindowName.Text = "Deleted Stock";
            ds.TopLevel = false;
            panel3.Controls.Add(ds);
            ds.BringToFront();
            ds.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (labelRole.Text == "moid")
            {
                bunifuFlatButton9.Hide();
             
                
            }
        }
        
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
