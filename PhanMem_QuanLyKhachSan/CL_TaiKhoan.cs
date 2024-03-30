using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PhanMem_QuanLyKhachSan
{
    public class CL_TaiKhoan : ConnectData
    {
        public string TenDangNhap, MatKhau;
        public string tendangnhap
        {
            get { return TenDangNhap; }
            set
            {
                TenDangNhap = value;
            }
        }
        public string matkhau
        {
            get { return MatKhau; }
            set { MatKhau = value; }
        }
        public CL_TaiKhoan()
        {

        }
        public CL_TaiKhoan(string tenDangNhap, string matKhau)
        {
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
        }

        public void ThucThi(string caulenhthucthi)
        {
            Comm = new SqlCommand(caulenhthucthi, Conn);
            Comm.ExecuteNonQuery();
        }
       
        public void Insert_TaiKhoan()
        {
         
            ThucThi("Insert into TaiKhoanDangNhap values(N'" + TenDangNhap + "', N'" + MatKhau + "')");           
        }
        public void Update_TaiKhoan()
        {
            ThucThi("Update TaiKhoanDangNhap set MatKhau=N'" + MatKhau + "' where TenDangNhap=N'" + TenDangNhap + "'");
        }
        public void Delete_TaiKhoan()
        {
            ThucThi("Delete from TaiKhoanDangNhap where TenDangNhap=N'" + TenDangNhap + "'");
        }
    }
}
