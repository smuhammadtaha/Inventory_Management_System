namespace Inventory_Management_System
{
    partial class UpdateProducts
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
            this.dateExpiry = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxBarcode = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnAddProd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboboxCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxProName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.addCatHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Error1 = new System.Windows.Forms.PictureBox();
            this.Error2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addCatHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error2)).BeginInit();
            this.SuspendLayout();
            // 
            // dateExpiry
            // 
            this.dateExpiry.Location = new System.Drawing.Point(16, 210);
            this.dateExpiry.Name = "dateExpiry";
            this.dateExpiry.Size = new System.Drawing.Size(317, 20);
            this.dateExpiry.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Expiry Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Barcode";
            // 
            // textboxBarcode
            // 
            this.textboxBarcode.BorderColorFocused = System.Drawing.Color.Blue;
            this.textboxBarcode.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxBarcode.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.textboxBarcode.BorderThickness = 3;
            this.textboxBarcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxBarcode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textboxBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxBarcode.isPassword = false;
            this.textboxBarcode.Location = new System.Drawing.Point(16, 138);
            this.textboxBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.textboxBarcode.Name = "textboxBarcode";
            this.textboxBarcode.Size = new System.Drawing.Size(322, 40);
            this.textboxBarcode.TabIndex = 16;
            this.textboxBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnAddProd
            // 
            this.btnAddProd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.btnAddProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnAddProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProd.BorderRadius = 0;
            this.btnAddProd.ButtonText = "UPDATE";
            this.btnAddProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddProd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddProd.Iconimage = null;
            this.btnAddProd.Iconimage_right = null;
            this.btnAddProd.Iconimage_right_Selected = null;
            this.btnAddProd.Iconimage_Selected = null;
            this.btnAddProd.IconMarginLeft = 0;
            this.btnAddProd.IconMarginRight = 0;
            this.btnAddProd.IconRightVisible = true;
            this.btnAddProd.IconRightZoom = 0D;
            this.btnAddProd.IconVisible = true;
            this.btnAddProd.IconZoom = 90D;
            this.btnAddProd.IsTab = false;
            this.btnAddProd.Location = new System.Drawing.Point(16, 315);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnAddProd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnAddProd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddProd.selected = false;
            this.btnAddProd.Size = new System.Drawing.Size(319, 41);
            this.btnAddProd.TabIndex = 23;
            this.btnAddProd.Text = "UPDATE";
            this.btnAddProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddProd.Textcolor = System.Drawing.Color.White;
            this.btnAddProd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Category";
            // 
            // comboboxCategory
            // 
            this.comboboxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxCategory.FormattingEnabled = true;
            this.comboboxCategory.Location = new System.Drawing.Point(16, 270);
            this.comboboxCategory.Name = "comboboxCategory";
            this.comboboxCategory.Size = new System.Drawing.Size(319, 21);
            this.comboboxCategory.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Product Name";
            // 
            // textboxProName
            // 
            this.textboxProName.BorderColorFocused = System.Drawing.Color.Blue;
            this.textboxProName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxProName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.textboxProName.BorderThickness = 3;
            this.textboxProName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxProName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textboxProName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxProName.isPassword = false;
            this.textboxProName.Location = new System.Drawing.Point(16, 66);
            this.textboxProName.Margin = new System.Windows.Forms.Padding(4);
            this.textboxProName.Name = "textboxProName";
            this.textboxProName.Size = new System.Drawing.Size(322, 40);
            this.textboxProName.TabIndex = 14;
            this.textboxProName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textboxProName.OnValueChanged += new System.EventHandler(this.textboxProName_OnValueChanged);
            // 
            // addCatHeader
            // 
            this.addCatHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.addCatHeader.Controls.Add(this.label5);
            this.addCatHeader.Controls.Add(this.pictureBox1);
            this.addCatHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.addCatHeader.Location = new System.Drawing.Point(0, 0);
            this.addCatHeader.Name = "addCatHeader";
            this.addCatHeader.Size = new System.Drawing.Size(346, 26);
            this.addCatHeader.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Inventory_Management_System.Properties.Resources.icons8_xbox_x_32px_1;
            this.pictureBox1.Location = new System.Drawing.Point(320, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Error1
            // 
            this.Error1.Image = global::Inventory_Management_System.Properties.Resources.attention_filled_50px;
            this.Error1.Location = new System.Drawing.Point(305, 73);
            this.Error1.Name = "Error1";
            this.Error1.Size = new System.Drawing.Size(26, 26);
            this.Error1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Error1.TabIndex = 32;
            this.Error1.TabStop = false;
            this.Error1.Visible = false;
            // 
            // Error2
            // 
            this.Error2.Image = global::Inventory_Management_System.Properties.Resources.attention_filled_50px;
            this.Error2.Location = new System.Drawing.Point(302, 145);
            this.Error2.Name = "Error2";
            this.Error2.Size = new System.Drawing.Size(26, 26);
            this.Error2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Error2.TabIndex = 33;
            this.Error2.TabStop = false;
            this.Error2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(126, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Update Product";
            // 
            // UpdateProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 371);
            this.Controls.Add(this.Error2);
            this.Controls.Add(this.Error1);
            this.Controls.Add(this.dateExpiry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxBarcode);
            this.Controls.Add(this.btnAddProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboboxCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxProName);
            this.Controls.Add(this.addCatHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateProducts";
            this.Load += new System.EventHandler(this.UpdateProducts_Load);
            this.addCatHeader.ResumeLayout(false);
            this.addCatHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DateTimePicker dateExpiry;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public Bunifu.Framework.UI.BunifuMetroTextbox textboxBarcode;
        public Bunifu.Framework.UI.BunifuFlatButton btnAddProd;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboboxCategory;
        public System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuMetroTextbox textboxProName;
        public System.Windows.Forms.Panel addCatHeader;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox Error1;
        public System.Windows.Forms.PictureBox Error2;
        private System.Windows.Forms.Label label5;
    }
}