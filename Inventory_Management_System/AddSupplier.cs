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
    public partial class AddSupplier : Form
    {
        short stat;
        public AddSupplier()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAddSupp_Click(object sender, EventArgs e)
        {
            //if (textboxSuppName.Text == "") { MessageBox.Show("Enter Supplier Name / Company"); }
            //if (textboxContPerson.Text == "") { MessageBox.Show("Enter Contact Person"); }
            //if (textboxAddress.Text == "") { MessageBox.Show("Enter Address"); }
            //if (textboxNTN.Text == "") { MessageBox.Show("Enter NTN No."); }
            //if (textboxPhone1.Text == "") { MessageBox.Show("Enter Phone 1"); }
            //if (textboxPhone2.Text == "") { MessageBox.Show("Enter Phone 2"); }
            //if (comboboxSuppStatus.SelectedIndex==-1) { MessageBox.Show("Select An Option"); }
            if(textboxSuppName.Text == ""|| textboxContPerson.Text == ""|| textboxAddress.Text == ""|| textboxNTN.Text == ""|| textboxPhone1.Text == ""|| textboxPhone2.Text == ""|| comboboxSuppStatus.SelectedIndex == -1)
            {
                textboxSuppName.BorderColorFocused = System.Drawing.Color.Red;
                textboxSuppName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                textboxSuppName.BorderColorMouseHover = System.Drawing.Color.Red;
                textboxContPerson.BorderColorFocused = System.Drawing.Color.Red;
                textboxContPerson.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                textboxContPerson.BorderColorMouseHover = System.Drawing.Color.Red;
                textboxAddress.BorderColorFocused = System.Drawing.Color.Red;
                textboxAddress.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                textboxAddress.BorderColorMouseHover = System.Drawing.Color.Red;
                textboxNTN.BorderColorFocused = System.Drawing.Color.Red;
                textboxNTN.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                textboxNTN.BorderColorMouseHover = System.Drawing.Color.Red;
                textboxPhone1.BorderColorFocused = System.Drawing.Color.Red;
                textboxPhone1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                textboxPhone1.BorderColorMouseHover = System.Drawing.Color.Red;
                textboxPhone2.BorderColorFocused = System.Drawing.Color.Red;
                textboxPhone2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                textboxPhone2.BorderColorMouseHover = System.Drawing.Color.Red;
                Error1.Visible = true;
                Error2.Visible = true;
                Error3.Visible = true;
                Error4.Visible = true;
                Error5.Visible = true;
                Error6.Visible = true;
                MessageBox.Show("Fields Are Required");
            }
            else
            {
                Error1.Visible = false;
                Error2.Visible = false;
                Error3.Visible = false;
                Error4.Visible = false;
                Error5.Visible = false;
                Error6.Visible = false;
                if (comboboxSuppStatus.SelectedIndex==0)
                {
                    stat = 1;
                }
                else if(comboboxSuppStatus.SelectedIndex==0)
                {
                    stat = 0;
                }
                try
                {
                    SqlCommand cmd = new SqlCommand("st_insertSupplier",MainClass.sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Company", textboxSuppName.Text);
                    cmd.Parameters.AddWithValue("@conPerson",textboxContPerson.Text);
                    cmd.Parameters.AddWithValue("@phone1",textboxPhone1.Text);
                    if(textboxPhone2==null)
                    {
                        cmd.Parameters.AddWithValue("@phone2", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@phone2", textboxPhone2.Text);
                    }
                    if(textboxNTN.Text==null)
                    {
                        cmd.Parameters.AddWithValue("@ntn", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ntn", textboxNTN.Text);
                    }
                    cmd.Parameters.AddWithValue("@address", textboxAddress.Text);
                    cmd.Parameters.AddWithValue("@status", stat);
                    MainClass.sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    MainClass.sqlcon.Close();
                    MessageBox.Show("Data Inserted Successfully");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
