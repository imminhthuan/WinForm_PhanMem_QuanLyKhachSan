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
    public partial class DichVu : Form
    {
        public DichVu()
        {
            InitializeComponent();
        }
        private CL_DichVu cl_DV = new CL_DichVu();
        private DataTable Table_DV = new DataTable();
        private NhanVien NV = new NhanVien();
        
    
        
        private void _DichVu()
        {
            cl_DV.MaDV = txtMaDV.Text;
            cl_DV.TenDV = txtTenDV.Text;
            cl_DV.GiaDV = float.Parse(txtGiaDV.Text);
        }
        private void N_CapNhat()
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
            txtMaDV.Text = "";
            txtTenDV.Text = "";
            txtGiaDV.Text = "";
        }
        public void DoDL_VaoCB(DataTable dataTable, ComboBox combo)
        {
            combo.Items.Clear();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                combo.Items.Add(dataTable.Rows[i][0].ToString());
            }
        }
        public void DoDL_VaoDV(DataTable Data_table, DataGridView gridView)
        {
            gridView.Rows.Clear();
            for(int i = 0;  i < Data_table.Rows.Count; i++)
            {
                gridView.Rows.Add();
                gridView.Rows[i].Cells[0].Value = i + 1;
                for (int j = 0; j < Data_table.Columns.Count; j++)
                {
                    gridView.Rows[i].Cells[j + 1].Value = Data_table.Rows[i][j].ToString();
                }
            }
           
        }

        private void DichVu_Load(object sender, EventArgs e)
        {
            cl_DV.Conect_QLKS();
            Table_DV = cl_DV.LayDL("select * from DichVu");
            NV.DoDL_VaoNV(Table_DV, dataGridView1);
            DataTable Table_NV = cl_DV.LayDL("select * from NhanVien");
            DoDL_VaoCB(Table_NV, cbMaNV);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Table_DV = cl_DV.LayDL("select * from DichVu where MaDV='" + txtMaDV.Text + "'");
            if (Table_DV.Rows.Count > 0)
            {
                MessageBox.Show("Dịch vụ này đã có vui lòng nhập dịch vụ khác!!...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaDV.Focus();
            }
            else
            {
                cl_DV = new CL_DichVu(txtMaDV.Text, txtTenDV.Text , cbMaNV.Text ,float.Parse(txtGiaDV.Text));
                cl_DV.Conect_QLKS();
                cl_DV.Insert_DichVu();
                DichVu_Load(sender, e);
                cl_DV.Conn.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cl_DV = new CL_DichVu(txtMaDV.Text, txtTenDV.Text,cbMaNV.Text, float.Parse(txtGiaDV.Text));
            cl_DV.Conect_QLKS();
            cl_DV.Update_DichVu();
            DichVu_Load(sender, e);
            cl_DV.Conn.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cl_DV = new CL_DichVu(txtMaDV.Text, txtTenDV.Text,cbMaNV.Text, float.Parse(txtGiaDV.Text));
            cl_DV.Conect_QLKS();
            cl_DV.Delete_DichVu();
            DichVu_Load(sender, e);
            cl_DV.Conn.Close();
        }
        private void TT()
        {
            if (txtMaDV.Text == "" || txtTenDV.Text == "" || txtGiaDV.Text == "")
            {
                N_CapNhat();
            }
            else 
            {
                T_CapNHat();
            }
        }

        private void txtMaDV_TextChanged(object sender, EventArgs e)
        {
            TT();
        }

        private void txtTenDV_TextChanged(object sender, EventArgs e)
        {
            TT();
        }

        private void txtGiaDV_TextChanged(object sender, EventArgs e)
        {
            TT();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int SoDong = dataGridView1.CurrentRow.Index;
                if (SoDong >= 0 && SoDong < dataGridView1.Rows.Count)
                {
                    txtMaDV.Text = dataGridView1.Rows[SoDong].Cells[1].Value.ToString();
                    txtTenDV.Text = dataGridView1.Rows[SoDong].Cells[2].Value.ToString();
                    cbMaNV.Text = dataGridView1.Rows[SoDong].Cells[3].Value.ToString();
                    txtGiaDV.Text = dataGridView1.Rows[SoDong].Cells[4].Value.ToString();
                    T_CapNHat();
                }
            }
        }

        private void txtTimMaDV_TextChanged(object sender, EventArgs e)
        {
            Table_DV = cl_DV.LayDL("select * from DichVu where MaDV like '%" + txtTimMaDV.Text + "%'");
            DoDL_VaoDV(Table_DV, dataGridView1);
        }
    }
}
