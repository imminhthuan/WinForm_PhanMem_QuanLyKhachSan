using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMem_QuanLyKhachSan
{
    public class CL_HoaDon : CL_KhachHang
    {
        public string MaHD, Ngay;
        public float Gia;
        public string mahd 
        {
            get
            {
                return MaHD;
            }
            set
            {
                MaHD = value;
            }
        }
        public string ngay
        {
            get
            {
                return Ngay;
            }
            set
            {
                Ngay = value;
            }
        }
        public float gia
        {
            get
            {
                return Gia;
            }
            set
            {
                Gia = value;
            }
        }
        public CL_HoaDon()
        {

        }
        public CL_HoaDon(string mahd,string mkh , string ngay, float gia)
        {
            MaHD = mahd;
            MaKH = mkh;            
            Ngay = ngay;
            Gia = gia;
            
        }
        public void Insert_HoaDon()
        {
            ThucThi("insert into HoaDon Values(N'" + MaHD + "',N'" + MaKH + "',N'" + Ngay + "',N'" + Gia + "')");
        }

        public void Update_HoaDon()
        {
            ThucThi("update HoaDon set Ngay=N'" + Ngay + "', Gia=N'" + Gia + "', MaKH=N'" + MaKH + "' where MaHD=N'" + MaHD + "'");
        }
        public void Delete_HoaDon()
        {
            ThucThi("delete from HoaDon where MaHD=N'" + MaHD + "'");
        }
    }
}
