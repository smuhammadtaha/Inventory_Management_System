namespace Inventory_Management_System
{
    partial class AddCategory
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
            this.btnAddCat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboboxIsActive = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxCatName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.addCatHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Error = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addCatHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCat
            // 
            this.btnAddCat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.btnAddCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnAddCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCat.BorderRadius = 0;
            this.btnAddCat.ButtonText = "ADD";
            this.btnAddCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCat.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddCat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddCat.Iconimage = null;
            this.btnAddCat.Iconimage_right = null;
            this.btnAddCat.Iconimage_right_Selected = null;
            this.btnAddCat.Iconimage_Selected = null;
            this.btnAddCat.IconMarginLeft = 0;
            this.btnAddCat.IconMarginRight = 0;
            this.btnAddCat.IconRightVisible = true;
            this.btnAddCat.IconRightZoom = 0D;
            this.btnAddCat.IconVisible = true;
            this.btnAddCat.IconZoom = 90D;
            this.btnAddCat.IsTab = false;
            this.btnAddCat.Location = new System.Drawing.Point(15, 189);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnAddCat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(78)))), ((int)(((byte)(96)))));
            this.btnAddCat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddCat.selected = false;
            this.btnAddCat.Size = new System.Drawing.Size(361, 41);
            this.btnAddCat.TabIndex = 11;
            this.btnAddCat.Text = "ADD";
            this.btnAddCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddCat.Textcolor = System.Drawing.Color.White;
            this.btnAddCat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Is Active";
            // 
            // comboboxIsActive
            // 
            this.comboboxIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxIsActive.FormattingEnabled = true;
            this.comboboxIsActive.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboboxIsActive.Location = new System.Drawing.Point(16, 146);
            this.comboboxIsActive.Name = "comboboxIsActive";
            this.comboboxIsActive.Size = new System.Drawing.Size(361, 21);
            this.comboboxIsActive.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Category Name";
            // 
            // textboxCatName
            // 
            this.textboxCatName.BorderColorFocused = System.Drawing.Color.Blue;
            this.textboxCatName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxCatName.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.textboxCatName.BorderThickness = 3;
            this.textboxCatName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxCatName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textboxCatName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxCatName.isPassword = false;
            this.textboxCatName.Location = new System.Drawing.Point(13, 69);
            this.textboxCatName.Margin = new System.Windows.Forms.Padding(4);
            this.textboxCatName.Name = "textboxCatName";
            this.textboxCatName.Size = new System.Drawing.Size(364, 40);
            this.textboxCatName.TabIndex = 7;
            this.textboxCatName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // addCatHeader
            // 
            this.addCatHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(157)))), ((int)(((byte)(242)))));
            this.addCatHeader.Controls.Add(this.label3);
            this.addCatHeader.Controls.Add(this.pictureBox1);
            this.addCatHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.addCatHeader.Location = new System.Drawing.Point(0, 0);
            this.addCatHeader.Name = "addCatHeader";
            this.addCatHeader.Size = new System.Drawing.Size(390, 26);
            this.addCatHeader.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Inventory_Management_System.Properties.Resources.icons8_xbox_x_32px_1;
            this.pictureBox1.Location = new System.Drawing.Point(364, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.addCatHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Error
            // 
            this.Error.Image = global::Inventory_Management_System.Properties.Resources.attention_filled_50px;
            this.Error.Location = new System.Drawing.Point(342, 75);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(26, 26);
            this.Error.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Error.TabIndex = 2;
            this.Error.TabStop = false;
            this.Error.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(134, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Add Category";
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 245);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.btnAddCat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboboxIsActive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxCatName);
            this.Controls.Add(this.addCatHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCategory";
            this.addCatHeader.ResumeLayout(false);
            this.addCatHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuFlatButton btnAddCat;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboboxIsActive;
        public System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuMetroTextbox textboxCatName;
        public System.Windows.Forms.Panel addCatHeader;
        public System.Windows.Forms.PictureBox pictureBox1;
        public Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public System.Windows.Forms.PictureBox Error;
        private System.Windows.Forms.Label label3;
    }
}