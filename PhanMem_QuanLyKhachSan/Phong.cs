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
    public partial class Phong : Form
    {
        public Phong()
        {
            InitializeComponent();
        }
        private CL_Phong cl_phong = new CL_Phong();
        private DataTable data_table = new DataTable();
        private DichVu dichvu = new DichVu();

        public void DoDL_VaoCB(DataTable dataTable, ComboBox combo)
        {
            combo.Items.Clear();
            for(int i = 0;  i  <  dataTable.Rows.Count; i++)
            {
                combo.Items.Add(dataTable.Rows[i][0].ToString());
            }
        }
        private void Phong_Load(object sender, EventArgs e)
        {
            cl_phong.Conect_QLKS();
            data_table = cl_phong.LayDL("select * from Phong");
            dichvu.DoDL_VaoDV(data_table, dataGridView1);
            DataTable Table = cl_phong.LayDL("select * from DichVu");
            DoDL_VaoCB(Table, cbMaDV);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                int dong_ht = dataGridView1.CurrentRow.Index;
                if (dong_ht > dataGridView1.Rows.Count - 2)
                    return;
                else
                {
                    txtMaPhong.Text = dataGridView1.Rows[dong_ht].Cells[1].Value.ToString();
                    txtTenPhong.Text = dataGridView1.Rows[dong_ht].Cells[2].Value.ToString();
                    txtLoaiPhong.Text = dataGridView1.Rows[dong_ht].Cells[3].Value.ToString();
                    txtTinh.Text = dataGridView1.Rows[dong_ht].Cells[4].Value.ToString();
                    cbMaDV.Text = dataGridView1.Rows[dong_ht].Cells[5].Value.ToString();
                }
            }
        }






    

        private void btnThem_Click(object sender, EventArgs e)
        {
            data_table = cl_phong.LayDL("select * from Phong where MaPhong= '" +txtMaPhong.Text + "'");
            if(data_table.Rows.Count >= 1)
            {
                MessageBox.Show("Phòng này đã Tồn Tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhong.Focus();
            }
            else
            {
                cl_phong = new CL_Phong(txtMaPhong.Text, txtTenPhong.Text, txtLoaiPhong.Text, txtTinh.Text, cbMaDV.Text);
                cl_phong.Conect_QLKS();
                cl_phong.Insert_Phong();
                Phong_Load(sender, e);
                cl_phong.Conn.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cl_phong = new CL_Phong(txtMaPhong.Text, txtTenPhong.Text, txtLoaiPhong.Text, txtTinh.Text, cbMaDV.Text);
            cl_phong.Conect_QLKS();
            cl_phong.Update_Phong();
            Phong_Load(sender, e);
            cl_phong.Conn.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cl_phong = new CL_Phong(txtMaPhong.Text, txtTenPhong.Text, txtLoaiPhong.Text, txtTinh.Text, cbMaDV.Text);
            cl_phong.Conect_QLKS();
            cl_phong.Delete_Phong();
            Phong_Load(sender, e);
            cl_phong.Conn.Close();
        }

        private void txtTimTenPhong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimMaPhong_TextChanged(object sender, EventArgs e)
        {
            data_table = cl_phong.LayDL("select * from Phong where MaPhong like '%" + txtTimMaPhong.Text + "%'");
            dichvu.DoDL_VaoDV(data_table, dataGridView1);
        }

        private void txtTimTenPhong_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void cbTimMaDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
