namespace Inventory_Management_System
{
    partial class ViewPurchasetab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPurchasetab));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PurDD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.Grosslable = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.datagridviewPurchaseview = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.mPIDgv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proIdGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pupGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelPurchase = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Datepicker = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewPurchaseview)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PurDD
            // 
            this.PurDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PurDD.FormattingEnabled = true;
            this.PurDD.Location = new System.Drawing.Point(50, 27);
            this.PurDD.Name = "PurDD";
            this.PurDD.Size = new System.Drawing.Size(178, 21);
            this.PurDD.TabIndex = 25;
            this.PurDD.SelectedIndexChanged += new System.EventHandler(this.PurDD_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Select Purchase";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Select Date";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.datagridviewPurchaseview);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 580);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel5.Controls.Add(this.bunifuGradientPanel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 531);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(804, 49);
            this.panel5.TabIndex = 2;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.Grosslable);
            this.bunifuGradientPanel1.Controls.Add(this.label7);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(157)))), ((int)(((byte)(242)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, -2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(804, 51);
            this.bunifuGradientPanel1.TabIndex = 40;
            // 
            // Grosslable
            // 
            this.Grosslable.AutoSize = true;
            this.Grosslable.BackColor = System.Drawing.Color.Transparent;
            this.Grosslable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grosslable.Location = new System.Drawing.Point(442, 17);
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
            this.label7.Location = new System.Drawing.Point(257, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Gross Total Price:";
            // 
            // datagridviewPurchaseview
            // 
            this.datagridviewPurchaseview.AllowUserToAddRows = false;
            this.datagridviewPurchaseview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridviewPurchaseview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridviewPurchaseview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridviewPurchaseview.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datagridviewPurchaseview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridviewPurchaseview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewPurchaseview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridviewPurchaseview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewPurchaseview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mPIDgv,
            this.proIdGv,
            this.Product,
            this.quanGv,
            this.pupGv,
            this.TotGv});
            this.datagridviewPurchaseview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewPurchaseview.DoubleBuffered = true;
            this.datagridviewPurchaseview.EnableHeadersVisualStyles = false;
            this.datagridviewPurchaseview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.datagridviewPurchaseview.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.datagridviewPurchaseview.HeaderForeColor = System.Drawing.Color.White;
            this.datagridviewPurchaseview.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datagridviewPurchaseview.Location = new System.Drawing.Point(0, 56);
            this.datagridviewPurchaseview.Name = "datagridviewPurchaseview";
            this.datagridviewPurchaseview.ReadOnly = true;
            this.datagridviewPurchaseview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridviewPurchaseview.RowHeadersVisible = false;
            this.datagridviewPurchaseview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewPurchaseview.Size = new System.Drawing.Size(804, 524);
            this.datagridviewPurchaseview.TabIndex = 1;
            this.datagridviewPurchaseview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewPurchaseview_CellDoubleClick);
            // 
            // mPIDgv
            // 
            this.mPIDgv.HeaderText = "mPIDGV";
            this.mPIDgv.Name = "mPIDgv";
            this.mPIDgv.ReadOnly = true;
            this.mPIDgv.Visible = false;
            // 
            // proIdGv
            // 
            this.proIdGv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.proIdGv.DefaultCellStyle = dataGridViewCellStyle3;
            this.proIdGv.HeaderText = "Product ID";
            this.proIdGv.Name = "proIdGv";
            this.proIdGv.ReadOnly = true;
            // 
            // Product
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Product.DefaultCellStyle = dataGridViewCellStyle4;
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // quanGv
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quanGv.DefaultCellStyle = dataGridViewCellStyle5;
            this.quanGv.HeaderText = "Quantity";
            this.quanGv.Name = "quanGv";
            this.quanGv.ReadOnly = true;
            // 
            // pupGv
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.pupGv.DefaultCellStyle = dataGridViewCellStyle6;
            this.pupGv.HeaderText = "Per Unit Price";
            this.pupGv.Name = "pupGv";
            this.pupGv.ReadOnly = true;
            // 
            // TotGv
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.TotGv.DefaultCellStyle = dataGridViewCellStyle7;
            this.TotGv.HeaderText = "Total Amount";
            this.TotGv.Name = "TotGv";
            this.TotGv.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDelPurchase);
            this.panel3.Controls.Add(this.Datepicker);
            this.panel3.Controls.Add(this.PurDD);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 56);
            this.panel3.TabIndex = 0;
            // 
            // btnDelPurchase
            // 
            this.btnDelPurchase.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnDelPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnDelPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelPurchase.BorderRadius = 0;
            this.btnDelPurchase.ButtonText = "   DELETE";
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
            this.btnDelPurchase.Location = new System.Drawing.Point(458, 9);
            this.btnDelPurchase.Name = "btnDelPurchase";
            this.btnDelPurchase.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnDelPurchase.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnDelPurchase.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelPurchase.selected = false;
            this.btnDelPurchase.Size = new System.Drawing.Size(120, 39);
            this.btnDelPurchase.TabIndex = 34;
            this.btnDelPurchase.Text = "   DELETE";
            this.btnDelPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelPurchase.Textcolor = System.Drawing.Color.White;
            this.btnDelPurchase.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelPurchase.Click += new System.EventHandler(this.btnDelPurchase_Click);
            // 
            // Datepicker
            // 
            this.Datepicker.CustomFormat = "MMMM-  yyyy";
            this.Datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Datepicker.Location = new System.Drawing.Point(241, 27);
            this.Datepicker.Name = "Datepicker";
            this.Datepicker.ShowUpDown = true;
            this.Datepicker.Size = new System.Drawing.Size(200, 20);
            this.Datepicker.TabIndex = 26;
            this.Datepicker.ValueChanged += new System.EventHandler(this.Datepicker_ValueChanged);
            // 
            // ViewPurchasetab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 580);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPurchasetab";
            this.Text = "ViewPurchasetab";
            this.Load += new System.EventHandler(this.ViewPurchasetab_Load);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewPurchaseview)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public Bunifu.Framework.UI.BunifuCustomDataGrid datagridviewPurchaseview;
        private System.Windows.Forms.ComboBox PurDD;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Label Grosslable;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Datepicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn mPIDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIdGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn quanGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn pupGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotGv;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        public Bunifu.Framework.UI.BunifuFlatButton btnDelPurchase;
    }
}