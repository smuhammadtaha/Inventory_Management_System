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
    public partial class PurchaseReport : Form
    {
        public PurchaseReport()
        {
            InitializeComponent();
        }

        private void PurchaseReport_Load(object sender, EventArgs e)
        {
            try
            {
                if (Reports.PurID == 0)
                {
                    SqlCommand cmd = new SqlCommand("purchaseReport", MainClass.sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    PurchaseReports rd = new PurchaseReports();
                    rd.SetDataSource(dt);
                    crystalReportViewer1.ReportSource = rd;
                    crystalReportViewer1.RefreshReport();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("purchaseReportWRTPurchaseID", MainClass.sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@purchaseID", Reports.PurID);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    PurchaseReports rd = new PurchaseReports();
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
