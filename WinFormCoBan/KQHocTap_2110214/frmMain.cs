using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KQHocTap_2110214
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if(f.Name == "SinhVien")
                {
                    f.Activate();
                    return;
                }
            }

            SinhVien fsv = new SinhVien(); 
            fsv.MdiParent = this;
            fsv.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "Khoa")
                {
                    f.Activate();
                    return;
                }
            }

            Khoa fk = new Khoa();
            fk.MdiParent = this;
            fk.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "MonHoc")
                {
                    f.Activate();
                    return;
                }
            }

            MonHoc fmh = new MonHoc();
            fmh.MdiParent = this;
            fmh.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "NhapDiem")
                {
                    f.Activate();
                    return;
                }
            }

            NhapDiem fnd = new NhapDiem();
            fnd.MdiParent = this;
            fnd.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "XemDiem")
                {
                    f.Activate();
                    return;
                }
            }

            XemDiem fnd = new XemDiem();
            fnd.MdiParent = this;
            fnd.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == "ThongKeSVTheoKhoa")
                {
                    f.Activate();
                    return;
                }
            }

            ThongKeSVTheoKhoa ftksv = new ThongKeSVTheoKhoa();
            ftksv.MdiParent = this;
            ftksv.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "Xác nhận",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Kiểm tra xem người dùng đã chọn Yes hay No
            if (result == DialogResult.Yes)
            {
                // Nếu người dùng chọn Yes, đóng form
                this.Close();
            }
            // Nếu người dùng chọn No, không làm gì cả, chương trình vẫn tiếp tục chạy
        }

    }
}
