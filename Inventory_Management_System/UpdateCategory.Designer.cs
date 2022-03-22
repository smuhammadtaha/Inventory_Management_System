namespace Inventory_Management_System
{
    partial class UpdateCategory
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
            this.btnUpdateCat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboboxIsActive = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxCatName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.updateCatHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Error1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.updateCatHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateCat
            // 
            this.btnUpdateCat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.btnUpdateCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnUpdateCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateCat.BorderRadius = 0;
            this.btnUpdateCat.ButtonText = "UPDATE";
            this.btnUpdateCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateCat.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdateCat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdateCat.Iconimage = null;
            this.btnUpdateCat.Iconimage_right = null;
            this.btnUpdateCat.Iconimage_right_Selected = null;
            this.btnUpdateCat.Iconimage_Selected = null;
            this.btnUpdateCat.IconMarginLeft = 0;
            this.btnUpdateCat.IconMarginRight = 0;
            this.btnUpdateCat.IconRightVisible = true;
            this.btnUpdateCat.IconRightZoom = 0D;
            this.btnUpdateCat.IconVisible = true;
            this.btnUpdateCat.IconZoom = 90D;
            this.btnUpdateCat.IsTab = false;
            this.btnUpdateCat.Location = new System.Drawing.Point(15, 187);
            this.btnUpdateCat.Name = "btnUpdateCat";
            this.btnUpdateCat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnUpdateCat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.btnUpdateCat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdateCat.selected = false;
            this.btnUpdateCat.Size = new System.Drawing.Size(361, 41);
            this.btnUpdateCat.TabIndex = 17;
            this.btnUpdateCat.Text = "UPDATE";
            this.btnUpdateCat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdateCat.Textcolor = System.Drawing.Color.White;
            this.btnUpdateCat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCat.Click += new System.EventHandler(this.btnUpdateCat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Is Active";
            // 
            // comboboxIsActive
            // 
            this.comboboxIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxIsActive.FormattingEnabled = true;
            this.comboboxIsActive.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboboxIsActive.Location = new System.Drawing.Point(16, 144);
            this.comboboxIsActive.Name = "comboboxIsActive";
            this.comboboxIsActive.Size = new System.Drawing.Size(361, 21);
            this.comboboxIsActive.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 14;
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
            this.textboxCatName.Location = new System.Drawing.Point(13, 67);
            this.textboxCatName.Margin = new System.Windows.Forms.Padding(4);
            this.textboxCatName.Name = "textboxCatName";
            this.textboxCatName.Size = new System.Drawing.Size(364, 40);
            this.textboxCatName.TabIndex = 13;
            this.textboxCatName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // updateCatHeader
            // 
            this.updateCatHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(240)))));
            this.updateCatHeader.Controls.Add(this.label3);
            this.updateCatHeader.Controls.Add(this.pictureBox1);
            this.updateCatHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.updateCatHeader.Location = new System.Drawing.Point(0, 0);
            this.updateCatHeader.Name = "updateCatHeader";
            this.updateCatHeader.Size = new System.Drawing.Size(390, 26);
            this.updateCatHeader.TabIndex = 12;
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
            this.bunifuDragControl1.TargetControl = this.updateCatHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Error1
            // 
            this.Error1.Image = global::Inventory_Management_System.Properties.Resources.attention_filled_50px;
            this.Error1.Location = new System.Drawing.Point(343, 75);
            this.Error1.Name = "Error1";
            this.Error1.Size = new System.Drawing.Size(26, 26);
            this.Error1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Error1.TabIndex = 31;
            this.Error1.TabStop = false;
            this.Error1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(148, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Update Category";
            // 
            // UpdateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 241);
            this.Controls.Add(this.Error1);
            this.Controls.Add(this.btnUpdateCat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboboxIsActive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxCatName);
            this.Controls.Add(this.updateCatHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateCategory";
            this.updateCatHeader.ResumeLayout(false);
            this.updateCatHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuFlatButton btnUpdateCat;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboboxIsActive;
        public System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuMetroTextbox textboxCatName;
        public System.Windows.Forms.Panel updateCatHeader;
        public System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        public System.Windows.Forms.PictureBox Error1;
        private System.Windows.Forms.Label label3;
    }
}