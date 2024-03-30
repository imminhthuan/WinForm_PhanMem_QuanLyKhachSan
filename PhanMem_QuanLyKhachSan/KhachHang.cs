using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PhanMem_QuanLyKhachSan
{
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        private CL_KhachHang cl_KH = new CL_KhachHang();
        private DichVu DV = new DichVu();
        private DataTable Data_Table = new DataTable();
        private Phong PH = new Phong();

        private void KhachHang_Load(object sender, EventArgs e)
        {
            cl_KH.Conect_QLKS();
            Data_Table = cl_KH.LayDL("select * from KhachHang");
            DV.DoDL_VaoDV(Data_Table, dataGridView1);
            Data_Table = cl_KH.LayDL("select * from Phong");
            PH.DoDL_VaoCB(Data_Table, cbMaPhong);
            Data_Table = cl_KH.LayDL("select * from Phong");
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int dong_ht = dataGridView1.CurrentRow.Index;
            if(dong_ht > dataGridView1.Rows.Count - 2)
                return;
            else
            {
                txtMaKH.Text = dataGridView1.Rows[dong_ht].Cells[1].Value.ToString();
                txtTenKH.Text = dataGridView1.Rows[dong_ht].Cells[2].Value.ToString();
                cbMaPhong.Text = dataGridView1.Rows[dong_ht].Cells[3].Value.ToString();
                txtCMND.Text = dataGridView1.Rows[dong_ht].Cells[4].Value.ToString();
                txtQuocTich.Text = dataGridView1.Rows[dong_ht].Cells[5].Value.ToString();
                txtGioiTinh.Text = dataGridView1.Rows[dong_ht].Cells[6].Value.ToString();
                txtNgaySinh.Text = dataGridView1.Rows[dong_ht].Cells[7].Value.ToString();
                txtSDT.Text = dataGridView1.Rows[dong_ht].Cells[8].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Data_Table = cl_KH.LayDL("SELECT * FROM KhachHang WHERE MaKH= '" + txtMaKH.Text + "'");
            if(Data_Table.Rows.Count > 0)
            {
                MessageBox.Show("khách hàng này đã có trong danh sách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKH.Focus();
            }
            else
            {
                DataTable tbl_HD = new DataTable();
                cl_KH = new CL_KhachHang(txtMaKH.Text, txtTenKH.Text, cbMaPhong.Text, txtCMND.Text, txtQuocTich.Text, txtGioiTinh.Text, txtNgaySinh.Text, txtSDT.Text);
                cl_KH.Conect_QLKS();
                cl_KH.Insert_KhachHang1();
                KhachHang_Load(sender, e);
                cl_KH.Conn.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cl_KH = new CL_KhachHang(txtMaKH.Text, txtTenKH.Text, cbMaPhong.Text, txtCMND.Text, txtQuocTich.Text, txtGioiTinh.Text, txtNgaySinh.Text, txtSDT.Text);
            cl_KH.Conect_QLKS();
            cl_KH.Update_KhachHang1();
            MessageBox.Show("OK");
            KhachHang_Load(sender, e);
            cl_KH.Conn.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cl_KH = new CL_KhachHang(txtMaKH.Text, txtTenKH.Text, txtCMND.Text, txtQuocTich.Text, txtGioiTinh.Text, txtNgaySinh.Text, txtSDT.Text, cbMaPhong.Text);
            cl_KH.Conect_QLKS();
            cl_KH.Delete_KhachHang();
            KhachHang_Load(sender, e);
            cl_KH.Conn.Close();
        }

        private void cbMaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
