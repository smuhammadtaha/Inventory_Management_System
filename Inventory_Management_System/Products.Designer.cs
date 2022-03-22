namespace Inventory_Management_System
{
    partial class Products
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.datagridviewProducts = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.proIdGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodeGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catIdGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textboxProSearch = new System.Windows.Forms.TextBox();
            this.btnViewProducts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelProducts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditProducts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddProducts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datagridviewProducts);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 522);
            this.panel1.TabIndex = 16;
            // 
            // datagridviewProducts
            // 
            this.datagridviewProducts.AllowUserToAddRows = false;
            this.datagridviewProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridviewProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridviewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridviewProducts.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datagridviewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridviewProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridviewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proIdGV,
            this.proGV,
            this.barcodeGV,
            this.expiryGV,
            this.catIdGV,
            this.catGV});
            this.datagridviewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewProducts.DoubleBuffered = true;
            this.datagridviewProducts.EnableHeadersVisualStyles = false;
            this.datagridviewProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.datagridviewProducts.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.datagridviewProducts.HeaderForeColor = System.Drawing.Color.White;
            this.datagridviewProducts.Location = new System.Drawing.Point(0, 0);
            this.datagridviewProducts.Name = "datagridviewProducts";
            this.datagridviewProducts.ReadOnly = true;
            this.datagridviewProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridviewProducts.RowHeadersVisible = false;
            this.datagridviewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewProducts.Size = new System.Drawing.Size(780, 522);
            this.datagridviewProducts.TabIndex = 0;
            this.datagridviewProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewProducts_CellDoubleClick);
            // 
            // proIdGV
            // 
            this.proIdGV.HeaderText = "proID";
            this.proIdGV.Name = "proIdGV";
            this.proIdGV.ReadOnly = true;
            this.proIdGV.Visible = false;
            // 
            // proGV
            // 
            this.proGV.HeaderText = "Product";
            this.proGV.Name = "proGV";
            this.proGV.ReadOnly = true;
            // 
            // barcodeGV
            // 
            this.barcodeGV.HeaderText = "Barcode";
            this.barcodeGV.Name = "barcodeGV";
            this.barcodeGV.ReadOnly = true;
            // 
            // expiryGV
            // 
            this.expiryGV.HeaderText = "Expiry Date";
            this.expiryGV.Name = "expiryGV";
            this.expiryGV.ReadOnly = true;
            // 
            // catIdGV
            // 
            this.catIdGV.HeaderText = "catIdGV";
            this.catIdGV.Name = "catIdGV";
            this.catIdGV.ReadOnly = true;
            this.catIdGV.Visible = false;
            // 
            // catGV
            // 
            this.catGV.HeaderText = "Category";
            this.catGV.Name = "catGV";
            this.catGV.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.textboxProSearch);
            this.groupBox1.Location = new System.Drawing.Point(420, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 44);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(4, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 3);
            this.panel2.TabIndex = 4;
            // 
            // textboxProSearch
            // 
            this.textboxProSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.textboxProSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxProSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxProSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxProSearch.Location = new System.Drawing.Point(3, 16);
            this.textboxProSearch.Name = "textboxProSearch";
            this.textboxProSearch.Size = new System.Drawing.Size(327, 15);
            this.textboxProSearch.TabIndex = 3;
            this.textboxProSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxProSearch_KeyPress);
            // 
            // btnViewProducts
            // 
            this.btnViewProducts.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnViewProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnViewProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewProducts.BorderRadius = 0;
            this.btnViewProducts.ButtonText = "";
            this.btnViewProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewProducts.DisabledColor = System.Drawing.Color.Gray;
            this.btnViewProducts.Iconcolor = System.Drawing.Color.Transparent;
            this.btnViewProducts.Iconimage = global::Inventory_Management_System.Properties.Resources.icons8_recurring_appointment_50px;
            this.btnViewProducts.Iconimage_right = null;
            this.btnViewProducts.Iconimage_right_Selected = null;
            this.btnViewProducts.Iconimage_Selected = null;
            this.btnViewProducts.IconMarginLeft = 0;
            this.btnViewProducts.IconMarginRight = 0;
            this.btnViewProducts.IconRightVisible = true;
            this.btnViewProducts.IconRightZoom = 0D;
            this.btnViewProducts.IconVisible = true;
            this.btnViewProducts.IconZoom = 50D;
            this.btnViewProducts.IsTab = false;
            this.btnViewProducts.Location = new System.Drawing.Point(353, 12);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnViewProducts.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnViewProducts.OnHoverTextColor = System.Drawing.Color.White;
            this.btnViewProducts.selected = false;
            this.btnViewProducts.Size = new System.Drawing.Size(41, 39);
            this.btnViewProducts.TabIndex = 17;
            this.btnViewProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewProducts.Textcolor = System.Drawing.Color.White;
            this.btnViewProducts.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProducts.Click += new System.EventHandler(this.btnViewProducts_Click);
            // 
            // btnDelProducts
            // 
            this.btnDelProducts.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnDelProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnDelProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelProducts.BorderRadius = 0;
            this.btnDelProducts.ButtonText = "   DELETE";
            this.btnDelProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelProducts.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelProducts.Enabled = false;
            this.btnDelProducts.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelProducts.Iconimage = global::Inventory_Management_System.Properties.Resources.rubbish_bin_delete_button;
            this.btnDelProducts.Iconimage_right = null;
            this.btnDelProducts.Iconimage_right_Selected = null;
            this.btnDelProducts.Iconimage_Selected = null;
            this.btnDelProducts.IconMarginLeft = 0;
            this.btnDelProducts.IconMarginRight = 0;
            this.btnDelProducts.IconRightVisible = true;
            this.btnDelProducts.IconRightZoom = 0D;
            this.btnDelProducts.IconVisible = true;
            this.btnDelProducts.IconZoom = 45D;
            this.btnDelProducts.IsTab = false;
            this.btnDelProducts.Location = new System.Drawing.Point(230, 12);
            this.btnDelProducts.Name = "btnDelProducts";
            this.btnDelProducts.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnDelProducts.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnDelProducts.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelProducts.selected = false;
            this.btnDelProducts.Size = new System.Drawing.Size(117, 39);
            this.btnDelProducts.TabIndex = 14;
            this.btnDelProducts.Text = "   DELETE";
            this.btnDelProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelProducts.Textcolor = System.Drawing.Color.White;
            this.btnDelProducts.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelProducts.Click += new System.EventHandler(this.btnDelProducts_Click);
            // 
            // btnEditProducts
            // 
            this.btnEditProducts.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnEditProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnEditProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditProducts.BorderRadius = 0;
            this.btnEditProducts.ButtonText = "   EDIT";
            this.btnEditProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProducts.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditProducts.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditProducts.Iconimage = global::Inventory_Management_System.Properties.Resources.edit_file_32px;
            this.btnEditProducts.Iconimage_right = null;
            this.btnEditProducts.Iconimage_right_Selected = null;
            this.btnEditProducts.Iconimage_Selected = null;
            this.btnEditProducts.IconMarginLeft = 0;
            this.btnEditProducts.IconMarginRight = 0;
            this.btnEditProducts.IconRightVisible = true;
            this.btnEditProducts.IconRightZoom = 0D;
            this.btnEditProducts.IconVisible = true;
            this.btnEditProducts.IconZoom = 60D;
            this.btnEditProducts.IsTab = false;
            this.btnEditProducts.Location = new System.Drawing.Point(122, 12);
            this.btnEditProducts.Name = "btnEditProducts";
            this.btnEditProducts.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnEditProducts.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnEditProducts.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditProducts.selected = false;
            this.btnEditProducts.Size = new System.Drawing.Size(102, 39);
            this.btnEditProducts.TabIndex = 13;
            this.btnEditProducts.Text = "   EDIT";
            this.btnEditProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditProducts.Textcolor = System.Drawing.Color.White;
            this.btnEditProducts.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProducts.Click += new System.EventHandler(this.btnEditProducts_Click);
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnAddProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnAddProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProducts.BorderRadius = 0;
            this.btnAddProducts.ButtonText = "    ADD";
            this.btnAddProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProducts.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddProducts.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddProducts.Iconimage = global::Inventory_Management_System.Properties.Resources.plus;
            this.btnAddProducts.Iconimage_right = null;
            this.btnAddProducts.Iconimage_right_Selected = null;
            this.btnAddProducts.Iconimage_Selected = null;
            this.btnAddProducts.IconMarginLeft = 0;
            this.btnAddProducts.IconMarginRight = 0;
            this.btnAddProducts.IconRightVisible = true;
            this.btnAddProducts.IconRightZoom = 0D;
            this.btnAddProducts.IconVisible = true;
            this.btnAddProducts.IconZoom = 50D;
            this.btnAddProducts.IsTab = false;
            this.btnAddProducts.Location = new System.Drawing.Point(12, 12);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnAddProducts.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnAddProducts.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddProducts.selected = false;
            this.btnAddProducts.Size = new System.Drawing.Size(104, 39);
            this.btnAddProducts.TabIndex = 12;
            this.btnAddProducts.Text = "    ADD";
            this.btnAddProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProducts.Textcolor = System.Drawing.Color.White;
            this.btnAddProducts.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 580);
            this.Controls.Add(this.btnViewProducts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelProducts);
            this.Controls.Add(this.btnEditProducts);
            this.Controls.Add(this.btnAddProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnViewProducts;
        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuCustomDataGrid datagridviewProducts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textboxProSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIdGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodeGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIdGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn catGV;
        private System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuFlatButton btnDelProducts;
        public Bunifu.Framework.UI.BunifuFlatButton btnEditProducts;
        public Bunifu.Framework.UI.BunifuFlatButton btnAddProducts;
    }
}