using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMem_QuanLyKhachSan
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        private ConnectData Conn = new ConnectData();

        private void Thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangKyTaiKhoan_Click(object sender, EventArgs e)
        {          
            Conn.Conect_QLKS();
            DataTable Data_Tk = Conn.LayDL("select * from TaiKhoanDangNhap where TenDangNhap ='"+txtTaiKhoanDangNhap.Text+"'");

            if (string.IsNullOrEmpty(txtTaiKhoanDangNhap.Text) || string.IsNullOrEmpty(txtMatKhau.Text) || string.IsNullOrEmpty(txtNhapLaiMatKhau.Text))
            {
                MessageBox.Show("Bạn Chưa Điền Đầy Đủ Thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtTaiKhoanDangNhap.Text.Length <= 10 )
            {
                MessageBox.Show("Tài Khoản này Không đủ độ dài", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Data_Tk.Rows.Count == 1)
                MessageBox.Show("Tài Khoản này đã được đăng ký!...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtMatKhau.Text.Length < 8 || txtMatKhau.Text != txtNhapLaiMatKhau.Text)
                MessageBox.Show("Mật Khẩu Không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Conn.CapNhatDL("insert into TaiKhoanDangNhap Values('" + txtTaiKhoanDangNhap.Text + "','" + txtMatKhau.Text + "')");
                MessageBox.Show("đăng ký thành công", "Thông Báo");
                this.Hide();
                DangNhap dn = new DangNhap();
                dn.Show();
            }
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            btnDangKyTaiKhoan.BackColor = Color.FromArgb(0, Color.Tan);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
