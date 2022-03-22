namespace Inventory_Management_System
{
    partial class AddPurchase
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
            this.label5 = new System.Windows.Forms.Label();
            this.textboxProdQty = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxProdName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnAddPurchase = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboboxSupplier = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxBarcode = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.addPurcHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateOfPurchase = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textboxCostPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Totlable = new System.Windows.Forms.Label();
            this.Error1 = new System.Windows.Forms.PictureBox();
            this.Error2 = new System.Windows.Forms.PictureBox();
            this.Error3 = new System.Windows.Forms.PictureBox();
            this.Error4 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addPurcHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error4)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(365, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Product Quantity";
            // 
            // textboxProdQty
            // 
            this.textboxProdQty.BorderColorFocused = System.Drawing.Color.Blue;
            this.textboxProdQty.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxProdQty.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.textboxProdQty.BorderThickness = 3;
            this.textboxProdQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxProdQty.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textboxProdQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxProdQty.isPassword = false;
            this.textboxProdQty.Location = new System.Drawing.Point(365, 141);
            this.textboxProdQty.Margin = new System.Windows.Forms.Padding(4);
            this.textboxProdQty.Name = "textboxProdQty";
            this.textboxProdQty.Size = new System.Drawing.Size(322, 40);
            this.textboxProdQty.TabIndex = 5;
            this.textboxProdQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textboxProdQty.OnValueChanged += new System.EventHandler(this.textboxProdQty_OnValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Product";
            // 
            // textboxProdName
            // 
            this.textboxProdName.BorderColorFocused = System.Drawing.Color.Blue;
            this.textboxProdName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxProdName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.textboxProdName.BorderThickness = 3;
            this.textboxProdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxProdName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textboxProdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxProdName.isPassword = false;
            this.textboxProdName.Location = new System.Drawing.Point(16, 191);
            this.textboxProdName.Margin = new System.Windows.Forms.Padding(4);
            this.textboxProdName.Name = "textboxProdName";
            this.textboxProdName.Size = new System.Drawing.Size(322, 40);
            this.textboxProdName.TabIndex = 2;
            this.textboxProdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnAddPurchase
            // 
            this.btnAddPurchase.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.btnAddPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnAddPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPurchase.BorderRadius = 0;
            this.btnAddPurchase.ButtonText = "ADD";
            this.btnAddPurchase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPurchase.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddPurchase.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddPurchase.Iconimage = null;
            this.btnAddPurchase.Iconimage_right = null;
            this.btnAddPurchase.Iconimage_right_Selected = null;
            this.btnAddPurchase.Iconimage_Selected = null;
            this.btnAddPurchase.IconMarginLeft = 0;
            this.btnAddPurchase.IconMarginRight = 0;
            this.btnAddPurchase.IconRightVisible = true;
            this.btnAddPurchase.IconRightZoom = 0D;
            this.btnAddPurchase.IconVisible = true;
            this.btnAddPurchase.IconZoom = 90D;
            this.btnAddPurchase.IsTab = false;
            this.btnAddPurchase.Location = new System.Drawing.Point(368, 239);
            this.btnAddPurchase.Name = "btnAddPurchase";
            this.btnAddPurchase.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnAddPurchase.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnAddPurchase.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddPurchase.selected = false;
            this.btnAddPurchase.Size = new System.Drawing.Size(319, 41);
            this.btnAddPurchase.TabIndex = 7;
            this.btnAddPurchase.Text = "ADD";
            this.btnAddPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddPurchase.Textcolor = System.Drawing.Color.White;
            this.btnAddPurchase.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPurchase.Click += new System.EventHandler(this.btnAddPurchase_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Select Supplier";
            // 
            // comboboxSupplier
            // 
            this.comboboxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxSupplier.FormattingEnabled = true;
            this.comboboxSupplier.Items.AddRange(new object[] {
            "Select items..."});
            this.comboboxSupplier.Location = new System.Drawing.Point(19, 69);
            this.comboboxSupplier.Name = "comboboxSupplier";
            this.comboboxSupplier.Size = new System.Drawing.Size(319, 21);
            this.comboboxSupplier.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Barcode";
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
            this.textboxBarcode.Location = new System.Drawing.Point(16, 119);
            this.textboxBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.textboxBarcode.Name = "textboxBarcode";
            this.textboxBarcode.Size = new System.Drawing.Size(322, 40);
            this.textboxBarcode.TabIndex = 1;
            this.textboxBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textboxBarcode.Validating += new System.ComponentModel.CancelEventHandler(this.textboxBarcode_Validating);
            // 
            // addPurcHeader
            // 
            this.addPurcHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.addPurcHeader.Controls.Add(this.label8);
            this.addPurcHeader.Controls.Add(this.pictureBox1);
            this.addPurcHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.addPurcHeader.Location = new System.Drawing.Point(0, 0);
            this.addPurcHeader.Name = "addPurcHeader";
            this.addPurcHeader.Size = new System.Drawing.Size(716, 26);
            this.addPurcHeader.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Inventory_Management_System.Properties.Resources.icons8_xbox_x_32px_1;
            this.pictureBox1.Location = new System.Drawing.Point(690, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dateOfPurchase
            // 
            this.dateOfPurchase.Location = new System.Drawing.Point(16, 260);
            this.dateOfPurchase.Name = "dateOfPurchase";
            this.dateOfPurchase.Size = new System.Drawing.Size(317, 20);
            this.dateOfPurchase.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "Date Of Purchase";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(365, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Per Unit Price";
            // 
            // textboxCostPrice
            // 
            this.textboxCostPrice.BorderColorFocused = System.Drawing.Color.Blue;
            this.textboxCostPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxCostPrice.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.textboxCostPrice.BorderThickness = 3;
            this.textboxCostPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxCostPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textboxCostPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxCostPrice.isPassword = false;
            this.textboxCostPrice.Location = new System.Drawing.Point(365, 66);
            this.textboxCostPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textboxCostPrice.Name = "textboxCostPrice";
            this.textboxCostPrice.Size = new System.Drawing.Size(322, 40);
            this.textboxCostPrice.TabIndex = 4;
            this.textboxCostPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textboxCostPrice.OnValueChanged += new System.EventHandler(this.textboxCostPrice_OnValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(415, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 25);
            this.label7.TabIndex = 28;
            this.label7.Text = "Total Price:";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.addPurcHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Totlable
            // 
            this.Totlable.AutoSize = true;
            this.Totlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totlable.Location = new System.Drawing.Point(542, 199);
            this.Totlable.Name = "Totlable";
            this.Totlable.Size = new System.Drawing.Size(54, 25);
            this.Totlable.TabIndex = 29;
            this.Totlable.Text = "0.00";
            // 
            // Error1
            // 
            this.Error1.Image = global::Inventory_Management_System.Properties.Resources.attention_filled_50px;
            this.Error1.Location = new System.Drawing.Point(305, 126);
            this.Error1.Name = "Error1";
            this.Error1.Size = new System.Drawing.Size(26, 26);
            this.Error1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Error1.TabIndex = 30;
            this.Error1.TabStop = false;
            this.Error1.Visible = false;
            // 
            // Error2
            // 
            this.Error2.Image = global::Inventory_Management_System.Properties.Resources.attention_filled_50px;
            this.Error2.Location = new System.Drawing.Point(305, 199);
            this.Error2.Name = "Error2";
            this.Error2.Size = new System.Drawing.Size(26, 26);
            this.Error2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Error2.TabIndex = 31;
            this.Error2.TabStop = false;
            this.Error2.Visible = false;
            // 
            // Error3
            // 
            this.Error3.Image = global::Inventory_Management_System.Properties.Resources.attention_filled_50px;
            this.Error3.Location = new System.Drawing.Point(652, 73);
            this.Error3.Name = "Error3";
            this.Error3.Size = new System.Drawing.Size(26, 26);
            this.Error3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Error3.TabIndex = 32;
            this.Error3.TabStop = false;
            this.Error3.Visible = false;
            // 
            // Error4
            // 
            this.Error4.Image = global::Inventory_Management_System.Properties.Resources.attention_filled_50px;
            this.Error4.Location = new System.Drawing.Point(652, 149);
            this.Error4.Name = "Error4";
            this.Error4.Size = new System.Drawing.Size(26, 26);
            this.Error4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Error4.TabIndex = 33;
            this.Error4.TabStop = false;
            this.Error4.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(311, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Add Purchase";
            // 
            // AddPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 315);
            this.Controls.Add(this.Error4);
            this.Controls.Add(this.Error3);
            this.Controls.Add(this.Error2);
            this.Controls.Add(this.Error1);
            this.Controls.Add(this.Totlable);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textboxCostPrice);
            this.Controls.Add(this.dateOfPurchase);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textboxProdQty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxProdName);
            this.Controls.Add(this.btnAddPurchase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboboxSupplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxBarcode);
            this.Controls.Add(this.addPurcHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPurchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPurchase";
            this.Load += new System.EventHandler(this.AddPurchase_Load);
            this.addPurcHeader.ResumeLayout(false);
            this.addPurcHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label5;
        public Bunifu.Framework.UI.BunifuMetroTextbox textboxProdQty;
        public System.Windows.Forms.Label label3;
        public Bunifu.Framework.UI.BunifuMetroTextbox textboxProdName;
        public Bunifu.Framework.UI.BunifuFlatButton btnAddPurchase;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboboxSupplier;
        public System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuMetroTextbox textboxBarcode;
        public System.Windows.Forms.Panel addPurcHeader;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DateTimePicker dateOfPurchase;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label6;
        public Bunifu.Framework.UI.BunifuMetroTextbox textboxCostPrice;
        public System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public System.Windows.Forms.Label Totlable;
        public System.Windows.Forms.PictureBox Error1;
        public System.Windows.Forms.PictureBox Error2;
        public System.Windows.Forms.PictureBox Error3;
        public System.Windows.Forms.PictureBox Error4;
        private System.Windows.Forms.Label label8;
    }
}