using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class Categories : Form
    {
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable dt;
        public int rowIndex=-1;
        public int catId;
        public int cateId;

        UpdateCategory uc = new UpdateCategory();
        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDataSet.categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.inventoryDataSet.categories);
            loadCategoryData();
        }
        public void loadCategoryData()
        {
            cmd = new SqlCommand("dbo.st_getCategoriesData", MainClass.sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            sda = new SqlDataAdapter(cmd);
            dt = new DataTable();
            sda.Fill(dt);
            catIdGV.DataPropertyName = dt.Columns["ID"].ToString();
            catNameGV.DataPropertyName = dt.Columns["Category"].ToString();
            catIsActiveGV.DataPropertyName = dt.Columns["Status"].ToString();
                      if (dt.Rows.Count > 0)
            { datagridviewCategories.DataSource = dt; }

            

        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            AddCategory ac = new AddCategory();
            ac.Show();
        }

        private void btnViewCat_Click(object sender, EventArgs e)
        {
            loadCategoryData();
            
        }

        public void datagridviewCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void btnEditCat_Click(object sender, EventArgs e)
        {
            if (rowIndex != -1)
            {
                UpdateCategory uc = new UpdateCategory();
                uc.Show();
                DataGridViewRow row = datagridviewCategories.Rows[rowIndex];
                uc.categoryId = Convert.ToInt32(row.Cells["catIdGV"].Value.ToString());
                uc.textboxCatName.Text = row.Cells["catNameGV"].Value.ToString();
                uc.comboboxIsActive.SelectedItem = row.Cells["catIsActiveGV"].Value.ToString();
                rowIndex = -1;
            }
        }
        private void btnDelCat_Click(object sender, EventArgs e)
        {
            
            try
            {
                int cateId;
                DataGridViewRow row = datagridviewCategories.Rows[rowIndex];
                cateId = Convert.ToInt32(row.Cells["catIdGV"].Value.ToString());
                cmd = new SqlCommand("st_deleteCategory", MainClass.sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", cateId);
                MainClass.sqlcon.Open();
                cmd.ExecuteNonQuery();
                MainClass.sqlcon.Close();
                loadCategoryData();
                rowIndex = -1;
            }
            catch (Exception ex)
            {
                MainClass.sqlcon.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void textboxCatSearch_TextChanged(object sender, EventArgs e)
        {
           //if(textboxCatSearch.Text!="")
           // {
           //     try
           //     {
           //         SqlCommand cmd;
           //         if (textboxCatSearch.Text == null)
           //         {
           //             cmd = new SqlCommand("dbo.st_getCategoriesData", MainClass.sqlcon);
           //         }
           //         else
           //         {
           //             cmd = new SqlCommand("st_getCatDataLIKE", MainClass.sqlcon);
           //             cmd.Parameters.AddWithValue("@data", textboxCatSearch.Text);
           //         }
           //         cmd.CommandType = CommandType.StoredProcedure;
           //         SqlDataAdapter sda = new SqlDataAdapter(cmd);
           //         DataTable dt = new DataTable();
           //         sda.Fill(dt);
           //         catIdGV.DataPropertyName = dt.Columns["ID"].ToString();
           //         catNameGV.DataPropertyName = dt.Columns["Category"].ToString();
           //         catIsActiveGV.DataPropertyName = dt.Columns["Status"].ToString();
           //         datagridviewCategories.DataSource = dt;
           //     }
           //     catch (Exception ex)
           //     {
           //         MessageBox.Show(ex.Message);
           //     }
           // }
           //else
           // {
           //     loadCategoryData();
           // }
        }

   public void loadsearching()
        {

        }

        private void searchtextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           // SqlConnection con = new SqlConnection();
            //cmd = new SqlCommand("st_getCategoriesData", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("Category",searchtextBox1.Text);
            //con.Open();
            //datagridviewCategories.DataSource = cmd.ExecuteReader();
            ////datagridviewCategories.DataBindings();
            //con.Close();
            // cmd.CommandType = CommandType.StoredProcedure;
            //DataView dv = new DataView();
           // DataTable dt;
            // dv.RowFilter = string.Format("cat_name like '%(0)%'",searchtextBox1.Text);
            //dt.DefaultView.RowFilter = "Full_Name LIKE '%{txt_usersearch.Text}%'";
            // dt.DefaultView.RowFilter = "Full_Name LIKE '%{searchtextBox1.Text}%'";
            //datagridviewCategories.DataSource = dt.ToTable();
            // datagridviewCategories.DataSource = dt;
            //using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["Data Source=.;Initial Catalog=Inventory;User ID=sa;Password=123"].ConnectionString))
            //{
            //    using (var cmd = new SqlCommand("cat_name", con))
            //    {
            //        con.Open();
            //        cmd.CommandType = CommandType.StoredProcedure;

            //        using (var sda = new SqlDataAdapter(cmd))
            //        {
            //            dt = new DataTable();
            //            sda.Fill(dt);
            //            datagridviewCategories.DataSource = dt;
            //        }


            //        con.Close();
            //    }
            //}

            
            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format("Category like '%{0}%'", searchtextBox1.Text);
            datagridviewCategories.DataSource = dv.ToTable();
        }

        private void datagridviewCategories_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void datagridviewCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            btnDelCat.Enabled = true;
        }
    }
}
