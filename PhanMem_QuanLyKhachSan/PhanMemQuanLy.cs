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
    public partial class PhanMemQuanLy : Form
    {
        public PhanMemQuanLy()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhanVien NV = new NhanVien();
            this.Hide();
            NV.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KhachHang KH = new KhachHang();
            this.Hide();
            KH.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Phong P = new Phong();
            this.Hide();
            P.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DichVu DV = new DichVu();
            this.Hide();
            DV.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HoaDon HD = new HoaDon();
            this.Hide();
            HD.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TaiKhoan TK = new TaiKhoan();
            this.Hide();
            TK.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
