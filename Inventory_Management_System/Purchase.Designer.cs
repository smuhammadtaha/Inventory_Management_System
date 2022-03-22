namespace Inventory_Management_System
{
    partial class Purchase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase));
            this.panel1 = new System.Windows.Forms.Panel();
            this.datagridviewPurchase = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.proIdGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pupGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textboxSuppSearch = new System.Windows.Forms.TextBox();
            this.Grosslable = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSavePurchase = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelPurchase = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddPurchase = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Printbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewPurchase)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datagridviewPurchase);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 470);
            this.panel1.TabIndex = 28;
            // 
            // datagridviewPurchase
            // 
            this.datagridviewPurchase.AllowUserToAddRows = false;
            this.datagridviewPurchase.AllowUserToDeleteRows = false;
            this.datagridviewPurchase.AllowUserToResizeColumns = false;
            this.datagridviewPurchase.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridviewPurchase.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.datagridviewPurchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridviewPurchase.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datagridviewPurchase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridviewPurchase.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewPurchase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.datagridviewPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewPurchase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proIdGv,
            this.Product,
            this.quanGv,
            this.pupGv,
            this.TotGv});
            this.datagridviewPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewPurchase.DoubleBuffered = true;
            this.datagridviewPurchase.EnableHeadersVisualStyles = false;
            this.datagridviewPurchase.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.datagridviewPurchase.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.datagridviewPurchase.HeaderForeColor = System.Drawing.Color.White;
            this.datagridviewPurchase.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datagridviewPurchase.Location = new System.Drawing.Point(0, 0);
            this.datagridviewPurchase.Name = "datagridviewPurchase";
            this.datagridviewPurchase.ReadOnly = true;
            this.datagridviewPurchase.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridviewPurchase.RowHeadersVisible = false;
            this.datagridviewPurchase.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagridviewPurchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewPurchase.Size = new System.Drawing.Size(780, 470);
            this.datagridviewPurchase.TabIndex = 0;
            this.datagridviewPurchase.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewPurchase_CellContentClick);
            this.datagridviewPurchase.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewPurchase_CellDoubleClick);
            // 
            // proIdGv
            // 
            this.proIdGv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.proIdGv.DefaultCellStyle = dataGridViewCellStyle10;
            this.proIdGv.HeaderText = "ProID";
            this.proIdGv.Name = "proIdGv";
            this.proIdGv.ReadOnly = true;
            this.proIdGv.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Product
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Product.DefaultCellStyle = dataGridViewCellStyle11;
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // quanGv
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quanGv.DefaultCellStyle = dataGridViewCellStyle12;
            this.quanGv.HeaderText = "Quantity";
            this.quanGv.Name = "quanGv";
            this.quanGv.ReadOnly = true;
            this.quanGv.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pupGv
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = null;
            this.pupGv.DefaultCellStyle = dataGridViewCellStyle13;
            this.pupGv.HeaderText = "Per Unit Price";
            this.pupGv.Name = "pupGv";
            this.pupGv.ReadOnly = true;
            this.pupGv.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TotGv
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = null;
            this.TotGv.DefaultCellStyle = dataGridViewCellStyle14;
            this.TotGv.HeaderText = "Total Amount";
            this.TotGv.Name = "TotGv";
            this.TotGv.ReadOnly = true;
            this.TotGv.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.textboxSuppSearch);
            this.groupBox1.Location = new System.Drawing.Point(519, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 44);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(3, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 3);
            this.panel3.TabIndex = 4;
            // 
            // textboxSuppSearch
            // 
            this.textboxSuppSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.textboxSuppSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxSuppSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxSuppSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxSuppSearch.Location = new System.Drawing.Point(3, 16);
            this.textboxSuppSearch.Name = "textboxSuppSearch";
            this.textboxSuppSearch.Size = new System.Drawing.Size(267, 15);
            this.textboxSuppSearch.TabIndex = 3;
            this.textboxSuppSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxSuppSearch_KeyPress);
            // 
            // Grosslable
            // 
            this.Grosslable.AutoSize = true;
            this.Grosslable.BackColor = System.Drawing.Color.Transparent;
            this.Grosslable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grosslable.Location = new System.Drawing.Point(456, 14);
            this.Grosslable.Name = "Grosslable";
            this.Grosslable.Size = new System.Drawing.Size(54, 25);
            this.Grosslable.TabIndex = 31;
            this.Grosslable.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(271, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Gross Total Price:";
            // 
            // btnSavePurchase
            // 
            this.btnSavePurchase.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnSavePurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnSavePurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSavePurchase.BorderRadius = 0;
            this.btnSavePurchase.ButtonText = "    SAVE";
            this.btnSavePurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSavePurchase.DisabledColor = System.Drawing.Color.Gray;
            this.btnSavePurchase.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSavePurchase.Iconimage = global::Inventory_Management_System.Properties.Resources.down_arrow_download_button;
            this.btnSavePurchase.Iconimage_right = null;
            this.btnSavePurchase.Iconimage_right_Selected = null;
            this.btnSavePurchase.Iconimage_Selected = null;
            this.btnSavePurchase.IconMarginLeft = 0;
            this.btnSavePurchase.IconMarginRight = 0;
            this.btnSavePurchase.IconRightVisible = true;
            this.btnSavePurchase.IconRightZoom = 0D;
            this.btnSavePurchase.IconVisible = true;
            this.btnSavePurchase.IconZoom = 45D;
            this.btnSavePurchase.IsTab = false;
            this.btnSavePurchase.Location = new System.Drawing.Point(120, 12);
            this.btnSavePurchase.Name = "btnSavePurchase";
            this.btnSavePurchase.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnSavePurchase.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnSavePurchase.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSavePurchase.selected = false;
            this.btnSavePurchase.Size = new System.Drawing.Size(106, 39);
            this.btnSavePurchase.TabIndex = 30;
            this.btnSavePurchase.Text = "    SAVE";
            this.btnSavePurchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSavePurchase.Textcolor = System.Drawing.Color.White;
            this.btnSavePurchase.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePurchase.Click += new System.EventHandler(this.btnSavePurchase_Click);
            // 
            // btnDelPurchase
            // 
            this.btnDelPurchase.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnDelPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnDelPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelPurchase.BorderRadius = 0;
            this.btnDelPurchase.ButtonText = "    DELETE";
            this.btnDelPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelPurchase.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelPurchase.Enabled = false;
            this.btnDelPurchase.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelPurchase.Iconimage = global::Inventory_Management_System.Properties.Resources.rubbish_bin_delete_button;
            this.btnDelPurchase.Iconimage_right = null;
            this.btnDelPurchase.Iconimage_right_Selected = null;
            this.btnDelPurchase.Iconimage_Selected = null;
            this.btnDelPurchase.IconMarginLeft = 0;
            this.btnDelPurchase.IconMarginRight = 0;
            this.btnDelPurchase.IconRightVisible = true;
            this.btnDelPurchase.IconRightZoom = 0D;
            this.btnDelPurchase.IconVisible = true;
            this.btnDelPurchase.IconZoom = 45D;
            this.btnDelPurchase.IsTab = false;
            this.btnDelPurchase.Location = new System.Drawing.Point(232, 12);
            this.btnDelPurchase.Name = "btnDelPurchase";
            this.btnDelPurchase.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnDelPurchase.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnDelPurchase.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelPurchase.selected = false;
            this.btnDelPurchase.Size = new System.Drawing.Size(121, 39);
            this.btnDelPurchase.TabIndex = 26;
            this.btnDelPurchase.Text = "    DELETE";
            this.btnDelPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelPurchase.Textcolor = System.Drawing.Color.White;
            this.btnDelPurchase.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelPurchase.Click += new System.EventHandler(this.btnDelPurchase_Click);
            // 
            // btnAddPurchase
            // 
            this.btnAddPurchase.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnAddPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnAddPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPurchase.BorderRadius = 0;
            this.btnAddPurchase.ButtonText = "     ADD";
            this.btnAddPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPurchase.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddPurchase.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddPurchase.Iconimage = global::Inventory_Management_System.Properties.Resources.plus;
            this.btnAddPurchase.Iconimage_right = null;
            this.btnAddPurchase.Iconimage_right_Selected = null;
            this.btnAddPurchase.Iconimage_Selected = null;
            this.btnAddPurchase.IconMarginLeft = 0;
            this.btnAddPurchase.IconMarginRight = 0;
            this.btnAddPurchase.IconRightVisible = true;
            this.btnAddPurchase.IconRightZoom = 0D;
            this.btnAddPurchase.IconVisible = true;
            this.btnAddPurchase.IconZoom = 50D;
            this.btnAddPurchase.IsTab = false;
            this.btnAddPurchase.Location = new System.Drawing.Point(12, 12);
            this.btnAddPurchase.Name = "btnAddPurchase";
            this.btnAddPurchase.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnAddPurchase.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnAddPurchase.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddPurchase.selected = false;
            this.btnAddPurchase.Size = new System.Drawing.Size(102, 39);
            this.btnAddPurchase.TabIndex = 24;
            this.btnAddPurchase.Text = "     ADD";
            this.btnAddPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPurchase.Textcolor = System.Drawing.Color.White;
            this.btnAddPurchase.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPurchase.Click += new System.EventHandler(this.btnAddPurchase_Click);
            // 
            // Printbtn
            // 
            this.Printbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.Printbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.Printbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Printbtn.BorderRadius = 0;
            this.Printbtn.ButtonText = "     PRINT";
            this.Printbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Printbtn.DisabledColor = System.Drawing.Color.Gray;
            this.Printbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.Printbtn.Iconimage = global::Inventory_Management_System.Properties.Resources.print;
            this.Printbtn.Iconimage_right = null;
            this.Printbtn.Iconimage_right_Selected = null;
            this.Printbtn.Iconimage_Selected = null;
            this.Printbtn.IconMarginLeft = 0;
            this.Printbtn.IconMarginRight = 0;
            this.Printbtn.IconRightVisible = true;
            this.Printbtn.IconRightZoom = 0D;
            this.Printbtn.IconVisible = true;
            this.Printbtn.IconZoom = 50D;
            this.Printbtn.IsTab = false;
            this.Printbtn.Location = new System.Drawing.Point(359, 12);
            this.Printbtn.Name = "Printbtn";
            this.Printbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.Printbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.Printbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.Printbtn.selected = false;
            this.Printbtn.Size = new System.Drawing.Size(121, 39);
            this.Printbtn.TabIndex = 31;
            this.Printbtn.Text = "     PRINT";
            this.Printbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Printbtn.Textcolor = System.Drawing.Color.White;
            this.Printbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Printbtn.Click += new System.EventHandler(this.Printbtn_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.Grosslable);
            this.bunifuGradientPanel1.Controls.Add(this.label7);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(157)))), ((int)(((byte)(242)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(12, 531);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(783, 48);
            this.bunifuGradientPanel1.TabIndex = 40;
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 580);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.Printbtn);
            this.Controls.Add(this.btnSavePurchase);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelPurchase);
            this.Controls.Add(this.btnAddPurchase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Purchase";
            this.Text = "Purchase";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewPurchase)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public Bunifu.Framework.UI.BunifuCustomDataGrid datagridviewPurchase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textboxSuppSearch;
        public System.Windows.Forms.Label Grosslable;
        public System.Windows.Forms.Label label7;
        public Bunifu.Framework.UI.BunifuFlatButton btnSavePurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIdGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn quanGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn pupGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotGv;
        private System.Windows.Forms.Panel panel3;
        public Bunifu.Framework.UI.BunifuFlatButton btnDelPurchase;
        public Bunifu.Framework.UI.BunifuFlatButton btnAddPurchase;
        public Bunifu.Framework.UI.BunifuFlatButton Printbtn;
        public System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
    }
}