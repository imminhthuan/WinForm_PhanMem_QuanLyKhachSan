using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMem_QuanLyKhachSan
{
    public class CL_KhachHang : CL_Phong
    {
        public string MaKH, TenKH, CMND, QuocTich;
        public string makh
        {
            get { return MaKH; }
            set { MaKH = value; }
        }
        public string tenkh
        {
            get { return TenKH; }
            set { TenKH = value; }
        }
        public string cmnd
        {
            get { return CMND; }
            set { CMND = value; }
        }
        public string quoctich
        {
            get { return QuocTich; }
            set { QuocTich = value; }
        }
        public string gioitinh
        {
            get { return GioiTinh; }
            set { GioiTinh = value; }
        }
       
        public CL_KhachHang()
        {

        }
        public CL_KhachHang(string maKH, string tenKH, string maPhong, string cMND, string quocTich, string gioiTinh, string ngaySinh, string sDT)
        {
            MaKH = maKH;
            TenKH = tenKH;
            CMND = cMND;
            QuocTich = quocTich;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            SDT = sDT;
            MaPhong = maPhong;          
        }
        public void Insert_KhachHang()
        {
            string sql = "insert into KhachHang values(N'" + MaKH.Replace("'", "''") + "', N'" + TenKH.Replace("'", "''") + "', N'" + CMND.Replace("'", "''") + "', N'" + QuocTich.Replace("'", "''") + "', N'" + GioiTinh.Replace("'", "''") + "', N'" + NgaySinh.Replace("'", "''") + "', N'" + SDT.Replace("'", "''") + "',N'" + MaPhong.Replace("'", "''") + "')";
            Console.WriteLine("Insert SQL: " + sql);
            ThucThi(sql);
        }

        public void Insert_KhachHang1()
        {
            string sql = "insert into KhachHang values(N'"+MaKH+"',N'"+TenKH+"',N'"+MaPhong+"',N'"+CMND+"',N'"+QuocTich+"',N'"+GioiTinh+"',N'"+NgaySinh+"',N'"+SDT+"')";
            ThucThi(sql);
        }

        public void Update_KhachHang()
        {
            string sql = "Update KhachHang set TenKH=N'" + TenKH.Replace("'", "''") + "', CMND=N'" + CMND.Replace("'", "''") + "', QuocTich=N'" + QuocTich.Replace("'", "''") + "', GioiTinh=N'" + GioiTinh.Replace("'", "''") + "', NgaySinh=N'" + NgaySinh.Replace("'", "''") + "', SDT=N'" + SDT.Replace("'", "''") + "' where MaKH=N'" + MaKH.Replace("'", "''") + "'";
            Console.WriteLine("Update SQL: " + sql);
            ThucThi(sql);
        }

        public void Update_KhachHang1()
        {
            string sql = "Update KhachHang set TenKH=N'"+TenKH+"', MaPhong=N'"+MaPhong+"',CMND=N'"+CMND+"',QuocTich=N'"+QuocTich+"',GioiTinh=N'"+GioiTinh+"',NgaySinh=N'"+NgaySinh+"',SDT=N'"+SDT+ "' where MaKH=N'"+MaKH+"'";
            Console.WriteLine("Update SQL: " + sql);
            ThucThi(sql);
        }

        public void Delete_KhachHang()
        {
            string sql = "Delete from KhachHang where MaKH=N'" + MaKH.Replace("'", "''") + "'";
            Console.WriteLine("Delete SQL: " + sql);
            ThucThi(sql);
        }
        public void Delete_KhachHang1()
        {
            string sql = "Delete from KhachHang where MaKH=N'"+MaKH+"'";
            Console.WriteLine("Delete SQL: " + sql);
            ThucThi(sql);
        }
    }
}
