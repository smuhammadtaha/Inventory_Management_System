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
    public partial class Supplier : Form
    {
        public int supplierId;
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;
        //short stat;
        public int rowIndex;
        public Supplier()
        {
            InitializeComponent();
      
        }
        private void Supplier_Load(object sender, EventArgs e)
        {
            loadSuppliersData();
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            AddSupplier adds = new AddSupplier();
            adds.Show();
        }

        public void loadSuppliersData()
        {
            try
            {
                cmd = new SqlCommand("st_getSupplierData", MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                sda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sda.Fill(dt);
                suppIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                companyGV.DataPropertyName = dt.Columns["Company"].ToString();
                personGV.DataPropertyName = dt.Columns["Contact Person"].ToString();
                phone1GV.DataPropertyName = dt.Columns["Phone 1"].ToString();
                phone2GV.DataPropertyName = dt.Columns["Phone 2"].ToString();
                addressGV.DataPropertyName = dt.Columns["Address"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                ntnGV.DataPropertyName = dt.Columns["NTN #"].ToString();
                datagridviewSupplier.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnViewSuppliers_Click(object sender, EventArgs e)
        {
            loadSuppliersData();
        }

        private void datagridviewSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void btnDelSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                int cateId;
                DataGridViewRow row = datagridviewSupplier.Rows[rowIndex];
                cateId = Convert.ToInt32(row.Cells["suppIDGV"].Value.ToString());
                cmd = new SqlCommand("st_deleteSupplier", MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@suppID", cateId);
                MainClass.sqlcon.Open();
                cmd.ExecuteNonQuery();
                MainClass.sqlcon.Close();
                loadSuppliersData();
            }
            catch (Exception ex)
            {
                MainClass.sqlcon.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            
            
        }

        private void textboxSuppSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Company like '%{0}%'", textboxSuppSearch.Text);
            datagridviewSupplier.DataSource = dv.ToTable();
        }

        private void textboxSuppSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditSupplier_Click_1(object sender, EventArgs e)
        {
            if (rowIndex != -1)
            {
                UpdateSupplier s = new UpdateSupplier();
                s.Show();
                DataGridViewRow row = datagridviewSupplier.Rows[rowIndex];
                s.supplierId = Convert.ToInt32(row.Cells["suppIDGV"].Value.ToString());
                s.textboxSuppName.Text = row.Cells["companyGV"].Value.ToString();
                s.textboxContPerson.Text = row.Cells["personGV"].Value.ToString();
                s.textboxPhone1.Text = row.Cells["phone1GV"].Value.ToString();
                s.textboxPhone2.Text = row.Cells["phone2GV"].Value.ToString();
                s.textboxNTN.Text = row.Cells["ntnGV"].Value.ToString();
                s.comboboxSuppStatus.SelectedItem = row.Cells["statusGV"].Value.ToString();
                s.textboxAddress.Text = row.Cells["addressGV"].Value.ToString();
            }
        }

        private void datagridviewSupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelSupplier.Enabled = true;
        }
    }
}
