namespace KQHocTap_2110214
{
    partial class XemDiem
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
            this.studentDBDataSet = new KQHocTap_2110214.StudentDBDataSet();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter = new KQHocTap_2110214.StudentDBDataSetTableAdapters.SinhVienTableAdapter();
            this.tableAdapterManager = new KQHocTap_2110214.StudentDBDataSetTableAdapters.TableAdapterManager();
            this.ketQuaTableAdapter = new KQHocTap_2110214.StudentDBDataSetTableAdapters.KetQuaTableAdapter();
            this.monTableAdapter = new KQHocTap_2110214.StudentDBDataSetTableAdapters.MonTableAdapter();
            this.monBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketQuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxMaSo = new System.Windows.Forms.ComboBox();
            this.cbxHoTen = new System.Windows.Forms.ComboBox();
            this.btnXemdiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgXemDiem = new System.Windows.Forms.DataGridView();
            this.cbxMaKhoa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgXemDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // studentDBDataSet
            // 
            this.studentDBDataSet.DataSetName = "StudentDBDataSet";
            this.studentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.studentDBDataSet;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KetQuaTableAdapter = this.ketQuaTableAdapter;
            this.tableAdapterManager.KhoaTableAdapter = null;
            this.tableAdapterManager.MonTableAdapter = this.monTableAdapter;
            this.tableAdapterManager.SinhVienTableAdapter = this.sinhVienTableAdapter;
            this.tableAdapterManager.UpdateOrder = KQHocTap_2110214.StudentDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ketQuaTableAdapter
            // 
            this.ketQuaTableAdapter.ClearBeforeFill = true;
            // 
            // monTableAdapter
            // 
            this.monTableAdapter.ClearBeforeFill = true;
            // 
            // monBindingSource
            // 
            this.monBindingSource.DataMember = "Mon";
            this.monBindingSource.DataSource = this.studentDBDataSet;
            // 
            // ketQuaBindingSource
            // 
            this.ketQuaBindingSource.DataMember = "FK_KetQua_Mon";
            this.ketQuaBindingSource.DataSource = this.monBindingSource;
            // 
            // studentDBDataSetBindingSource
            // 
            this.studentDBDataSetBindingSource.DataSource = this.studentDBDataSet;
            this.studentDBDataSetBindingSource.Position = 0;
            // 
            // cbxMaSo
            // 
            this.cbxMaSo.FormattingEnabled = true;
            this.cbxMaSo.Location = new System.Drawing.Point(130, 32);
            this.cbxMaSo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxMaSo.Name = "cbxMaSo";
            this.cbxMaSo.Size = new System.Drawing.Size(255, 21);
            this.cbxMaSo.TabIndex = 0;
            this.cbxMaSo.SelectedIndexChanged += new System.EventHandler(this.cbxMaSo_SelectedIndexChanged);
            // 
            // cbxHoTen
            // 
            this.cbxHoTen.FormattingEnabled = true;
            this.cbxHoTen.Location = new System.Drawing.Point(130, 72);
            this.cbxHoTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxHoTen.Name = "cbxHoTen";
            this.cbxHoTen.Size = new System.Drawing.Size(255, 21);
            this.cbxHoTen.TabIndex = 1;
            this.cbxHoTen.SelectedIndexChanged += new System.EventHandler(this.cbxHoTen_SelectedIndexChanged);
            // 
            // btnXemdiem
            // 
            this.btnXemdiem.Location = new System.Drawing.Point(482, 63);
            this.btnXemdiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXemdiem.Name = "btnXemdiem";
            this.btnXemdiem.Size = new System.Drawing.Size(133, 66);
            this.btnXemdiem.TabIndex = 3;
            this.btnXemdiem.Text = "Xem điểm";
            this.btnXemdiem.UseVisualStyleBackColor = true;
            this.btnXemdiem.Click += new System.EventHandler(this.btnXemdiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "MÃ SỐ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Khoa";
            // 
            // dtgXemDiem
            // 
            this.dtgXemDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgXemDiem.Location = new System.Drawing.Point(98, 197);
            this.dtgXemDiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgXemDiem.Name = "dtgXemDiem";
            this.dtgXemDiem.RowHeadersWidth = 82;
            this.dtgXemDiem.RowTemplate.Height = 33;
            this.dtgXemDiem.Size = new System.Drawing.Size(684, 106);
            this.dtgXemDiem.TabIndex = 7;
            this.dtgXemDiem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cbxMaKhoa
            // 
            this.cbxMaKhoa.FormattingEnabled = true;
            this.cbxMaKhoa.Location = new System.Drawing.Point(130, 119);
            this.cbxMaKhoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxMaKhoa.Name = "cbxMaKhoa";
            this.cbxMaKhoa.Size = new System.Drawing.Size(255, 21);
            this.cbxMaKhoa.TabIndex = 8;
            // 
            // XemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 552);
            this.Controls.Add(this.cbxMaKhoa);
            this.Controls.Add(this.dtgXemDiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXemdiem);
            this.Controls.Add(this.cbxHoTen);
            this.Controls.Add(this.cbxMaSo);
            this.Name = "XemDiem";
            this.Text = "Xem điểm";
            this.Load += new System.EventHandler(this.XemDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgXemDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentDBDataSet studentDBDataSet;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private StudentDBDataSetTableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private StudentDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private StudentDBDataSetTableAdapters.MonTableAdapter monTableAdapter;
        private System.Windows.Forms.BindingSource monBindingSource;
        private StudentDBDataSetTableAdapters.KetQuaTableAdapter ketQuaTableAdapter;
        private System.Windows.Forms.BindingSource ketQuaBindingSource;
        private System.Windows.Forms.BindingSource studentDBDataSetBindingSource;
        private System.Windows.Forms.ComboBox cbxMaSo;
        private System.Windows.Forms.ComboBox cbxHoTen;
        private System.Windows.Forms.Button btnXemdiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgXemDiem;
        private System.Windows.Forms.ComboBox cbxMaKhoa;
    }
}