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
    public partial class AddProducts : Form
    {
        public int prodId;
        public AddProducts()
        {
            InitializeComponent();
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            
            if (textboxProName.Text != "" && comboboxCategory.SelectedIndex != -1 && textboxBarcode.Text!="" && dateExpiry.Value>DateTime.Now )
            {
                try
                {
                    Error1.Visible = false;
                    Error2.Visible = false;
                    SqlCommand cmd = new SqlCommand("st_productInsert",MainClass.sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name",textboxProName.Text);
                    cmd.Parameters.AddWithValue("@barcode",textboxBarcode.Text);
                    cmd.Parameters.AddWithValue("@expiry",dateExpiry.Value);
                    cmd.Parameters.AddWithValue("@catID",Convert.ToInt32(comboboxCategory.SelectedValue));
                    MainClass.sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    MainClass.sqlcon.Close();
                    MessageBox.Show("Products Added Successfully");
                }
                catch (Exception ex)
                {
                    MainClass.sqlcon.Close();
                    MessageBox.Show(ex.Message);
                }
                this.Hide();
            }
            else
            {
                textboxBarcode.BorderColorFocused = System.Drawing.Color.Red;
                textboxBarcode.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                textboxBarcode.BorderColorMouseHover = System.Drawing.Color.Red;
                textboxProName.BorderColorFocused = System.Drawing.Color.Red;
                textboxProName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                textboxProName.BorderColorMouseHover = System.Drawing.Color.Red;
                Error1.Visible = true;
                Error2.Visible = true;
                MessageBox.Show("Please Fill The Feilds!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddProducts_Load(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
