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
    public partial class TaiKhoan : Form
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }
        CL_TaiKhoan cl_tk = new CL_TaiKhoan();
        DataTable daTa_Table = new DataTable();

        private void _TaiKhoan()
        {
            cl_tk.TenDangNhap = txtTenDangNhap.Text;
            cl_tk.MatKhau = txtMatKhau.Text;
        }
        private void M_CapNhat()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void T_CapNHat()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
        private void TrongText()
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
        }
        public void DoDL_VaoTK(DataTable Data_table, DataGridView gridView)
        {
            gridView.Rows.Clear();
            for (int i = 0; i < Data_table.Rows.Count; i++)
            {
                gridView.Rows.Add();
                gridView.Rows[i].Cells[0].Value = i + 1;
                for (int j = 0; j < Data_table.Columns.Count; j++)
                {
                    gridView.Rows[i].Cells[j + 1].Value = Data_table.Rows[i][j].ToString();
                }
            }

        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            cl_tk.Conect_QLKS();
            M_CapNhat();
            daTa_Table = cl_tk.LayDL("select * from TaiKhoanDangNhap");
            DoDL_VaoTK(daTa_Table, dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                int SoDong = dataGridView1.CurrentRow.Index;
                if (SoDong >= 0 && SoDong < dataGridView1.Rows.Count)
                {
                    txtTenDangNhap.Text = dataGridView1.Rows[SoDong].Cells[1].Value.ToString();
                    txtMatKhau.Text = dataGridView1.Rows[SoDong].Cells[2].Value.ToString();
                    T_CapNHat();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            daTa_Table = cl_tk.LayDL("select * from TaiKhoanDangNhap where TenDangNhap=N'" + txtTenDangNhap.Text + "'");
            if(daTa_Table.Rows.Count > 0)
            {
                MessageBox.Show("Tài Khoản Này Đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
            }
            else
            {
                cl_tk = new CL_TaiKhoan(txtTenDangNhap.Text, txtMatKhau.Text);
                cl_tk.Conect_QLKS();
                cl_tk.Insert_TaiKhoan();
                TaiKhoan_Load(sender, e);
                cl_tk.Conn.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cl_tk = new CL_TaiKhoan(txtTenDangNhap.Text, txtMatKhau.Text);
            cl_tk.Conect_QLKS();
            cl_tk.Update_TaiKhoan();
            TaiKhoan_Load(sender, e);
            cl_tk.Conn.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cl_tk = new CL_TaiKhoan(txtTenDangNhap.Text, txtMatKhau.Text);
            cl_tk.Conect_QLKS();
            cl_tk.Delete_TaiKhoan();
            TaiKhoan_Load(sender, e);
            cl_tk.Conn.Close();
        }
        private void Th()
        {
            if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "") 
            {
                M_CapNhat();
            }
            else
            {
                T_CapNHat();
            }
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            Th();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            Th();
        }
    }
}
