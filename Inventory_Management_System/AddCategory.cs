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
    public partial class AddCategory : Form
    {
        public short stat;//Variable For Status
        SqlCommand cmd;
        Categories c = new Categories();
        public AddCategory()
        {
            InitializeComponent();
        }

        private void btnAddCat_Click(object sender, EventArgs e)
        {
            if(comboboxIsActive.SelectedIndex == -1 && textboxCatName.Text == "")
            {
                textboxCatName.BorderColorFocused = System.Drawing.Color.Red;
                textboxCatName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                textboxCatName.BorderColorMouseHover = System.Drawing.Color.Red;
                Error.Visible = true;
            }
            else { 
            if (comboboxIsActive.SelectedIndex == 0)
            {
                stat = 1;
            }
            else if (comboboxIsActive.SelectedIndex == 1)
            {
                stat = 0;
            }
            if (textboxCatName.Text != "" && comboboxIsActive.SelectedIndex != -1)
            {
                try
                {
                        Error.Visible = false;
                    //Insert Category in DataGridView
                    cmd = new SqlCommand("st_insertCategory", MainClass.sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", textboxCatName.Text);
                    cmd.Parameters.AddWithValue("@isActive", stat);
                    MainClass.sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    MainClass.sqlcon.Close();
                    cmd = new SqlCommand("dbo.st_getCategoriesData", MainClass.sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    c.catIdGV.DataPropertyName = dt.Columns["ID"].ToString();
                    c.catNameGV.DataPropertyName = dt.Columns["Category"].ToString();
                    c.catIsActiveGV.DataPropertyName = dt.Columns["Status"].ToString();
                    if (dt.Rows.Count > 0)
                    { c.datagridviewCategories.DataSource = dt; }
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
                MessageBox.Show("Please Fill The Feilds!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose(); //Closing The Add Category Window
        }
    }
}
