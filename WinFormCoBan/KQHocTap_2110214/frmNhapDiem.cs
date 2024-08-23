using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KQHocTap_2110214
{
    public partial class NhapDiem : Form
    {

        string ChuoiKN = "";
        SqlConnection KetNoi;
        SqlDataAdapter boDocGhi;
        DataSet duLieu;
        public NhapDiem()
        {
            InitializeComponent();
        }

        private void sinhVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.sinhVienBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.studentDBDataSet);

        }

        private void NhapDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet.KetQua' table. You can move, or remove it, as needed.
            /*  this.ketQuaTableAdapter.Fill(this.studentDBDataSet.KetQua);
              // TODO: This line of code loads data into the 'studentDBDataSet.Mon' table. You can move, or remove it, as needed.
              this.monTableAdapter.Fill(this.studentDBDataSet.Mon);
              // TODO: This line of code loads data into the 'studentDBDataSet.SinhVien' table. You can move, or remove it, as needed.
              this.sinhVienTableAdapter.Fill(this.studentDBDataSet.SinhVien);
            */

            ChuoiKN = global::KQHocTap_2110214.Properties.Settings.Default.StudentDBConnectionString;
            KetNoi = new SqlConnection(ChuoiKN);

            string sqlSelect = "select * from SinhVien; select * from Mon";
            boDocGhi = new SqlDataAdapter(sqlSelect, KetNoi);

            duLieu = new DataSet("QLSV");
            boDocGhi.Fill(duLieu);

            maSoComboBox.DataSource = duLieu.Tables[0];
            maSoComboBox.DisplayMember = "MaSo";

            hoTenComboBox.DataSource = duLieu.Tables[0];
            hoTenComboBox.DisplayMember = "HoTen";

            maMHComboBox.DataSource = duLieu.Tables[1];
            maMHComboBox.DisplayMember = "MaMH";

            tenMHComboBox.DataSource = duLieu.Tables[1];
            tenMHComboBox.DisplayMember = "TenMH";

        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            string sql = string.Format("insert into KetQua values({0}, '{1}', {2})",maSoComboBox.Text,maMHComboBox.Text, diemTextBox.Text);

            SqlCommand boLenh = new SqlCommand(sql, KetNoi);
            KetNoi.Open();
            boLenh.ExecuteNonQuery();
            KetNoi.Close();

            // Show a success message
            MessageBox.Show("nhập điểm thành công");

        }
    }
}
