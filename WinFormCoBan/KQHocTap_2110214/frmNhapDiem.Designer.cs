namespace KQHocTap_2110214
{
    partial class NhapDiem
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
            System.Windows.Forms.Label maSoLabel;
            System.Windows.Forms.Label maMHLabel;
            System.Windows.Forms.Label hoTenLabel;
            System.Windows.Forms.Label tenMHLabel;
            System.Windows.Forms.Label diemLabel;
            this.maSoComboBox = new System.Windows.Forms.ComboBox();
            this.maMHComboBox = new System.Windows.Forms.ComboBox();
            this.hoTenComboBox = new System.Windows.Forms.ComboBox();
            this.tenMHComboBox = new System.Windows.Forms.ComboBox();
            this.diemTextBox = new System.Windows.Forms.TextBox();
            this.btnNhapDiem = new System.Windows.Forms.Button();
            maSoLabel = new System.Windows.Forms.Label();
            maMHLabel = new System.Windows.Forms.Label();
            hoTenLabel = new System.Windows.Forms.Label();
            tenMHLabel = new System.Windows.Forms.Label();
            diemLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maSoLabel
            // 
            maSoLabel.AutoSize = true;
            maSoLabel.Location = new System.Drawing.Point(51, 86);
            maSoLabel.Name = "maSoLabel";
            maSoLabel.Size = new System.Drawing.Size(41, 13);
            maSoLabel.TabIndex = 1;
            maSoLabel.Text = "Ma So:";
            // 
            // maSoComboBox
            // 
            this.maSoComboBox.FormattingEnabled = true;
            this.maSoComboBox.Location = new System.Drawing.Point(98, 83);
            this.maSoComboBox.Name = "maSoComboBox";
            this.maSoComboBox.Size = new System.Drawing.Size(250, 21);
            this.maSoComboBox.TabIndex = 2;
            // 
            // maMHLabel
            // 
            maMHLabel.AutoSize = true;
            maMHLabel.Location = new System.Drawing.Point(46, 196);
            maMHLabel.Name = "maMHLabel";
            maMHLabel.Size = new System.Drawing.Size(45, 13);
            maMHLabel.TabIndex = 5;
            maMHLabel.Text = "Ma MH:";
            // 
            // maMHComboBox
            // 
            this.maMHComboBox.FormattingEnabled = true;
            this.maMHComboBox.Location = new System.Drawing.Point(97, 193);
            this.maMHComboBox.Name = "maMHComboBox";
            this.maMHComboBox.Size = new System.Drawing.Size(251, 21);
            this.maMHComboBox.TabIndex = 6;
            // 
            // hoTenLabel
            // 
            hoTenLabel.AutoSize = true;
            hoTenLabel.Location = new System.Drawing.Point(46, 145);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(46, 13);
            hoTenLabel.TabIndex = 6;
            hoTenLabel.Text = "Ho Ten:";
            // 
            // hoTenComboBox
            // 
            this.hoTenComboBox.FormattingEnabled = true;
            this.hoTenComboBox.Location = new System.Drawing.Point(98, 142);
            this.hoTenComboBox.Name = "hoTenComboBox";
            this.hoTenComboBox.Size = new System.Drawing.Size(250, 21);
            this.hoTenComboBox.TabIndex = 7;
            // 
            // tenMHLabel
            // 
            tenMHLabel.AutoSize = true;
            tenMHLabel.Location = new System.Drawing.Point(43, 239);
            tenMHLabel.Name = "tenMHLabel";
            tenMHLabel.Size = new System.Drawing.Size(49, 13);
            tenMHLabel.TabIndex = 7;
            tenMHLabel.Text = "Ten MH:";
            // 
            // tenMHComboBox
            // 
            this.tenMHComboBox.FormattingEnabled = true;
            this.tenMHComboBox.Location = new System.Drawing.Point(98, 236);
            this.tenMHComboBox.Name = "tenMHComboBox";
            this.tenMHComboBox.Size = new System.Drawing.Size(250, 21);
            this.tenMHComboBox.TabIndex = 8;
            // 
            // diemLabel
            // 
            diemLabel.AutoSize = true;
            diemLabel.Location = new System.Drawing.Point(58, 289);
            diemLabel.Name = "diemLabel";
            diemLabel.Size = new System.Drawing.Size(34, 13);
            diemLabel.TabIndex = 9;
            diemLabel.Text = "Diem:";
            // 
            // diemTextBox
            // 
            this.diemTextBox.Location = new System.Drawing.Point(98, 286);
            this.diemTextBox.Name = "diemTextBox";
            this.diemTextBox.Size = new System.Drawing.Size(250, 20);
            this.diemTextBox.TabIndex = 10;
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Location = new System.Drawing.Point(436, 302);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(125, 82);
            this.btnNhapDiem.TabIndex = 11;
            this.btnNhapDiem.Text = "Nhập điểm";
            this.btnNhapDiem.UseVisualStyleBackColor = true;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // NhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNhapDiem);
            this.Controls.Add(diemLabel);
            this.Controls.Add(this.diemTextBox);
            this.Controls.Add(tenMHLabel);
            this.Controls.Add(this.tenMHComboBox);
            this.Controls.Add(hoTenLabel);
            this.Controls.Add(this.hoTenComboBox);
            this.Controls.Add(maMHLabel);
            this.Controls.Add(this.maMHComboBox);
            this.Controls.Add(maSoLabel);
            this.Controls.Add(this.maSoComboBox);
            this.Name = "NhapDiem";
            this.Text = "Nhập điểm";
            this.Load += new System.EventHandler(this.NhapDiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox maSoComboBox;
        private System.Windows.Forms.ComboBox maMHComboBox;
        private System.Windows.Forms.ComboBox hoTenComboBox;
        private System.Windows.Forms.ComboBox tenMHComboBox;
        private System.Windows.Forms.TextBox diemTextBox;
        private System.Windows.Forms.Button btnNhapDiem;
    }
}