namespace Inventory_Management_System
{
    partial class Price
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSavePurchase = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datagridviewPricing = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.selectGV = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.proIdGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyPriceGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profMarginGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalSellGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textboxSuppSearch = new System.Windows.Forms.TextBox();
            this.btnDelPurchase = new Bunifu.Framework.UI.BunifuFlatButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CatDD = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewPricing)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSavePurchase
            // 
            this.btnSavePurchase.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnSavePurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnSavePurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSavePurchase.BorderRadius = 0;
            this.btnSavePurchase.ButtonText = "   SAVE";
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
            this.btnSavePurchase.Location = new System.Drawing.Point(12, 12);
            this.btnSavePurchase.Name = "btnSavePurchase";
            this.btnSavePurchase.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnSavePurchase.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnSavePurchase.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSavePurchase.selected = false;
            this.btnSavePurchase.Size = new System.Drawing.Size(100, 39);
            this.btnSavePurchase.TabIndex = 37;
            this.btnSavePurchase.Text = "   SAVE";
            this.btnSavePurchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSavePurchase.Textcolor = System.Drawing.Color.White;
            this.btnSavePurchase.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePurchase.Click += new System.EventHandler(this.btnSavePurchase_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datagridviewPricing);
            this.panel1.Location = new System.Drawing.Point(12, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 516);
            this.panel1.TabIndex = 35;
            // 
            // datagridviewPricing
            // 
            this.datagridviewPricing.AllowUserToAddRows = false;
            this.datagridviewPricing.AllowUserToDeleteRows = false;
            this.datagridviewPricing.AllowUserToResizeColumns = false;
            this.datagridviewPricing.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridviewPricing.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridviewPricing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridviewPricing.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datagridviewPricing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridviewPricing.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewPricing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridviewPricing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewPricing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectGV,
            this.proIdGv,
            this.Product,
            this.buyPriceGV,
            this.profMarginGV,
            this.discountGV,
            this.finalSellGV});
            this.datagridviewPricing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewPricing.DoubleBuffered = true;
            this.datagridviewPricing.EnableHeadersVisualStyles = false;
            this.datagridviewPricing.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.datagridviewPricing.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.datagridviewPricing.HeaderForeColor = System.Drawing.Color.White;
            this.datagridviewPricing.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datagridviewPricing.Location = new System.Drawing.Point(0, 0);
            this.datagridviewPricing.Name = "datagridviewPricing";
            this.datagridviewPricing.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridviewPricing.RowHeadersVisible = false;
            this.datagridviewPricing.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagridviewPricing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewPricing.Size = new System.Drawing.Size(780, 516);
            this.datagridviewPricing.TabIndex = 0;
            this.datagridviewPricing.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewPricing_CellDoubleClick);
            this.datagridviewPricing.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewPricing_CellEndEdit);
            this.datagridviewPricing.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.datagridviewPricing_DataError);
            // 
            // selectGV
            // 
            this.selectGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.selectGV.FalseValue = "0";
            this.selectGV.HeaderText = "";
            this.selectGV.Name = "selectGV";
            this.selectGV.TrueValue = "1";
            this.selectGV.Width = 5;
            // 
            // proIdGv
            // 
            this.proIdGv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.proIdGv.DefaultCellStyle = dataGridViewCellStyle3;
            this.proIdGv.HeaderText = "ProID";
            this.proIdGv.Name = "proIdGv";
            this.proIdGv.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.proIdGv.Visible = false;
            // 
            // Product
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Product.DefaultCellStyle = dataGridViewCellStyle4;
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // buyPriceGV
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.buyPriceGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.buyPriceGV.HeaderText = "Buying Price";
            this.buyPriceGV.Name = "buyPriceGV";
            this.buyPriceGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // profMarginGV
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.profMarginGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.profMarginGV.HeaderText = "Profit Margin (%)";
            this.profMarginGV.Name = "profMarginGV";
            this.profMarginGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // discountGV
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.discountGV.DefaultCellStyle = dataGridViewCellStyle7;
            this.discountGV.HeaderText = "Discount(%)";
            this.discountGV.Name = "discountGV";
            this.discountGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // finalSellGV
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.finalSellGV.DefaultCellStyle = dataGridViewCellStyle8;
            this.finalSellGV.HeaderText = "Final Selling Price";
            this.finalSellGV.Name = "finalSellGV";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.textboxSuppSearch);
            this.groupBox1.Location = new System.Drawing.Point(529, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 44);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.panel2.Location = new System.Drawing.Point(6, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 3);
            this.panel2.TabIndex = 4;
            // 
            // textboxSuppSearch
            // 
            this.textboxSuppSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.textboxSuppSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxSuppSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxSuppSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxSuppSearch.Location = new System.Drawing.Point(3, 16);
            this.textboxSuppSearch.Name = "textboxSuppSearch";
            this.textboxSuppSearch.Size = new System.Drawing.Size(257, 15);
            this.textboxSuppSearch.TabIndex = 3;
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
            this.btnDelPurchase.Location = new System.Drawing.Point(118, 12);
            this.btnDelPurchase.Name = "btnDelPurchase";
            this.btnDelPurchase.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnDelPurchase.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnDelPurchase.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelPurchase.selected = false;
            this.btnDelPurchase.Size = new System.Drawing.Size(141, 39);
            this.btnDelPurchase.TabIndex = 33;
            this.btnDelPurchase.Text = "    DELETE";
            this.btnDelPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelPurchase.Textcolor = System.Drawing.Color.White;
            this.btnDelPurchase.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CatDD);
            this.groupBox2.Location = new System.Drawing.Point(265, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 44);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Category";
            // 
            // CatDD
            // 
            this.CatDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CatDD.FormattingEnabled = true;
            this.CatDD.Location = new System.Drawing.Point(6, 16);
            this.CatDD.Name = "CatDD";
            this.CatDD.Size = new System.Drawing.Size(220, 21);
            this.CatDD.TabIndex = 4;
            this.CatDD.SelectedIndexChanged += new System.EventHandler(this.CatDD_SelectedIndexChanged);
            // 
            // Price
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 580);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSavePurchase);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelPurchase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Price";
            this.Text = "Price";
            this.Load += new System.EventHandler(this.Price_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewPricing)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuFlatButton btnSavePurchase;
        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuCustomDataGrid datagridviewPricing;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textboxSuppSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CatDD;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIdGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyPriceGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn profMarginGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalSellGV;
        private System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuFlatButton btnDelPurchase;
    }
}