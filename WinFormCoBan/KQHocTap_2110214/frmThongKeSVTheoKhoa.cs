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
    public partial class ThongKeSVTheoKhoa : Form
    {
        string ChuoiKN = "";
        SqlConnection KetNoi;
        SqlDataAdapter boDocGhi;
        DataSet duLieu;
 
        public ThongKeSVTheoKhoa()
        {
            InitializeComponent();
        }

        private void sinhVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sinhVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDBDataSet);

        }

        private void ThongKeSVTheoKhoa_Load(object sender, EventArgs e)
        {
        

            ChuoiKN = global::KQHocTap_2110214.Properties.Settings.Default.StudentDBConnectionString;

            KetNoi = new SqlConnection(ChuoiKN);
            string sqlSelect = "select * from Khoa";

            boDocGhi = new SqlDataAdapter(sqlSelect, KetNoi);
            duLieu = new DataSet();
            boDocGhi.Fill(duLieu);

         
            // Thiết lập ComboBox MaSo
            cbxMaKhoa.DataSource = duLieu.Tables[0];
            cbxMaKhoa.DisplayMember = "MaKhoa";


            // Thiết lập ComboBox HoTen
            cxbTenKhoa.DataSource = duLieu.Tables[0];
            cxbTenKhoa.DisplayMember = "TenKhoa";



        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string maso = cbxMaKhoa.Text;
            string sql = string.Format("select * from SinhVien where MaKhoa = '{0}'", maso);

            boDocGhi = new SqlDataAdapter(sql,KetNoi);
            DataTable dtKhoa = new DataTable();
            boDocGhi.Fill(dtKhoa);

            dtgThongKe.DataSource = dtKhoa;
    

            
        }
       

        private void cxbTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        
        }
    }
}
