namespace Inventory_Management_System
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.datagridviewSales = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.proIdGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quanGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pupGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone1GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone2GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ntnGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textboxSuppSearch = new System.Windows.Forms.TextBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.Grosslabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Printbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelSupplier = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddSupplier = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewSales)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datagridviewSales);
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 466);
            this.panel1.TabIndex = 34;
            // 
            // datagridviewSales
            // 
            this.datagridviewSales.AllowUserToAddRows = false;
            this.datagridviewSales.AllowUserToDeleteRows = false;
            this.datagridviewSales.AllowUserToResizeColumns = false;
            this.datagridviewSales.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridviewSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridviewSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridviewSales.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datagridviewSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridviewSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridviewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proIdGv,
            this.ProGv,
            this.quanGv,
            this.pupGv,
            this.discGV,
            this.TotGv});
            this.datagridviewSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewSales.DoubleBuffered = true;
            this.datagridviewSales.EnableHeadersVisualStyles = false;
            this.datagridviewSales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.datagridviewSales.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.datagridviewSales.HeaderForeColor = System.Drawing.Color.White;
            this.datagridviewSales.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datagridviewSales.Location = new System.Drawing.Point(0, 0);
            this.datagridviewSales.Name = "datagridviewSales";
            this.datagridviewSales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridviewSales.RowHeadersVisible = false;
            this.datagridviewSales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.datagridviewSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewSales.Size = new System.Drawing.Size(780, 466);
            this.datagridviewSales.TabIndex = 1;
            this.datagridviewSales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewSales_CellDoubleClick);
            // 
            // proIdGv
            // 
            this.proIdGv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.proIdGv.DefaultCellStyle = dataGridViewCellStyle3;
            this.proIdGv.HeaderText = "ProID";
            this.proIdGv.Name = "proIdGv";
            this.proIdGv.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ProGv
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ProGv.DefaultCellStyle = dataGridViewCellStyle4;
            this.ProGv.HeaderText = "Product";
            this.ProGv.Name = "ProGv";
            this.ProGv.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // quanGv
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quanGv.DefaultCellStyle = dataGridViewCellStyle5;
            this.quanGv.HeaderText = "Quantity";
            this.quanGv.Name = "quanGv";
            this.quanGv.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pupGv
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.pupGv.DefaultCellStyle = dataGridViewCellStyle6;
            this.pupGv.HeaderText = "Per Unit Price";
            this.pupGv.Name = "pupGv";
            this.pupGv.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // discGV
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.discGV.DefaultCellStyle = dataGridViewCellStyle7;
            this.discGV.HeaderText = "Discount";
            this.discGV.Name = "discGV";
            // 
            // TotGv
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.TotGv.DefaultCellStyle = dataGridViewCellStyle8;
            this.TotGv.HeaderText = "Total Amount";
            this.TotGv.Name = "TotGv";
            this.TotGv.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // suppIDGV
            // 
            this.suppIDGV.HeaderText = "SuppID";
            this.suppIDGV.Name = "suppIDGV";
            this.suppIDGV.ReadOnly = true;
            this.suppIDGV.Visible = false;
            // 
            // companyGV
            // 
            this.companyGV.HeaderText = "Company";
            this.companyGV.Name = "companyGV";
            this.companyGV.ReadOnly = true;
            // 
            // personGV
            // 
            this.personGV.HeaderText = "Contact Person";
            this.personGV.Name = "personGV";
            this.personGV.ReadOnly = true;
            // 
            // phone1GV
            // 
            this.phone1GV.HeaderText = "Phone 1";
            this.phone1GV.Name = "phone1GV";
            this.phone1GV.ReadOnly = true;
            // 
            // phone2GV
            // 
            this.phone2GV.HeaderText = "Phone 2";
            this.phone2GV.Name = "phone2GV";
            this.phone2GV.ReadOnly = true;
            this.phone2GV.Visible = false;
            // 
            // addressGV
            // 
            this.addressGV.HeaderText = "Address";
            this.addressGV.Name = "addressGV";
            this.addressGV.ReadOnly = true;
            // 
            // ntnGV
            // 
            this.ntnGV.HeaderText = "NTN #";
            this.ntnGV.Name = "ntnGV";
            this.ntnGV.ReadOnly = true;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.textboxSuppSearch);
            this.groupBox1.Location = new System.Drawing.Point(458, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 44);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(2, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 2);
            this.panel3.TabIndex = 2;
            // 
            // textboxSuppSearch
            // 
            this.textboxSuppSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.textboxSuppSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxSuppSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxSuppSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxSuppSearch.Location = new System.Drawing.Point(3, 16);
            this.textboxSuppSearch.Name = "textboxSuppSearch";
            this.textboxSuppSearch.Size = new System.Drawing.Size(328, 15);
            this.textboxSuppSearch.TabIndex = 3;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.Grosslabel);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(157)))), ((int)(((byte)(242)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(12, 528);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(782, 51);
            this.bunifuGradientPanel1.TabIndex = 39;
            // 
            // Grosslabel
            // 
            this.Grosslabel.AutoSize = true;
            this.Grosslabel.BackColor = System.Drawing.Color.Transparent;
            this.Grosslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grosslabel.Location = new System.Drawing.Point(417, 15);
            this.Grosslabel.Name = "Grosslabel";
            this.Grosslabel.Size = new System.Drawing.Size(54, 25);
            this.Grosslabel.TabIndex = 40;
            this.Grosslabel.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(289, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 39;
            this.label5.Text = "Gross Total";
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
            this.Printbtn.IconZoom = 65D;
            this.Printbtn.IsTab = false;
            this.Printbtn.Location = new System.Drawing.Point(327, 9);
            this.Printbtn.Name = "Printbtn";
            this.Printbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.Printbtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.Printbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.Printbtn.selected = false;
            this.Printbtn.Size = new System.Drawing.Size(121, 39);
            this.Printbtn.TabIndex = 38;
            this.Printbtn.Text = "     PRINT";
            this.Printbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Printbtn.Textcolor = System.Drawing.Color.White;
            this.Printbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Printbtn.Click += new System.EventHandler(this.Printbtn_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "   SAVE";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::Inventory_Management_System.Properties.Resources.down_arrow_download_button;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 45D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(107, 9);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(94, 39);
            this.bunifuFlatButton1.TabIndex = 37;
            this.bunifuFlatButton1.Text = "   SAVE";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnDelSupplier
            // 
            this.btnDelSupplier.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnDelSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnDelSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelSupplier.BorderRadius = 0;
            this.btnDelSupplier.ButtonText = "  DELETE";
            this.btnDelSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelSupplier.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelSupplier.Enabled = false;
            this.btnDelSupplier.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelSupplier.Iconimage = global::Inventory_Management_System.Properties.Resources.rubbish_bin_delete_button;
            this.btnDelSupplier.Iconimage_right = null;
            this.btnDelSupplier.Iconimage_right_Selected = null;
            this.btnDelSupplier.Iconimage_Selected = null;
            this.btnDelSupplier.IconMarginLeft = 0;
            this.btnDelSupplier.IconMarginRight = 0;
            this.btnDelSupplier.IconRightVisible = true;
            this.btnDelSupplier.IconRightZoom = 0D;
            this.btnDelSupplier.IconVisible = true;
            this.btnDelSupplier.IconZoom = 45D;
            this.btnDelSupplier.IsTab = false;
            this.btnDelSupplier.Location = new System.Drawing.Point(210, 9);
            this.btnDelSupplier.Name = "btnDelSupplier";
            this.btnDelSupplier.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnDelSupplier.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnDelSupplier.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelSupplier.selected = false;
            this.btnDelSupplier.Size = new System.Drawing.Size(109, 39);
            this.btnDelSupplier.TabIndex = 32;
            this.btnDelSupplier.Text = "  DELETE";
            this.btnDelSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelSupplier.Textcolor = System.Drawing.Color.White;
            this.btnDelSupplier.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelSupplier.Click += new System.EventHandler(this.btnDelSupplier_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnAddSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnAddSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSupplier.BorderRadius = 0;
            this.btnAddSupplier.ButtonText = "   ADD";
            this.btnAddSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSupplier.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddSupplier.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddSupplier.Iconimage = global::Inventory_Management_System.Properties.Resources.plus;
            this.btnAddSupplier.Iconimage_right = null;
            this.btnAddSupplier.Iconimage_right_Selected = null;
            this.btnAddSupplier.Iconimage_Selected = null;
            this.btnAddSupplier.IconMarginLeft = 0;
            this.btnAddSupplier.IconMarginRight = 0;
            this.btnAddSupplier.IconRightVisible = true;
            this.btnAddSupplier.IconRightZoom = 0D;
            this.btnAddSupplier.IconVisible = true;
            this.btnAddSupplier.IconZoom = 50D;
            this.btnAddSupplier.IsTab = false;
            this.btnAddSupplier.Location = new System.Drawing.Point(12, 9);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnAddSupplier.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnAddSupplier.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddSupplier.selected = false;
            this.btnAddSupplier.Size = new System.Drawing.Size(89, 39);
            this.btnAddSupplier.TabIndex = 30;
            this.btnAddSupplier.Text = "   ADD";
            this.btnAddSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSupplier.Textcolor = System.Drawing.Color.White;
            this.btnAddSupplier.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 580);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.Printbtn);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelSupplier);
            this.Controls.Add(this.btnAddSupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewSales)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuCustomDataGrid datagridviewSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn personGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone1GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone2GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ntnGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textboxSuppSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelSupplier;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddSupplier;
        public System.Windows.Forms.Label Grosslabel;
        public System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        public Bunifu.Framework.UI.BunifuCustomDataGrid datagridviewSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIdGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn quanGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn pupGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn discGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotGv;
        private Bunifu.Framework.UI.BunifuFlatButton Printbtn;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
    }
}