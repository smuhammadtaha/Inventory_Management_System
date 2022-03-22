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
    public partial class UpdatePurchase : Form
    {
        public UpdatePurchase()
        {
            InitializeComponent();
        }


        private void btnAddPurchase_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_productUpdate", MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", textboxProdName.Text);
                cmd.Parameters.AddWithValue("@barcode", textboxBarcode.Text);
                cmd.Parameters.AddWithValue("@dop", dateOfPurchase.Value);
                cmd.Parameters.AddWithValue("@catID", Convert.ToInt32(comboboxSupplier.SelectedValue));
                cmd.Parameters.AddWithValue("@proID", textboxProdQty);
                MainClass.sqlcon.Open();
                cmd.ExecuteNonQuery();
                MainClass.sqlcon.Close();
                MessageBox.Show("Data Updated Successfully");
                this.Hide();
            }
            catch (Exception ex)
            {
                MainClass.sqlcon.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
