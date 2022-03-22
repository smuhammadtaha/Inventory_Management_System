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
    public partial class DashBoardUI : Form
    {
        public int sellingprice;public int buyingprice;
        public DashBoardUI()
        {
            InitializeComponent();

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
                    buyingprice = Convert.ToInt32(dt.Rows[0]["finalprice"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    sellingprice = Convert.ToInt32(dt.Rows[0]["finalsale"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (sellingprice >= buyingprice)
            {
                ProgressBarProfit.Width = 292;
                ProgressBarLoss.Width = 80;

            cartesianChart1.Series = new SeriesCollection
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

            else if (buyingprice > sellingprice)
            {
                ProgressBarProfit.Width = 90;
                ProgressBarLoss.Width = 292;
            cartesianChart1.Series = new SeriesCollection
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

            supData();

        }

       


public void supData()
        {

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
                   lblavaSup.Text = dt.Rows[0]["CsupID"].ToString();
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
                   lblAvaiCat.Text = dt.Rows[0]["Ccat_ID"].ToString();
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
                    lblTotProd.Text = dt.Rows[0]["Cpro_ID"].ToString();
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
                    lblTotStock.Text = dt.Rows[0]["totQuan"].ToString();
                }


            }
            catch (Exception)
            {
                throw;
            }
        }

        private void DashBoardUI_Load(object sender, EventArgs e)
        {
            //    Supplier sp = new Supplier();
            ////    int GVrowCount;
            ////    GVrowCount = sp.datagridviewSupplier.RowCount;
            ////    lblTotalSuppliers.Text = GVrowCount.ToString();

            //int GVrowCount;
            //GVrowCount = sp.datagridviewSupplier.RowCount;
        }
    }
}
