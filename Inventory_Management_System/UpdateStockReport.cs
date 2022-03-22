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
    public partial class UpdateStockReport : Form
    {
        public UpdateStockReport()
        {
            InitializeComponent();
        }

        private void UpdateStockReport_Load(object sender, EventArgs e)
        {
            try
            {
                if (Reports.StockID == 0)
                {
                    SqlCommand cmd = new SqlCommand("StockReport", MainClass.sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    StockReporting rd = new StockReporting();
                    rd.SetDataSource(dt);
                    crystalReportViewer1.ReportSource = rd;
                    crystalReportViewer1.RefreshReport();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("updatesStockWRTpurchaseID", MainClass.sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@purchaseID", Reports.StockID);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    StockReporting rd = new StockReporting();
                    rd.SetDataSource(dt);
                    crystalReportViewer1.ReportSource = rd;
                    crystalReportViewer1.RefreshReport();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
