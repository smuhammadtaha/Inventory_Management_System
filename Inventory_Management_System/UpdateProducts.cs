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
    public partial class UpdateProducts : Form
    {
        public int productId;
        
        public UpdateProducts()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            if(textboxProName.Text==""&& textboxBarcode.Text == "")
            {
                textboxProName.BorderColorFocused = System.Drawing.Color.Red;
                textboxProName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                textboxProName.BorderColorMouseHover = System.Drawing.Color.Red;
                textboxBarcode.BorderColorFocused = System.Drawing.Color.Red;
                textboxBarcode.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                textboxBarcode.BorderColorMouseHover = System.Drawing.Color.Red;
                Error1.Visible = true;
                Error2.Visible = true;
            }
            else
            {
                Error1.Visible = false;
                Error2.Visible = false;

                try
            {
                SqlCommand cmd = new SqlCommand("st_productUpdate", MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name",textboxProName.Text);
                cmd.Parameters.AddWithValue("@barcode",textboxBarcode.Text);
                cmd.Parameters.AddWithValue("@expiry",dateExpiry.Value);
                cmd.Parameters.AddWithValue("@catID",Convert.ToInt32(comboboxCategory.SelectedValue));
                cmd.Parameters.AddWithValue("@proID", productId);
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
        }

        private void UpdateProducts_Load(object sender, EventArgs e)
        {
            try
            {
                comboboxCategory.Items.Clear();
                SqlCommand cmd = new SqlCommand("st_getCategoriesList", MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                comboboxCategory.DataSource = dt;
                comboboxCategory.DisplayMember = "Category";
                comboboxCategory.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textboxProName_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
