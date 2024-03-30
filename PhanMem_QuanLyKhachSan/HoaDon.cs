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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        private CL_HoaDon CL_HD = new CL_HoaDon();
        private KhachHang KH = new KhachHang();
        private DataTable data = new DataTable();
        private DichVu DV = new DichVu();


        public void DoDL_VaoCB(DataTable dataTable, ComboBox combo)
        {
            combo.Items.Clear();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                combo.Items.Add(dataTable.Rows[i][0].ToString());
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            CL_HD.Conect_QLKS();
            data = CL_HD.LayDL("select * from HoaDon");
            DV.DoDL_VaoDV(data, dataGridView1);
            DataTable Table = CL_HD.LayDL("select * from KhachHang");
            DoDL_VaoCB(Table, cbMaKH);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            data = CL_HD.LayDL("select * from HoaDon where MaHD='" + txtMaHD.Text + "'");
            if (data.Rows.Count > 0)
            {
                MessageBox.Show("Dịch vụ này đã có vui lòng nhập dịch vụ khác!!...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHD.Focus();
            }
            else
            {
                CL_HD = new CL_HoaDon(txtMaHD.Text,cbMaKH.Text,txtNgay.Text, float.Parse(txtGia.Text));
                CL_HD.Conect_QLKS();
                CL_HD.Insert_HoaDon();
                HoaDon_Load(sender, e);
                CL_HD.Conn.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CL_HD = new CL_HoaDon(txtMaHD.Text, cbMaKH.Text, txtNgay.Text, float.Parse(txtGia.Text));
            CL_HD.Conect_QLKS();
            CL_HD.Update_HoaDon();
            HoaDon_Load(sender, e);
            CL_HD.Conn.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            CL_HD = new CL_HoaDon(txtMaHD.Text, cbMaKH.Text, txtNgay.Text, float.Parse(txtGia.Text));
            CL_HD.Conect_QLKS();
            CL_HD.Delete_HoaDon();
            HoaDon_Load(sender, e);
            CL_HD.Conn.Close();
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
                    txtMaHD.Text = dataGridView1.Rows[dong_ht].Cells[1].Value.ToString();
                    cbMaKH.Text = dataGridView1.Rows[dong_ht].Cells[2].Value.ToString();
                    txtNgay.Text = dataGridView1.Rows[dong_ht].Cells[3].Value.ToString();
                    txtGia.Text = dataGridView1.Rows[dong_ht].Cells[4].Value.ToString();
                   
                }
            }
        }
    }
}
