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
    public partial class UpdateSupplier : Form
    {
        public short stat;//Variable For Status

        public int supplierId;
        public UpdateSupplier()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdateSupp_Click(object sender, EventArgs e)
        {
            if (textboxSuppName.Text == "" || textboxContPerson.Text == "" || textboxAddress.Text == "" || textboxNTN.Text == "" || textboxPhone1.Text == "" || textboxPhone2.Text == "" || comboboxSuppStatus.SelectedIndex == -1)
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
                if (comboboxSuppStatus.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (comboboxSuppStatus.SelectedIndex == 0)
                {
                    stat = 0;
                }
                Supplier s = new Supplier();
                try
                {
                    SqlCommand cmd = new SqlCommand("st_updateSupplier", MainClass.sqlcon);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@company", textboxSuppName.Text);
                    cmd.Parameters.AddWithValue("@conPerson", textboxContPerson.Text);
                    cmd.Parameters.AddWithValue("@phone1", textboxPhone1.Text);
                    cmd.Parameters.AddWithValue("@phone2", textboxPhone2.Text);
                    cmd.Parameters.AddWithValue("@address", textboxAddress.Text);
                    cmd.Parameters.AddWithValue("@ntn", textboxNTN.Text);
                    cmd.Parameters.AddWithValue("@status", stat);
                    cmd.Parameters.AddWithValue("@suppID", supplierId);
                    MainClass.sqlcon.Open();
                    cmd.ExecuteNonQuery();
                    MainClass.sqlcon.Close();
                    MessageBox.Show("Data Updated Successfully");
                }
                catch (Exception ex)
                {
                    MainClass.sqlcon.Close();
                    MessageBox.Show(ex.Message);
                }
                this.Hide();
            }



            //                if (textboxSuppName.Text == "" || textboxContPerson.Text == "" || textboxAddress.Text == "" || textboxNTN.Text == "" || textboxPhone1.Text == "" || textboxPhone2.Text == "" || comboboxSuppStatus.SelectedIndex == -1)
            //                {
            //                    MessageBox.Show("Fields Are Required");
            //                }
            //                Supplier s = new Supplier();
            //                if (comboboxSuppStatus.SelectedIndex == -1)
            //                {
            //                    MessageBox.Show("Fields Are Required");
            //                }
            //                else
            //                {
            //                    if (comboboxSuppStatus.SelectedIndex == 0)
            //                    {
            //                        stat = 1;
            //                    }
            //                    else if (comboboxSuppStatus.SelectedIndex == 0)
            //                    {
            //                        stat = 0;
            //                    }
            //                }
            //            try
            //            {
            //                SqlCommand cmd = new SqlCommand("st_updateSupplier", MainClass.sqlcon);
            //                cmd.CommandType = CommandType.StoredProcedure;
            //                cmd.Parameters.AddWithValue("@company", textboxSuppName.Text);
            //                cmd.Parameters.AddWithValue("@conPerson", textboxContPerson.Text);
            //                cmd.Parameters.AddWithValue("@phone1", textboxPhone1.Text);
            //                if (textboxPhone2.Text == null)
            //                {
            //                    cmd.Parameters.AddWithValue("@phone2", DBNull.Value);
            //                }
            //                else
            //                {
            //                    cmd.Parameters.AddWithValue("@phone2", textboxPhone2.Text);
            //                }
            //                if (textboxNTN.Text == null)
            //                {
            //                    cmd.Parameters.AddWithValue("@ntn", DBNull.Value);
            //                }
            //                else
            //                {
            //                    cmd.Parameters.AddWithValue("@ntn", textboxNTN.Text);
            //                }
            //                cmd.Parameters.AddWithValue("@status", Convert.ToInt16(comboboxSuppStatus.SelectedValue));
            //                cmd.Parameters.AddWithValue("@address", textboxAddress.Text);
            //                cmd.Parameters.AddWithValue("@suppID", s.supplierId);


            //                MainClass.sqlcon.Open();
            //                cmd.ExecuteNonQuery();
            //                MainClass.sqlcon.Close();
            //                MessageBox.Show("Data Updated Successfully");
            //                this.Hide();

            //            }
            //            catch (Exception ex)
            //            {
            //                MainClass.sqlcon.Close();
            //                MessageBox.Show(ex.Message);
            //            }
            //        }

            //    }
            //}
            //            try
            //            {
            //                SqlCommand cmd = new SqlCommand("st_updateSupplier", MainClass.sqlcon);
            //cmd.CommandType = CommandType.StoredProcedure;
            //                cmd.Parameters.AddWithValue("@company", textboxSuppName.Text);
            //                cmd.Parameters.AddWithValue("@conPerson", textboxContPerson.Text);
            //                cmd.Parameters.AddWithValue("@phone1", textboxPhone1.Text);
            //                if (textboxPhone2 == null)
            //                {
            //                    cmd.Parameters.AddWithValue("@phone2", DBNull.Value);
            //                }
            //                else
            //                {
            //                    cmd.Parameters.AddWithValue("@phone2", textboxPhone2.Text);
            //                }
            //                if (textboxNTN.Text == null)
            //                {
            //                    cmd.Parameters.AddWithValue("@ntn", DBNull.Value);
            //                }
            //                else
            //                {
            //                    cmd.Parameters.AddWithValue("@ntn", textboxNTN.Text);
            //                }
            //                cmd.Parameters.AddWithValue("@address", textboxAddress.Text);
            //                cmd.Parameters.AddWithValue("@status", comboboxSuppStatus.SelectedItem);

            //                MainClass.sqlcon.Open();
            //                cmd.ExecuteNonQuery();
            //                MainClass.sqlcon.Close();
            //                MessageBox.Show("Data Updated Successfully");

            //            }
            //            catch (Exception ex)
            //                {
            //                    MainClass.sqlcon.Close();
            //                    MessageBox.Show(ex.Message);

        }

        private void textboxPhone2_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}

