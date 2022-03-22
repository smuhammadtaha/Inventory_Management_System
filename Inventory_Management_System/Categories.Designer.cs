namespace Inventory_Management_System
{
    partial class Categories
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datagridviewCategories = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.catIdGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catIsActiveGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchtextBox1 = new System.Windows.Forms.TextBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryDataSet = new Inventory_Management_System.InventoryDataSet();
            this.btnViewCat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelCat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditCat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddCategory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.categoriesTableAdapter = new Inventory_Management_System.InventoryDataSetTableAdapters.categoriesTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewCategories)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datagridviewCategories);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 520);
            this.panel1.TabIndex = 10;
            // 
            // datagridviewCategories
            // 
            this.datagridviewCategories.AllowUserToAddRows = false;
            this.datagridviewCategories.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridviewCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridviewCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridviewCategories.BackgroundColor = System.Drawing.Color.White;
            this.datagridviewCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridviewCategories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridviewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catIdGV,
            this.catNameGV,
            this.catIsActiveGV});
            this.datagridviewCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewCategories.DoubleBuffered = true;
            this.datagridviewCategories.EnableHeadersVisualStyles = false;
            this.datagridviewCategories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.datagridviewCategories.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.datagridviewCategories.HeaderForeColor = System.Drawing.Color.White;
            this.datagridviewCategories.Location = new System.Drawing.Point(0, 0);
            this.datagridviewCategories.Name = "datagridviewCategories";
            this.datagridviewCategories.ReadOnly = true;
            this.datagridviewCategories.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridviewCategories.RowHeadersVisible = false;
            this.datagridviewCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewCategories.Size = new System.Drawing.Size(780, 520);
            this.datagridviewCategories.TabIndex = 0;
            this.datagridviewCategories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewCategories_CellClick);
            this.datagridviewCategories.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewCategories_CellDoubleClick);
            this.datagridviewCategories.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridviewCategories_RowHeaderMouseDoubleClick);
            // 
            // catIdGV
            // 
            this.catIdGV.HeaderText = "CatID";
            this.catIdGV.Name = "catIdGV";
            this.catIdGV.ReadOnly = true;
            this.catIdGV.Visible = false;
            // 
            // catNameGV
            // 
            this.catNameGV.HeaderText = "Category Name";
            this.catNameGV.Name = "catNameGV";
            this.catNameGV.ReadOnly = true;
            // 
            // catIsActiveGV
            // 
            this.catIsActiveGV.HeaderText = "Status";
            this.catIsActiveGV.Name = "catIsActiveGV";
            this.catIsActiveGV.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.searchtextBox1);
            this.groupBox1.Location = new System.Drawing.Point(433, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 44);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.panel2.Location = new System.Drawing.Point(7, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 3);
            this.panel2.TabIndex = 1;
            // 
            // searchtextBox1
            // 
            this.searchtextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.searchtextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchtextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtextBox1.Location = new System.Drawing.Point(6, 18);
            this.searchtextBox1.Name = "searchtextBox1";
            this.searchtextBox1.Size = new System.Drawing.Size(322, 15);
            this.searchtextBox1.TabIndex = 0;
            this.searchtextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchtextBox1_KeyPress);
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "categories";
            this.categoriesBindingSource.DataSource = this.inventoryDataSet;
            // 
            // inventoryDataSet
            // 
            this.inventoryDataSet.DataSetName = "InventoryDataSet";
            this.inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnViewCat
            // 
            this.btnViewCat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnViewCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnViewCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewCat.BorderRadius = 0;
            this.btnViewCat.ButtonText = "";
            this.btnViewCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewCat.DisabledColor = System.Drawing.Color.Gray;
            this.btnViewCat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnViewCat.Iconimage = global::Inventory_Management_System.Properties.Resources.icons8_recurring_appointment_50px;
            this.btnViewCat.Iconimage_right = null;
            this.btnViewCat.Iconimage_right_Selected = null;
            this.btnViewCat.Iconimage_Selected = null;
            this.btnViewCat.IconMarginLeft = 0;
            this.btnViewCat.IconMarginRight = 0;
            this.btnViewCat.IconRightVisible = true;
            this.btnViewCat.IconRightZoom = 0D;
            this.btnViewCat.IconVisible = true;
            this.btnViewCat.IconZoom = 50D;
            this.btnViewCat.IsTab = false;
            this.btnViewCat.Location = new System.Drawing.Point(357, 12);
            this.btnViewCat.Name = "btnViewCat";
            this.btnViewCat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnViewCat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnViewCat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnViewCat.selected = false;
            this.btnViewCat.Size = new System.Drawing.Size(41, 39);
            this.btnViewCat.TabIndex = 11;
            this.btnViewCat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewCat.Textcolor = System.Drawing.Color.White;
            this.btnViewCat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCat.Click += new System.EventHandler(this.btnViewCat_Click);
            // 
            // btnDelCat
            // 
            this.btnDelCat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnDelCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnDelCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelCat.BorderRadius = 0;
            this.btnDelCat.ButtonText = "   DELETE";
            this.btnDelCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelCat.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelCat.Enabled = false;
            this.btnDelCat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelCat.Iconimage = global::Inventory_Management_System.Properties.Resources.rubbish_bin_delete_button;
            this.btnDelCat.Iconimage_right = null;
            this.btnDelCat.Iconimage_right_Selected = null;
            this.btnDelCat.Iconimage_Selected = null;
            this.btnDelCat.IconMarginLeft = 0;
            this.btnDelCat.IconMarginRight = 0;
            this.btnDelCat.IconRightVisible = true;
            this.btnDelCat.IconRightZoom = 0D;
            this.btnDelCat.IconVisible = true;
            this.btnDelCat.IconZoom = 45D;
            this.btnDelCat.IsTab = false;
            this.btnDelCat.Location = new System.Drawing.Point(231, 12);
            this.btnDelCat.Name = "btnDelCat";
            this.btnDelCat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnDelCat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnDelCat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelCat.selected = false;
            this.btnDelCat.Size = new System.Drawing.Size(120, 39);
            this.btnDelCat.TabIndex = 8;
            this.btnDelCat.Text = "   DELETE";
            this.btnDelCat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelCat.Textcolor = System.Drawing.Color.White;
            this.btnDelCat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelCat.Click += new System.EventHandler(this.btnDelCat_Click);
            // 
            // btnEditCat
            // 
            this.btnEditCat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnEditCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnEditCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditCat.BorderRadius = 0;
            this.btnEditCat.ButtonText = "    EDIT";
            this.btnEditCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCat.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditCat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditCat.Iconimage = global::Inventory_Management_System.Properties.Resources.edit_file_32px;
            this.btnEditCat.Iconimage_right = null;
            this.btnEditCat.Iconimage_right_Selected = null;
            this.btnEditCat.Iconimage_Selected = null;
            this.btnEditCat.IconMarginLeft = 0;
            this.btnEditCat.IconMarginRight = 0;
            this.btnEditCat.IconRightVisible = true;
            this.btnEditCat.IconRightZoom = 0D;
            this.btnEditCat.IconVisible = true;
            this.btnEditCat.IconZoom = 50D;
            this.btnEditCat.IsTab = false;
            this.btnEditCat.Location = new System.Drawing.Point(119, 12);
            this.btnEditCat.Name = "btnEditCat";
            this.btnEditCat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnEditCat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnEditCat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditCat.selected = false;
            this.btnEditCat.Size = new System.Drawing.Size(104, 39);
            this.btnEditCat.TabIndex = 7;
            this.btnEditCat.Text = "    EDIT";
            this.btnEditCat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditCat.Textcolor = System.Drawing.Color.White;
            this.btnEditCat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCat.Click += new System.EventHandler(this.btnEditCat_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnAddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnAddCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCategory.BorderRadius = 0;
            this.btnAddCategory.ButtonText = "   ADD";
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategory.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddCategory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddCategory.Iconimage = global::Inventory_Management_System.Properties.Resources.plus;
            this.btnAddCategory.Iconimage_right = null;
            this.btnAddCategory.Iconimage_right_Selected = null;
            this.btnAddCategory.Iconimage_Selected = null;
            this.btnAddCategory.IconMarginLeft = 0;
            this.btnAddCategory.IconMarginRight = 0;
            this.btnAddCategory.IconRightVisible = true;
            this.btnAddCategory.IconRightZoom = 0D;
            this.btnAddCategory.IconVisible = true;
            this.btnAddCategory.IconZoom = 50D;
            this.btnAddCategory.IsTab = false;
            this.btnAddCategory.Location = new System.Drawing.Point(12, 12);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnAddCategory.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnAddCategory.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddCategory.selected = false;
            this.btnAddCategory.Size = new System.Drawing.Size(95, 39);
            this.btnAddCategory.TabIndex = 6;
            this.btnAddCategory.Text = "   ADD";
            this.btnAddCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategory.Textcolor = System.Drawing.Color.White;
            this.btnAddCategory.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 580);
            this.Controls.Add(this.btnViewCat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelCat);
            this.Controls.Add(this.btnEditCat);
            this.Controls.Add(this.btnAddCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Categories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewCategories)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuCustomDataGrid datagridviewCategories;
        private System.Windows.Forms.GroupBox groupBox1;
        public Bunifu.Framework.UI.BunifuFlatButton btnDelCat;
        public Bunifu.Framework.UI.BunifuFlatButton btnEditCat;
        public Bunifu.Framework.UI.BunifuFlatButton btnAddCategory;
        public System.Windows.Forms.DataGridViewTextBoxColumn catIdGV;
        public System.Windows.Forms.DataGridViewTextBoxColumn catNameGV;
        public System.Windows.Forms.DataGridViewTextBoxColumn catIsActiveGV;
        private Bunifu.Framework.UI.BunifuFlatButton btnViewCat;
        private InventoryDataSet inventoryDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private InventoryDataSetTableAdapters.categoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.TextBox searchtextBox1;
        private System.Windows.Forms.Panel panel2;
    }
}