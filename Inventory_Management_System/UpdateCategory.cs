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
    public partial class UpdateCategory : Form
    {
        public short stat;//Variable For Status
        public int categoryId;
        public UpdateCategory()
        {
            InitializeComponent();
        }

        private void btnUpdateCat_Click(object sender, EventArgs e)
        {
            if (textboxCatName.Text == "")
            {
                textboxCatName.BorderColorFocused = System.Drawing.Color.Red;
                textboxCatName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                textboxCatName.BorderColorMouseHover = System.Drawing.Color.Red;
                Error1.Visible = true;
            }
            else
            {
                Error1.Visible = false;

                if (comboboxIsActive.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (comboboxIsActive.SelectedIndex == 1)
                {
                    stat = 0;
                }
                Categories c = new Categories();

                try
                {
                    SqlCommand cmd = new SqlCommand("st_updateCategory", MainClass.sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", textboxCatName.Text);
                    cmd.Parameters.AddWithValue("@isActive", stat);
                    cmd.Parameters.AddWithValue("@id", categoryId);
                    MainClass.sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    MainClass.sqlcon.Close();
                    MessageBox.Show("Category Updated Successfully");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MainClass.sqlcon.Close();
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
