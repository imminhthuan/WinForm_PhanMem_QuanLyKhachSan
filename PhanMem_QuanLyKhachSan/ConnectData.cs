using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PhanMem_QuanLyKhachSan
{
    public class ConnectData
    {
        public SqlConnection Conn = new SqlConnection();
        public SqlCommand Comm = new SqlCommand();

        public void Conect_QLKS()
        {
            Conn = new SqlConnection("Data Source=LAPTOP-7JIKMVLO\\SQLEXPRESS;Initial Catalog=SQL_QL_Khach_San;Integrated Security=True");
            Conn.Open();
        }
        
        public DataTable LayDL(String CauLenhTruyVan)
        {
            DataTable Data = new DataTable();
            Comm = new SqlCommand(CauLenhTruyVan, Conn);
            SqlDataAdapter Adapter = new SqlDataAdapter(Comm);
            Adapter.Fill(Data);
            return Data;
        }

        public void CapNhatDL(String CauLenhCapNhat)
        {
            Comm = new SqlCommand(CauLenhCapNhat, Conn);
            Comm.ExecuteNonQuery();
        }
    }
}
