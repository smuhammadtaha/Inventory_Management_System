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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            StockGridview.AutoGenerateColumns = false;
        }

        public void sales(DateTime date,DataGridView gv , DataGridViewColumn salIDGV,DataGridViewColumn totAmountGV, DataGridViewColumn toDisGV,DataGridViewColumn amountGivenGV,DataGridViewColumn amountReturnedGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getSales", MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date",date);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                salIDGV.DataPropertyName = dt.Columns["Salesman id"].ToString();
                totAmountGV.DataPropertyName = dt.Columns["Total Amount"].ToString();
                toDisGV.DataPropertyName = dt.Columns["Total Discount"].ToString();
                amountGivenGV.DataPropertyName = dt.Columns["Amount Given"].ToString();
                amountReturnedGV.DataPropertyName = dt.Columns["Amount Return"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            datagridviewReport.AutoGenerateColumns = false;
            sales(metroDateTime1.Value,datagridviewReport, salIDGV, totAmtGV,totDisGV,givenGV,returendGV);
        }
        public static int SaleID;
        private void datagridviewReport_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(e.RowIndex!= -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = datagridviewReport.Rows[e.RowIndex];
                SaleID = Convert.ToInt32(row.Cells["salIDGV"].Value.ToString());
                SalesReport sr = new SalesReport();
                sr.Show();
            }
        }
        public void purchase(DateTime dat,DataGridView gv,DataGridViewColumn proID,DataGridViewColumn compGV, DataGridViewColumn barcodeGV, DataGridViewColumn proNameGV,DataGridViewColumn priceGV,DataGridViewColumn QuanGV,DataGridViewColumn TotalGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("getPurchase", MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", dat);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                proID.DataPropertyName = dt.Columns["Purchase ID"].ToString();
                compGV.DataPropertyName = dt.Columns["Company Name"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                proNameGV.DataPropertyName = dt.Columns["Product Name"].ToString();
                priceGV.DataPropertyName = dt.Columns["Product Price"].ToString();
                QuanGV.DataPropertyName = dt.Columns["Product Quantity"].ToString();
                TotalGV.DataPropertyName = dt.Columns["Total Price"].ToString();


                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            purchase(metroDateTime2.Value, Purchasegridview,purIDGV, CompGV, barcodeGV, proNameGV, propriGV, proQuanGV, totlGV);
        }
        public static int PurID;

        private void Purchasegridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = Purchasegridview.Rows[e.RowIndex];
                PurID = Convert.ToInt32(row.Cells["purIDGV"].Value.ToString());
                PurchaseReport sr = new PurchaseReport();
                sr.Show();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            purchase(metroDateTime3.Value, DailyGridview,purchaseIDGVD,CompNameGVD,barcoGVD,ProdNameGVD,prodPriceGVD,prodQuanGVD,totPriceGVD);
        }

        private void DailyGridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = DailyGridview.Rows[e.RowIndex];
                PurID = Convert.ToInt32(row.Cells["purchaseIDGVD"].Value.ToString());
                PurchaseReport sr = new PurchaseReport();
                sr.Show();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            sales(metroDateTime4.Value, datGridviewDailySales, salesIDGVD, totAmountGVD, totDiscGVD, amountGivenGVD, amountRetGVD);
        }

        private void datGridviewDailySales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = datGridviewDailySales.Rows[e.RowIndex];
                SaleID = Convert.ToInt32(row.Cells["salesIDGVD"].Value.ToString());
                SalesReport sr = new SalesReport();
                sr.Show();
            }
        }

        public void updateStock(DateTime dyt,DataGridView gv,DataGridViewColumn prodIDGV,DataGridViewColumn prodNameGV,DataGridViewColumn barcodeGV,DataGridViewColumn expDateGV,DataGridViewColumn buyingPriceGV,DataGridViewColumn quantityGV,DataGridViewColumn spricepGV,DataGridViewColumn availableStockGV,DataGridViewColumn statusGV,DataGridViewColumn totAmountGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getStock", MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@date", dyt);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                prodIDGV.DataPropertyName = dt.Columns["Purchase ID"].ToString();
                prodNameGV.DataPropertyName = dt.Columns["Product Name"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                expDateGV.DataPropertyName = dt.Columns["Expiry Date"].ToString();
                buyingPriceGV.DataPropertyName = dt.Columns["Buying Price"].ToString();
                quantityGV.DataPropertyName = dt.Columns["Quantity"].ToString();
                spricepGV.DataPropertyName = dt.Columns["SPrice"].ToString();
                availableStockGV.DataPropertyName = dt.Columns["Avaliable Stock"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                totAmountGV.DataPropertyName = dt.Columns["Total Amount"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            updateStock(metroDateTime5.Value, StockGridview, prodIdGVS, prodNameGVS, barcodeGVS, expDateGVS, buyingPriceGVS,QtyGVS,sellingPriceGVS, availableStockGVS, statusGVS, totAmountGVS);
        }
        public static int StockID;
        private void StockGridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = StockGridview.Rows[e.RowIndex];
                StockID = Convert.ToInt32(row.Cells["prodIdGVS"].Value.ToString());
                UpdateStockReport sr = new UpdateStockReport();
                sr.Show();
            }
        }
    }
}
