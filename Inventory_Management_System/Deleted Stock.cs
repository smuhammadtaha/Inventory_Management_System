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
    public partial class Deleted_Stock : Form
    {
        public Deleted_Stock()
        {
            InitializeComponent();
        }

        private void Deleted_Stock_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("deletedPurchaseItems", MainClass.sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            p_idGV.DataPropertyName = dt.Columns["Purchase ID"].ToString();
            Usr_idGV.DataPropertyName = dt.Columns["User ID"].ToString();
            pro_idGV.DataPropertyName = dt.Columns["Product ID"].ToString();
            Pro_QuanGV.DataPropertyName = dt.Columns["Product Quantity"].ToString();
            Dlt_dateGV.DataPropertyName = dt.Columns["Delete Date"].ToString();
            datagridviewDeletedItems.DataSource = dt;
        }
    }
}
