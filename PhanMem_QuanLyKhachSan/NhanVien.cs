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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        private CL_NhanVien cl_NV = new CL_NhanVien();
        private DataTable data_table = new DataTable();

        private void _NhanVien()
        {
            cl_NV.manv = txtMaNV.Text;
            cl_NV.HoTen = txtHoTen.Text;
            cl_NV.GioiTinh = txtGioiTinh.Text;
            cl_NV.NgaySinh = txtNgaySinh.Text;
            cl_NV.DiaChi = txtDiaChi.Text;
            cl_NV.ChucVu = txtChucVu.Text;
            cl_NV.LuongNV = txtLuongNV.Text;
            cl_NV.SDT = txtSDT.Text;
        }
        private void AnBT_CapNhat()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void HTBT_CapNhat()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
        private void TrongText()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtGioiTinh.Text = "";
            txtNgaySinh.Text = "";
            txtDiaChi.Text = "";
            txtChucVu.Text = "";
            txtLuongNV.Text = "";
            txtSDT.Text = "";
        }
        public void DoDL_VaoNV(DataTable tbl_All, DataGridView DataG_All)
        {
            DataG_All.Rows.Clear();
            for (int i = 0; i < tbl_All.Rows.Count; i++)
            {
                DataG_All.Rows.Add();
                DataG_All.Rows[i].Cells[0].Value = i + 1;
                for (int j = 0; j < tbl_All.Columns.Count; j++)
                {
                    DataG_All.Rows[i].Cells[j + 1].Value = tbl_All.Rows[i][j].ToString();
                }
            }
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            cl_NV.Conect_QLKS();
            AnBT_CapNhat();
            data_table = cl_NV.LayDL("select * from NhanVien");
            DoDL_VaoNV(data_table, dataGridView1);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int sodong = dataGridView1.CurrentRow.Index;
                if (sodong >= 0 && sodong < dataGridView1.Rows.Count)
                {
                    txtMaNV.Text = dataGridView1.Rows[sodong].Cells[1].Value.ToString();
                    txtHoTen.Text = dataGridView1.Rows[sodong].Cells[2].Value.ToString();
                    txtGioiTinh.Text = dataGridView1.Rows[sodong].Cells[3].Value.ToString();
                    txtNgaySinh.Text = dataGridView1.Rows[sodong].Cells[4].Value.ToString();
                    txtDiaChi.Text = dataGridView1.Rows[sodong].Cells[5].Value.ToString();
                    txtChucVu.Text = dataGridView1.Rows[sodong].Cells[6].Value.ToString();
                    txtLuongNV.Text = dataGridView1.Rows[sodong].Cells[7].Value.ToString();
                    txtSDT.Text = dataGridView1.Rows[sodong].Cells[8].Value.ToString();
                    HTBT_CapNhat();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            data_table = cl_NV.LayDL("select * from NhanVien where MaNV='" + txtMaNV.Text + "'");
            if (data_table.Rows.Count > 0 )
            {
                MessageBox.Show("Nhân Viên này đã có,vui lòng nhập lại Nhân Viên khác!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
            }
            else
            {
                cl_NV = new CL_NhanVien(txtMaNV.Text, txtHoTen.Text, txtGioiTinh.Text, txtNgaySinh.Text , txtDiaChi.Text, txtChucVu.Text, txtLuongNV.Text, txtSDT.Text);
                cl_NV.Conect_QLKS();
                cl_NV.Insert_NV();
                NhanVien_Load(sender, e);
                cl_NV.Conn.Close();
            }
        }
    

        private void btnSua_Click(object sender, EventArgs e)
        {
            cl_NV = new CL_NhanVien(txtMaNV.Text, txtHoTen.Text, txtGioiTinh.Text, txtNgaySinh.Text, txtDiaChi.Text, txtChucVu.Text, txtLuongNV.Text, txtSDT.Text);
            cl_NV.Conect_QLKS();
            cl_NV.Update_NV();
            NhanVien_Load(sender, e);
            cl_NV.Conn.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cl_NV = new CL_NhanVien(txtMaNV.Text, txtHoTen.Text, txtGioiTinh.Text, txtNgaySinh.Text, txtDiaChi.Text, txtChucVu.Text, txtLuongNV.Text, txtSDT.Text);
            cl_NV.Conect_QLKS();
            cl_NV.Delete_NV();
            //MessageBox.Show("ok");
            NhanVien_Load(sender, e);
            //MessageBox.Show("ok");

            cl_NV.Conn.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void check()
        {
            if(txtMaNV.Text=="" || txtHoTen.Text == ""|| txtGioiTinh.Text == ""|| txtNgaySinh.Text==""||txtDiaChi.Text ==""||txtChucVu.Text==""||txtLuongNV.Text==""|| txtSDT.Text == "")
            {
                AnBT_CapNhat();
            }
            else
            {
                HTBT_CapNhat();
            }
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void txtGioiTinh_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void txtChucVu_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void txtLuongNV_TextChanged(object sender, EventArgs e)
        {
            check();
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            check();
        }
    }
}
