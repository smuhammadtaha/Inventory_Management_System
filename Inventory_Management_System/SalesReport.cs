using CrystalDecisions.CrystalReports.Engine;
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
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
        }

        
        
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           
        }
        private void SalesReport_Load(object sender, EventArgs e)
        {
            try
            {
                if (Reports.SaleID == 0)
                {
                    SqlCommand cmd = new SqlCommand("st_getSalesReceipt", MainClass.sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    salesRecipt rd = new salesRecipt();
                    rd.SetDataSource(dt);
                    crystalReportViewer1.ReportSource = rd;
                    crystalReportViewer1.RefreshReport();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("st_getSalesReceiptWRTSalesID", MainClass.sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@salesID", Reports.SaleID);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    salesRecipt rd = new salesRecipt();
                    rd.SetDataSource(dt);
                    crystalReportViewer1.ReportSource = rd;
                    crystalReportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
