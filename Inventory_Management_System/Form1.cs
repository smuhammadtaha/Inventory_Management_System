using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Inventory_Management_System.Model;

namespace Inventory_Management_System
{
    public partial class Form1 : Form
    {
        SqlConnection sqlcon;
        SqlCommand cmd;
        InventoryEntities1 db;
        public Form1()
        {
            InitializeComponent();
            db = new InventoryEntities1();
            bunifuThinButton21.BackColor = Color.White;
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            hidecheck();
            sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            string qu = "select * from login";
            SqlDataAdapter sda = new SqlDataAdapter(qu, sqlcon);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBoxRole.Items.Add(dt.Rows[i]["role"]);
            }
            
           
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void imgShow_Click(object sender, EventArgs e)
        {
            imgHide.Hide();
            imgShow.Show();
            textboxPassword.isPassword = true;

        }

        private void hidecheck()
        {
            
        }

        private void ingHide_Click(object sender, EventArgs e)
        {
            imgHide.Show();
            imgShow.Hide();
            textboxPassword.isPassword = false;
        }
        public static int getUserID;

        private void textboxUsername_OnValueChanged(object sender, EventArgs e)
        {
        
        }

        private void textboxPassword_OnValueChanged(object sender, EventArgs e)
        {
            
            
        }


        private void textboxUsername_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxRole.SelectedIndex == -1) { MessageBox.Show("Please Select Your Role First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            string qu = "select * from login";
            cmd = new SqlCommand(qu, sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            getUserID = Convert.ToInt32(dt.Rows[comboBoxRole.SelectedIndex]["id"].ToString());
            if (dt.Rows.Count > 0)
            {
                if (comboBoxRole.SelectedIndex == 0)
                {
                    if (textboxUsername.Text == dt.Rows[0]["username"].ToString())
                    {
                        //MessageBox.Show(dt.Rows[0]["username"].ToString());

                        errortextUsername.Visible = false;

                        textboxUsername.ForeColor = ColorTranslator.FromHtml("#454545");
                        textboxUsername.LineFocusedColor = ColorTranslator.FromHtml("#454545");
                        textboxUsername.LineIdleColor = ColorTranslator.FromHtml("#454545");
                    }
                    else if (textboxUsername.Text != dt.Rows[0]["username"].ToString())
                    {
                        errortextUsername.Visible = true;

                        textboxUsername.ForeColor = Color.Red;
                        textboxUsername.LineFocusedColor = Color.Red;
                        textboxUsername.LineIdleColor = Color.Red;
                    }
                }
                else if (comboBoxRole.SelectedIndex == 1)
                {
                    if (textboxUsername.Text == dt.Rows[1]["username"].ToString())
                    {

                        errortextUsername.Visible = false;

                        textboxUsername.ForeColor = ColorTranslator.FromHtml("#454545");
                        textboxUsername.LineFocusedColor = ColorTranslator.FromHtml("#454545");
                        textboxUsername.LineIdleColor = ColorTranslator.FromHtml("#454545");
                    }
                    else
                    {
                        errortextUsername.Visible = true;

                        textboxUsername.ForeColor = Color.Red;
                        textboxUsername.LineFocusedColor = Color.Red;
                        textboxUsername.LineIdleColor = Color.Red;
                    }
                }
                else if (comboBoxRole.SelectedIndex == 2)
                {
                    if (textboxUsername.Text == dt.Rows[2]["username"].ToString())
                    {
                        //MessageBox.Show(dt.Rows[2]["username"].ToString());

                        errortextUsername.Visible = false;

                        textboxUsername.ForeColor = ColorTranslator.FromHtml("#454545");
                        textboxUsername.LineFocusedColor = ColorTranslator.FromHtml("#454545");
                        textboxUsername.LineIdleColor = ColorTranslator.FromHtml("#454545");
                    }
                    else
                    {
                        errortextUsername.Visible = true;

                        textboxUsername.ForeColor = Color.Red;
                        textboxUsername.LineFocusedColor = Color.Red;
                        textboxUsername.LineIdleColor = Color.Red;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select Your Role");
            }
        }

        private void textboxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxRole.SelectedIndex == -1) { MessageBox.Show("Please Select Your Role First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            string qu = "select * from login";
            cmd = new SqlCommand(qu, sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                if (comboBoxRole.SelectedIndex == 0)
                {
                    if (textboxPassword.Text == dt.Rows[0]["password"].ToString())
                    {

                        errortextPassword.Visible = false;

                        textboxPassword.ForeColor = ColorTranslator.FromHtml("#454545");
                        textboxPassword.LineFocusedColor = ColorTranslator.FromHtml("#454545");
                        textboxPassword.LineIdleColor = ColorTranslator.FromHtml("#454545");
                    }
                    else if (textboxPassword.Text != dt.Rows[0]["password"].ToString())
                    {
                        errortextPassword.Visible = true;

                        textboxPassword.ForeColor = Color.Red;
                        textboxPassword.LineFocusedColor = Color.Red;
                        textboxPassword.LineIdleColor = Color.Red;
                    }
                }
                else if (comboBoxRole.SelectedIndex == 1)
                {
                    if (textboxPassword.Text == dt.Rows[1]["password"].ToString())
                    {
                        errortextPassword.Visible = false;

                        textboxPassword.ForeColor = ColorTranslator.FromHtml("#454545");
                        textboxPassword.LineFocusedColor = ColorTranslator.FromHtml("#454545");
                        textboxPassword.LineIdleColor = ColorTranslator.FromHtml("#454545");
                    }
                    else
                    {
                        errortextPassword.Visible = true;

                        textboxPassword.ForeColor = Color.Red;
                        textboxPassword.LineFocusedColor = Color.Red;
                        textboxPassword.LineIdleColor = Color.Red;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Select Your Role");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textboxPassword_Click(object sender, EventArgs e)
        {
        }

        private void textboxPassword_Enter(object sender, EventArgs e)
        {
            textboxPassword.Text = "";
        }

        private void bunifuThinButton21_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Dashboard dsh = new Dashboard(textboxUsername.Text);
            if (comboBoxRole.SelectedIndex == -1) { MessageBox.Show("Please Select Your Role First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            string qu = "select * from login where username='" + textboxUsername.Text + "' and password='" + textboxPassword.Text + "'";
            cmd = new SqlCommand(qu, sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string getCmbItemValue = comboBoxRole.SelectedItem.ToString();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    errortextUsername.Visible = false;
                    errortextPassword.Visible = false;

                    textboxUsername.ForeColor = ColorTranslator.FromHtml("#454545");
                    textboxUsername.LineFocusedColor = ColorTranslator.FromHtml("#454545");
                    textboxUsername.LineIdleColor = ColorTranslator.FromHtml("#454545");

                    textboxPassword.ForeColor = ColorTranslator.FromHtml("#454545");
                    textboxPassword.LineFocusedColor = ColorTranslator.FromHtml("#454545");
                    textboxPassword.LineIdleColor = ColorTranslator.FromHtml("#454545");
                    if (dt.Rows[i]["role"].ToString() == getCmbItemValue)
                    {
                        if (comboBoxRole.SelectedIndex == 0)
                        {
                            
                            Dashboard db = new Dashboard(textboxUsername.Text);
                            db.Show();
                            this.Hide();
                        }
                        else if (comboBoxRole.SelectedIndex == 1)
                        {
                            Dashboard db = new Dashboard(textboxUsername.Text);
                            db.Show();
                            this.Hide();
                        }
                        else if (comboBoxRole.SelectedIndex == 2)
                        {
                            Dashboard db = new Dashboard(textboxUsername.Text);
                            db.Show();
                            this.Hide();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Error");
                errortextUsername.Visible = true;
                errortextPassword.Visible = true;

                textboxUsername.ForeColor = Color.Red;
                textboxUsername.LineFocusedColor = Color.Red;
                textboxUsername.LineIdleColor = Color.Red;

                textboxPassword.ForeColor = Color.Red;
                textboxPassword.LineFocusedColor = Color.Red;
                textboxPassword.LineIdleColor = Color.Red;
            }
            
        }

    }
}
