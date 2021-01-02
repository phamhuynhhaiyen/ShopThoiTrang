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
        public static void UpdateKhachHang(KhachHangDTO kh)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format(@"UPDATE KhachHang SET TENKH = N'{0}' WHERE SDT = N'{1}')", kh.TenKH, kh.sdt );
            SqlCommand command = new SqlCommand(sql, con);

            command.ExecuteNonQuery();
            con.Close();
        }
        public static void DeleteKhachHang(string SDT)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format(@"DELETE KhachHang WHERE SDT = N'{0}'", SDT);
            SqlCommand command = new SqlCommand(sql, con);

            command.ExecuteNonQuery();
            con.Close();
        }
        public static int GetMa(string manv)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format(@"SELECT COUNT(*) FROM KHACHHANG WHERE SDT = N'{0}'", manv);
            SqlCommand command = new SqlCommand(sql, con);
            object count = command.ExecuteScalar();
            return ((int)count);
            con.Close();
        }
    }
}
