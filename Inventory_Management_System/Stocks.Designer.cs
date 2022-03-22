namespace Inventory_Management_System
{
    partial class Stocks
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.datagridviewStock = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.proIdGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bpGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datagridviewStock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 580);
            this.panel1.TabIndex = 35;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // datagridviewStock
            // 
            this.datagridviewStock.AllowUserToAddRows = false;
            this.datagridviewStock.AllowUserToDeleteRows = false;
            this.datagridviewStock.AllowUserToResizeColumns = false;
            this.datagridviewStock.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridviewStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridviewStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridviewStock.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datagridviewStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridviewStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridviewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proIdGv,
            this.Product,
            this.quanGv,
            this.barGV,
            this.expiryGV,
            this.bpGV,
            this.spGV,
            this.catGV,
            this.finalGV,
            this.statusGV});
            this.datagridviewStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewStock.DoubleBuffered = true;
            this.datagridviewStock.EnableHeadersVisualStyles = false;
            this.datagridviewStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.datagridviewStock.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.datagridviewStock.HeaderForeColor = System.Drawing.Color.White;
            this.datagridviewStock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datagridviewStock.Location = new System.Drawing.Point(0, 0);
            this.datagridviewStock.Name = "datagridviewStock";
            this.datagridviewStock.ReadOnly = true;
            this.datagridviewStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridviewStock.RowHeadersVisible = false;
            this.datagridviewStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewStock.Size = new System.Drawing.Size(804, 580);
            this.datagridviewStock.TabIndex = 0;
            // 
            // proIdGv
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.proIdGv.DefaultCellStyle = dataGridViewCellStyle3;
            this.proIdGv.HeaderText = "ProID";
            this.proIdGv.Name = "proIdGv";
            this.proIdGv.ReadOnly = true;
            this.proIdGv.Visible = false;
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Product.DefaultCellStyle = dataGridViewCellStyle4;
            this.Product.FillWeight = 61.92528F;
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 78;
            // 
            // quanGv
            // 
            this.quanGv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quanGv.DefaultCellStyle = dataGridViewCellStyle5;
            this.quanGv.FillWeight = 55.97255F;
            this.quanGv.HeaderText = "Quantity";
            this.quanGv.Name = "quanGv";
            this.quanGv.ReadOnly = true;
            this.quanGv.Width = 82;
            // 
            // barGV
            // 
            this.barGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.barGV.FillWeight = 60.15104F;
            this.barGV.HeaderText = "Barcode";
            this.barGV.Name = "barGV";
            this.barGV.ReadOnly = true;
            this.barGV.Width = 82;
            // 
            // expiryGV
            // 
            this.expiryGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.expiryGV.FillWeight = 43.86588F;
            this.expiryGV.HeaderText = "Expiry Date";
            this.expiryGV.Name = "expiryGV";
            this.expiryGV.ReadOnly = true;
            this.expiryGV.Width = 97;
            // 
            // bpGV
            // 
            this.bpGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.bpGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.bpGV.HeaderText = "Buying Price";
            this.bpGV.Name = "bpGV";
            this.bpGV.ReadOnly = true;
            this.bpGV.Width = 102;
            // 
            // spGV
            // 
            this.spGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.spGV.DefaultCellStyle = dataGridViewCellStyle7;
            this.spGV.FillWeight = 28.38859F;
            this.spGV.HeaderText = "Selling Price";
            this.spGV.Name = "spGV";
            this.spGV.ReadOnly = true;
            this.spGV.Width = 103;
            // 
            // catGV
            // 
            this.catGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.catGV.FillWeight = 21.56251F;
            this.catGV.HeaderText = "Category";
            this.catGV.Name = "catGV";
            this.catGV.ReadOnly = true;
            this.catGV.Width = 87;
            // 
            // finalGV
            // 
            this.finalGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.finalGV.DefaultCellStyle = dataGridViewCellStyle8;
            this.finalGV.FillWeight = 14.64521F;
            this.finalGV.HeaderText = "Total Amount";
            this.finalGV.Name = "finalGV";
            this.finalGV.ReadOnly = true;
            this.finalGV.Width = 110;
            // 
            // statusGV
            // 
            this.statusGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.statusGV.FillWeight = 7.461226F;
            this.statusGV.HeaderText = "Status";
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            this.statusGV.Width = 68;
            // 
            // Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 580);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stocks";
            this.Text = "Stocks";
            this.Load += new System.EventHandler(this.Stocks_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuCustomDataGrid datagridviewStock;
        public System.Windows.Forms.DataGridViewTextBoxColumn proIdGv;
        public System.Windows.Forms.DataGridViewTextBoxColumn Product;
        public System.Windows.Forms.DataGridViewTextBoxColumn quanGv;
        public System.Windows.Forms.DataGridViewTextBoxColumn barGV;
        public System.Windows.Forms.DataGridViewTextBoxColumn expiryGV;
        public System.Windows.Forms.DataGridViewTextBoxColumn bpGV;
        public System.Windows.Forms.DataGridViewTextBoxColumn spGV;
        public System.Windows.Forms.DataGridViewTextBoxColumn catGV;
        public System.Windows.Forms.DataGridViewTextBoxColumn finalGV;
        public System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
    }
}