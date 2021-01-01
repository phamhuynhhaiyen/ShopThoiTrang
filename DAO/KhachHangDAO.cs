using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{

    public class KhachHangDAO
    {
        public static List<KhachHangDTO> GetAllKH()
        {
            SqlConnection con = dbConnection.HamKetNoi();
            List<KhachHangDTO> lstKH = new List<KhachHangDTO>();
            con.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM KHACHHANG", con);
            using (SqlDataReader dataReader = command.ExecuteReader())
            {
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        KhachHangDTO temp = new KhachHangDTO();

                        
                        temp.sdt = dataReader["SDT"].ToString();
                        temp.TenKH = dataReader["TenKH"].ToString();
                        
                        lstKH.Add(temp);
                    }
                }
            }
            return lstKH;
        }
        public static string GetTenKhachHang(string sdt)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format("select TenKH from KhachHang where SDT = {0}", sdt);
            SqlCommand command = new SqlCommand(sql, con);
            var TenKH = command.ExecuteScalar();
            return TenKH.ToString();

        }
        public static void InsertKhachHang(KhachHangDTO kh)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format(@"INSERT INTO KhachHang VALUES(N'{0}', N'{1}')", kh.sdt, kh.TenKH);
            SqlCommand command = new SqlCommand(sql, con);
            
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}
