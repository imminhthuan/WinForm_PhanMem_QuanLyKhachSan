using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMem_QuanLyKhachSan
{
    public class CL_DichVu  : CL_NhanVien
    {
        public string MaDV, TenDV;
        public float GiaDV;
        public string madv
        {
            get 
            {
                return MaDV;
            }
            set
            {
                MaDV = value;
            }
        }
        public string tendv
        {
            get
            {
                return TenDV;
            }
            set
            {
                TenDV = value;
            }
        }
        public float giadv
        {
            get
            {
                return GiaDV;
            }
            set
            {
                GiaDV = value;
            }
        }
        public CL_DichVu()
        {

        }
        public CL_DichVu(string maDV, string tenDV, string Mnv, float giaDV)
        {
            MaDV = maDV;
            TenDV = tenDV;
            MaNV= Mnv;
            GiaDV = giaDV;
        }

       
        public void Insert_DichVu()
        {
            ThucThi("insert into DichVu Values(N'" + MaDV + "',N'" + TenDV + "',N'"+MaNV+"',N'" + GiaDV + "')");
        }
        public void Update_DichVu()
        {
            ThucThi("update DichVu set TenDV=N'" + TenDV + "',MaNV=N'"+MaNV+"',GiaDV=N'" + GiaDV + "' where MaDV=N'" + MaDV + "'");
        }
        public void Delete_DichVu()
        {
            ThucThi("delete from DichVu where MaDV=N'" + MaDV + "'");
        }
    }
}
