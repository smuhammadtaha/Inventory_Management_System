namespace Inventory_Management_System
{
    partial class Deleted_Stock
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
            this.datagridviewDeletedItems = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.p_idGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usr_idGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pro_idGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pro_QuanGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dlt_dateGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewDeletedItems)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridviewDeletedItems
            // 
            this.datagridviewDeletedItems.AllowUserToAddRows = false;
            this.datagridviewDeletedItems.AllowUserToDeleteRows = false;
            this.datagridviewDeletedItems.AllowUserToResizeColumns = false;
            this.datagridviewDeletedItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagridviewDeletedItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridviewDeletedItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridviewDeletedItems.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datagridviewDeletedItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridviewDeletedItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridviewDeletedItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridviewDeletedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridviewDeletedItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p_idGV,
            this.Usr_idGV,
            this.pro_idGV,
            this.Pro_QuanGV,
            this.Dlt_dateGV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridviewDeletedItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridviewDeletedItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridviewDeletedItems.DoubleBuffered = true;
            this.datagridviewDeletedItems.EnableHeadersVisualStyles = false;
            this.datagridviewDeletedItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(79)))), ((int)(((byte)(97)))));
            this.datagridviewDeletedItems.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(58)))), ((int)(((byte)(78)))));
            this.datagridviewDeletedItems.HeaderForeColor = System.Drawing.Color.White;
            this.datagridviewDeletedItems.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.datagridviewDeletedItems.Location = new System.Drawing.Point(0, 0);
            this.datagridviewDeletedItems.Name = "datagridviewDeletedItems";
            this.datagridviewDeletedItems.ReadOnly = true;
            this.datagridviewDeletedItems.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridviewDeletedItems.RowHeadersVisible = false;
            this.datagridviewDeletedItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridviewDeletedItems.Size = new System.Drawing.Size(804, 580);
            this.datagridviewDeletedItems.TabIndex = 2;
            // 
            // p_idGV
            // 
            this.p_idGV.HeaderText = "Purchase ID";
            this.p_idGV.Name = "p_idGV";
            this.p_idGV.ReadOnly = true;
            // 
            // Usr_idGV
            // 
            this.Usr_idGV.HeaderText = "User ID";
            this.Usr_idGV.Name = "Usr_idGV";
            this.Usr_idGV.ReadOnly = true;
            // 
            // pro_idGV
            // 
            this.pro_idGV.HeaderText = "Product ID";
            this.pro_idGV.Name = "pro_idGV";
            this.pro_idGV.ReadOnly = true;
            // 
            // Pro_QuanGV
            // 
            this.Pro_QuanGV.HeaderText = "Product Quantity";
            this.Pro_QuanGV.Name = "Pro_QuanGV";
            this.Pro_QuanGV.ReadOnly = true;
            // 
            // Dlt_dateGV
            // 
            this.Dlt_dateGV.HeaderText = "Delete Date";
            this.Dlt_dateGV.Name = "Dlt_dateGV";
            this.Dlt_dateGV.ReadOnly = true;
            // 
            // Deleted_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 580);
            this.Controls.Add(this.datagridviewDeletedItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deleted_Stock";
            this.Text = "Deleted_Stock";
            this.Load += new System.EventHandler(this.Deleted_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridviewDeletedItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.Framework.UI.BunifuCustomDataGrid datagridviewDeletedItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_idGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usr_idGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn pro_idGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pro_QuanGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dlt_dateGV;
    }
}