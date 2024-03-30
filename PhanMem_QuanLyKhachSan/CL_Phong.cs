using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMem_QuanLyKhachSan
{
    public class CL_Phong : CL_DichVu
    {
        public string MaPhong, TenPhong, LoaiPhong, TinhTrang;
        public string maphong
        {
            get
            {
                return MaPhong;
            }
            set
            {
                MaPhong = value;
            }
        }
        public string tenphong
        {
            get
            {
                return TenPhong;
            }
            set
            {
                TenPhong = value;
            }
        }
        public string loaiphong
        {
            get
            {
                return LoaiPhong;
            }
            set
            {
                LoaiPhong = value;
            }
        }
        public string tinhtrang
        {
            get
            {
                return TinhTrang;
            }
            set
            {
                TinhTrang = value;
            }
        }
        public CL_Phong()
        {

        }
        public CL_Phong(string maPhong, string tenPhong, string loaiPhong, string tinhTrang, string maDV)
        {
            MaPhong = maPhong;
            TenPhong = tenPhong;
            LoaiPhong = loaiPhong;
            TinhTrang = tinhTrang;
            MaDV = maDV;
        }
        public void Insert_Phong()
        {
            ThucThi("insert into Phong values(N'" + MaPhong.Replace("'", "''") + "', N'" + TenPhong.Replace("'", "''") + "', N'" + LoaiPhong.Replace("'", "''") + "', N'" + TinhTrang.Replace("'", "''") + "', N'" + MaDV.Replace("'", "''") + "')");
        }
        public void Update_Phong()
        {
            ThucThi("update Phong set TenPhong=N'" + TenPhong.Replace("'", "''") + "', LoaiPhong=N'" + LoaiPhong.Replace("'", "''") + "', TinhTrang=N'" + TinhTrang.Replace("'", "''") + "', MaDV=N'" + MaDV.Replace("'", "''") + "' where MaPhong=N'" + MaPhong.Replace("'", "''") + "'");
        }
        public  void Delete_Phong()
        {
            ThucThi("delete from Phong where MaPhong= '" +MaPhong.Replace("'", "''") + "'");
        }
    }
}
