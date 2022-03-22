namespace Inventory_Management_System
{
    partial class Supplier
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
            this.datagridviewSupplier = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.suppIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone1GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone2GV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ntnGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textboxSuppSearch = new System.Windows.Forms.TextBox();
            this.btnViewSuppliers = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelSupplier = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditSupplier = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddSupplier = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewSupplier)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datagridviewSupplier);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 518);
            this.panel1.TabIndex = 22;
            // 
            // datagridviewSupplier
            // 
            this.datagridviewSupplier.AllowUserToAddRows = false;
            this.datagridviewSupplier.AllowUserToDeleteRows = false;
            this.datagridviewSupplier.AllowUserToResizeColumns = false;
            this.datagridviewSupplier.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridviewSupplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridviewSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridviewSupplier.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datagridviewSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridviewSupplier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridviewSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.suppIDGV,
            this.companyGV,
            this.personGV,
            this.phone1GV,
            this.phone2GV,
            this.addressGV,
            this.ntnGV,
            this.statusGV});
            this.datagridviewSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewSupplier.DoubleBuffered = true;
            this.datagridviewSupplier.EnableHeadersVisualStyles = false;
            this.datagridviewSupplier.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.datagridviewSupplier.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.datagridviewSupplier.HeaderForeColor = System.Drawing.Color.White;
            this.datagridviewSupplier.Location = new System.Drawing.Point(0, 0);
            this.datagridviewSupplier.Name = "datagridviewSupplier";
            this.datagridviewSupplier.ReadOnly = true;
            this.datagridviewSupplier.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridviewSupplier.RowHeadersVisible = false;
            this.datagridviewSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewSupplier.Size = new System.Drawing.Size(780, 518);
            this.datagridviewSupplier.TabIndex = 0;
            this.datagridviewSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewSupplier_CellClick);
            this.datagridviewSupplier.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridviewSupplier_CellDoubleClick);
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
            this.companyGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // personGV
            // 
            this.personGV.HeaderText = "Contact Person";
            this.personGV.Name = "personGV";
            this.personGV.ReadOnly = true;
            this.personGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // phone1GV
            // 
            this.phone1GV.HeaderText = "Phone 1";
            this.phone1GV.Name = "phone1GV";
            this.phone1GV.ReadOnly = true;
            this.phone1GV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // phone2GV
            // 
            this.phone2GV.HeaderText = "Phone 2";
            this.phone2GV.Name = "phone2GV";
            this.phone2GV.ReadOnly = true;
            this.phone2GV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.phone2GV.Visible = false;
            // 
            // addressGV
            // 
            this.addressGV.HeaderText = "Address";
            this.addressGV.Name = "addressGV";
            this.addressGV.ReadOnly = true;
            this.addressGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ntnGV
            // 
            this.ntnGV.HeaderText = "NTN #";
            this.ntnGV.Name = "ntnGV";
            this.ntnGV.ReadOnly = true;
            this.ntnGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // statusGV
            // 
            this.statusGV.HeaderText = "Status";
            this.statusGV.Name = "statusGV";
            this.statusGV.ReadOnly = true;
            this.statusGV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.textboxSuppSearch);
            this.groupBox1.Location = new System.Drawing.Point(420, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 44);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.panel2.Location = new System.Drawing.Point(4, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 3);
            this.panel2.TabIndex = 1;
            // 
            // textboxSuppSearch
            // 
            this.textboxSuppSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.textboxSuppSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxSuppSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxSuppSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxSuppSearch.Location = new System.Drawing.Point(3, 16);
            this.textboxSuppSearch.Name = "textboxSuppSearch";
            this.textboxSuppSearch.Size = new System.Drawing.Size(316, 15);
            this.textboxSuppSearch.TabIndex = 3;
            this.textboxSuppSearch.TextChanged += new System.EventHandler(this.textboxSuppSearch_TextChanged);
            this.textboxSuppSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxSuppSearch_KeyPress);
            // 
            // btnViewSuppliers
            // 
            this.btnViewSuppliers.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnViewSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnViewSuppliers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewSuppliers.BorderRadius = 0;
            this.btnViewSuppliers.ButtonText = "";
            this.btnViewSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewSuppliers.DisabledColor = System.Drawing.Color.Gray;
            this.btnViewSuppliers.Iconcolor = System.Drawing.Color.Transparent;
            this.btnViewSuppliers.Iconimage = global::Inventory_Management_System.Properties.Resources.icons8_recurring_appointment_50px;
            this.btnViewSuppliers.Iconimage_right = null;
            this.btnViewSuppliers.Iconimage_right_Selected = null;
            this.btnViewSuppliers.Iconimage_Selected = null;
            this.btnViewSuppliers.IconMarginLeft = 0;
            this.btnViewSuppliers.IconMarginRight = 0;
            this.btnViewSuppliers.IconRightVisible = true;
            this.btnViewSuppliers.IconRightZoom = 0D;
            this.btnViewSuppliers.IconVisible = true;
            this.btnViewSuppliers.IconZoom = 50D;
            this.btnViewSuppliers.IsTab = false;
            this.btnViewSuppliers.Location = new System.Drawing.Point(351, 12);
            this.btnViewSuppliers.Name = "btnViewSuppliers";
            this.btnViewSuppliers.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnViewSuppliers.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnViewSuppliers.OnHoverTextColor = System.Drawing.Color.White;
            this.btnViewSuppliers.selected = false;
            this.btnViewSuppliers.Size = new System.Drawing.Size(43, 39);
            this.btnViewSuppliers.TabIndex = 23;
            this.btnViewSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewSuppliers.Textcolor = System.Drawing.Color.White;
            this.btnViewSuppliers.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewSuppliers.Click += new System.EventHandler(this.btnViewSuppliers_Click);
            // 
            // btnDelSupplier
            // 
            this.btnDelSupplier.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnDelSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnDelSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelSupplier.BorderRadius = 0;
            this.btnDelSupplier.ButtonText = "   DELETE";
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
            this.btnDelSupplier.Location = new System.Drawing.Point(229, 12);
            this.btnDelSupplier.Name = "btnDelSupplier";
            this.btnDelSupplier.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnDelSupplier.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnDelSupplier.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelSupplier.selected = false;
            this.btnDelSupplier.Size = new System.Drawing.Size(116, 39);
            this.btnDelSupplier.TabIndex = 20;
            this.btnDelSupplier.Text = "   DELETE";
            this.btnDelSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelSupplier.Textcolor = System.Drawing.Color.White;
            this.btnDelSupplier.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelSupplier.Click += new System.EventHandler(this.btnDelSupplier_Click);
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnEditSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnEditSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditSupplier.BorderRadius = 0;
            this.btnEditSupplier.ButtonText = "   EDIT";
            this.btnEditSupplier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSupplier.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditSupplier.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditSupplier.Iconimage = global::Inventory_Management_System.Properties.Resources.edit_file_32px;
            this.btnEditSupplier.Iconimage_right = null;
            this.btnEditSupplier.Iconimage_right_Selected = null;
            this.btnEditSupplier.Iconimage_Selected = null;
            this.btnEditSupplier.IconMarginLeft = 0;
            this.btnEditSupplier.IconMarginRight = 0;
            this.btnEditSupplier.IconRightVisible = true;
            this.btnEditSupplier.IconRightZoom = 0D;
            this.btnEditSupplier.IconVisible = true;
            this.btnEditSupplier.IconZoom = 50D;
            this.btnEditSupplier.IsTab = false;
            this.btnEditSupplier.Location = new System.Drawing.Point(123, 12);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnEditSupplier.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnEditSupplier.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditSupplier.selected = false;
            this.btnEditSupplier.Size = new System.Drawing.Size(100, 39);
            this.btnEditSupplier.TabIndex = 19;
            this.btnEditSupplier.Text = "   EDIT";
            this.btnEditSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditSupplier.Textcolor = System.Drawing.Color.White;
            this.btnEditSupplier.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click_1);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnAddSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnAddSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSupplier.BorderRadius = 0;
            this.btnAddSupplier.ButtonText = "    ADD";
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
            this.btnAddSupplier.Location = new System.Drawing.Point(12, 12);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnAddSupplier.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnAddSupplier.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddSupplier.selected = false;
            this.btnAddSupplier.Size = new System.Drawing.Size(105, 39);
            this.btnAddSupplier.TabIndex = 18;
            this.btnAddSupplier.Text = "    ADD";
            this.btnAddSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSupplier.Textcolor = System.Drawing.Color.White;
            this.btnAddSupplier.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 580);
            this.Controls.Add(this.btnViewSuppliers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelSupplier);
            this.Controls.Add(this.btnEditSupplier);
            this.Controls.Add(this.btnAddSupplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewSupplier)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnViewSuppliers;
        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuCustomDataGrid datagridviewSupplier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textboxSuppSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn personGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone1GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone2GV;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ntnGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusGV;
        private System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuFlatButton btnDelSupplier;
        public Bunifu.Framework.UI.BunifuFlatButton btnEditSupplier;
        public Bunifu.Framework.UI.BunifuFlatButton btnAddSupplier;
    }
}