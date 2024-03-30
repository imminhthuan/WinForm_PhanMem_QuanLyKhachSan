using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMem_QuanLyKhachSan
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        private ConnectData Con = new ConnectData();
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Conect_QLKS();
                DataTable Data_DN = new DataTable();
                Data_DN = Con.LayDL("SELECT * FROM TaiKhoanDangNhap WHERE TenDangNhap = '" + txtTaiKhoanDangNhap.Text + "'AND MatKhau = '" + txtMatKhau.Text + "'");
                if (Data_DN.Rows.Count > 0)
                {                  
                    PhanMemQuanLy PMQL = new PhanMemQuanLy();
                    this.Hide();
                    PMQL.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Không Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy DK = new DangKy();
            this.Hide();
            DK.ShowDialog();
            this.Show();
        }
    }
}
