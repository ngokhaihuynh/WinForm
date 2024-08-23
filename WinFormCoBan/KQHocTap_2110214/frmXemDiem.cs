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
    public partial class XemDiem : Form
    {
        string ChuoiKN = "";
        SqlConnection KetNoi;
        SqlDataAdapter boDocGhi;
        DataSet duLieu;
        DataTable tblXemDiem;

        public XemDiem()
        {
            InitializeComponent();
        }

        private void sinhVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sinhVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDBDataSet);

        }

        private void XemDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet.KetQua' table. You can move, or remove it, as needed.
            /* this.ketQuaTableAdapter.Fill(this.studentDBDataSet.KetQua);
             // TODO: This line of code loads data into the 'studentDBDataSet.Mon' table. You can move, or remove it, as needed.
             this.monTableAdapter.Fill(this.studentDBDataSet.Mon);
             // TODO: This line of code loads data into the 'studentDBDataSet.SinhVien' table. You can move, or remove it, as needed.
             this.sinhVienTableAdapter.Fill(this.studentDBDataSet.SinhVien);*/

            ChuoiKN = global::KQHocTap_2110214.Properties.Settings.Default.StudentDBConnectionString;

            KetNoi = new SqlConnection(ChuoiKN);
            string sqlSelect = "select * from SinhVien; select * from Mon";


            boDocGhi = new SqlDataAdapter(sqlSelect, KetNoi);
            duLieu = new DataSet();
            boDocGhi.Fill(duLieu);

           

            // Thiết lập ComboBox MaSo
            cbxMaSo.DataSource = duLieu.Tables[0];
            cbxMaSo.DisplayMember = "MaSo";


            // Thiết lập ComboBox HoTen
            cbxHoTen.DataSource = duLieu.Tables[0];
            cbxHoTen.DisplayMember = "HoTen";


            cbxMaKhoa.DataSource = duLieu.Tables[0];
            cbxMaKhoa.DisplayMember = "MaKhoa";
            // Load thông tin khoa khi form được tải

        }




        private void maKhoaTextBox_TextChanged(object sender, EventArgs e)
        {


        }


        private void cbxMaSo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtKhoa_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnXemdiem_Click(object sender, EventArgs e)
        {
            string maso = cbxMaSo.Text;
            string sql = string.Format("select TenMH,Diem from Mon, KetQua where MaSo = '{0}' and Mon.MaMH = KetQua.MaMH", maso);

            boDocGhi = new SqlDataAdapter(sql, KetNoi);
            DataTable dtDiem = new DataTable();
            boDocGhi.Fill(dtDiem);

            dtgXemDiem.DataSource = dtDiem;


        }






        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
