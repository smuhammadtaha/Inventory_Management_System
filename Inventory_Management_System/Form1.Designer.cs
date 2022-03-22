namespace Inventory_Management_System
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textboxPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.errortextUsername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errortextPassword = new System.Windows.Forms.Label();
            this.imgHide = new System.Windows.Forms.PictureBox();
            this.imgShow = new System.Windows.Forms.PictureBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pictureBox1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventory_Management_System.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(-123, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(881, 445);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label1.Location = new System.Drawing.Point(460, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label2.Location = new System.Drawing.Point(461, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // textboxUsername
            // 
            this.textboxUsername.BackColor = System.Drawing.Color.White;
            this.textboxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.textboxUsername.HintForeColor = System.Drawing.Color.Empty;
            this.textboxUsername.HintText = "Enter Username";
            this.textboxUsername.isPassword = false;
            this.textboxUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.textboxUsername.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.textboxUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.textboxUsername.LineThickness = 2;
            this.textboxUsername.Location = new System.Drawing.Point(463, 179);
            this.textboxUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textboxUsername.Name = "textboxUsername";
            this.textboxUsername.Size = new System.Drawing.Size(171, 21);
            this.textboxUsername.TabIndex = 2;
            this.textboxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textboxUsername.OnValueChanged += new System.EventHandler(this.textboxUsername_OnValueChanged);
            this.textboxUsername.Validating += new System.ComponentModel.CancelEventHandler(this.textboxUsername_Validating);
            // 
            // textboxPassword
            // 
            this.textboxPassword.BackColor = System.Drawing.Color.White;
            this.textboxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.textboxPassword.HintForeColor = System.Drawing.Color.Empty;
            this.textboxPassword.HintText = "";
            this.textboxPassword.isPassword = true;
            this.textboxPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.textboxPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.textboxPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201)))));
            this.textboxPassword.LineThickness = 2;
            this.textboxPassword.Location = new System.Drawing.Point(463, 234);
            this.textboxPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.Size = new System.Drawing.Size(171, 21);
            this.textboxPassword.TabIndex = 3;
            this.textboxPassword.Text = "Password";
            this.textboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textboxPassword.OnValueChanged += new System.EventHandler(this.textboxPassword_OnValueChanged);
            this.textboxPassword.Click += new System.EventHandler(this.textboxPassword_Click);
            this.textboxPassword.Enter += new System.EventHandler(this.textboxPassword_Enter);
            this.textboxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textboxPassword_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label3.Location = new System.Drawing.Point(460, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(463, 140);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(176, 21);
            this.comboBoxRole.TabIndex = 1;
            // 
            // errortextUsername
            // 
            this.errortextUsername.AutoSize = true;
            this.errortextUsername.BackColor = System.Drawing.Color.White;
            this.errortextUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errortextUsername.ForeColor = System.Drawing.Color.Red;
            this.errortextUsername.Location = new System.Drawing.Point(468, 203);
            this.errortextUsername.Name = "errortextUsername";
            this.errortextUsername.Size = new System.Drawing.Size(93, 13);
            this.errortextUsername.TabIndex = 11;
            this.errortextUsername.Text = "*Invalid Username";
            this.errortextUsername.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label4.Location = new System.Drawing.Point(460, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Role";
            // 
            // errortextPassword
            // 
            this.errortextPassword.AutoSize = true;
            this.errortextPassword.BackColor = System.Drawing.Color.White;
            this.errortextPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errortextPassword.ForeColor = System.Drawing.Color.Red;
            this.errortextPassword.Location = new System.Drawing.Point(468, 258);
            this.errortextPassword.Name = "errortextPassword";
            this.errortextPassword.Size = new System.Drawing.Size(93, 13);
            this.errortextPassword.TabIndex = 14;
            this.errortextPassword.Text = "*Invalid Username";
            this.errortextPassword.Visible = false;
            // 
            // imgHide
            // 
            this.imgHide.BackColor = System.Drawing.Color.White;
            this.imgHide.Image = global::Inventory_Management_System.Properties.Resources.icons8_invisible_32px_1;
            this.imgHide.Location = new System.Drawing.Point(616, 238);
            this.imgHide.Name = "imgHide";
            this.imgHide.Size = new System.Drawing.Size(24, 17);
            this.imgHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgHide.TabIndex = 9;
            this.imgHide.TabStop = false;
            this.imgHide.Click += new System.EventHandler(this.imgShow_Click);
            // 
            // imgShow
            // 
            this.imgShow.BackColor = System.Drawing.Color.White;
            this.imgShow.Image = global::Inventory_Management_System.Properties.Resources.icons8_visible_32px_5;
            this.imgShow.Location = new System.Drawing.Point(616, 238);
            this.imgShow.Name = "imgShow";
            this.imgShow.Size = new System.Drawing.Size(24, 17);
            this.imgShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgShow.TabIndex = 8;
            this.imgShow.TabStop = false;
            this.imgShow.Click += new System.EventHandler(this.ingHide_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(69)))), ((int)(((byte)(252)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(69)))), ((int)(((byte)(252)))));
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Login";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(69)))), ((int)(((byte)(252)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(69)))), ((int)(((byte)(252)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(493, 284);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(111, 45);
            this.bunifuThinButton21.TabIndex = 4;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            this.bunifuThinButton21.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuThinButton21_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(119)))), ((int)(((byte)(236)))));
            this.pictureBox2.Image = global::Inventory_Management_System.Properties.Resources.icons8_xbox_x_32px_1;
            this.pictureBox2.Location = new System.Drawing.Point(671, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 439);
            this.Controls.Add(this.errortextPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.errortextUsername);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.imgHide);
            this.Controls.Add(this.imgShow);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textboxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textboxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox imgShow;
        private System.Windows.Forms.PictureBox imgHide;
        private System.Windows.Forms.Label errortextUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label errortextPassword;
        public System.Windows.Forms.ComboBox comboBoxRole;
    }
}

