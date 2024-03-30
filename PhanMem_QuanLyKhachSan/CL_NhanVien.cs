using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMem_QuanLyKhachSan
{
    public class CL_NhanVien : ConnectData
    {
        public string MaNV, HoTen, GioiTinh , NgaySinh, DiaChi, ChucVu , LuongNV , SDT;
        public string manv 
        { 
            get 
            { 
                return MaNV; 
            }
            set 
            { 
                MaNV = value; 
            } 
        }
        public string hoten 
        { 
            get 
            { 
                return HoTen; 
            } 
            set 
            { 
                HoTen = value; 
            } 
        }
        public string ngaysinh 
        { 
            get 
            { 
                return NgaySinh; 
            } 
            set
            { 
                NgaySinh = value; 
            } 
        }
        public string diachi 
        { 
            get 
            { 
                return DiaChi; 
            } 
            set 
            { 
                DiaChi = value; 
            }
        }
        public string chucvu
        {
            get 
            { 
                return ChucVu; 
            }
            set
            {
                ChucVu = value;
            }
        }
        public string luongnv
        {
            get
            {
                return LuongNV;
            }
            set
            {
                LuongNV = value;
            }
        }
        public string sdt 
        {
            get
            { 
                return SDT; 
            } 
            set 
            { 
                SDT = value; 
            } 
        }
        public CL_NhanVien()
        {

        }
        public CL_NhanVien(string maNV, string hoTen, string gioiTinh, string ngaySinh, string diaChi, string chucVu, string luongNV, string sDT)
        {
            MaNV = maNV;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            ChucVu = chucVu;
            LuongNV = luongNV;
            SDT = sDT;
            
        }

        public void ThucThi(string CauLenh_ThucThi)
        {
            Comm = new SqlCommand(CauLenh_ThucThi, Conn);
            Comm.ExecuteNonQuery();
        }
        public void Insert_NV()
        {
            ThucThi("insert into NhanVien values('" + MaNV + "',N'" + HoTen + "',N'" + GioiTinh + "','" + NgaySinh + "',N'" + DiaChi + "',N'"+ ChucVu +"','"+ LuongNV +"','" + SDT + "')");
        }
        public void Update_NV()
        {
            ThucThi("update NhanVien set HoTen=N'" + HoTen + "',GioiTinh=N'" + GioiTinh + "',NGSINH=N'" + NgaySinh + "',DiaChi=N'" + DiaChi + "',ChucVu=N'"+ ChucVu +"',LuongNV=N'"+ LuongNV +"',SDT=N'" + SDT + "'  where MaNV=N'" + MaNV + "'");
        }
        public void Delete_NV()
        {
            ThucThi("delete NhanVien where MaNV='" + MaNV + "'");
        }
    }

    
}
