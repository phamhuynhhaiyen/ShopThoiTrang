using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UserDAO
    {
        public static List<UserDTO> GetAllUser()
        {
            SqlConnection con = dbConnection.HamKetNoi();
            List<UserDTO> lstUser = new List<UserDTO>();
            con.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM DANGNHAP", con);
            using (SqlDataReader dataReader = command.ExecuteReader())
            {
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        UserDTO temp = new UserDTO();
                        
                            temp.TaiKhoan = dataReader.GetInt64(dataReader.GetOrdinal("TaiKhoan"));
                            temp.MatKhau = dataReader["MatKhau"].ToString();
                            
                        lstUser.Add(temp);
                    }
                }
            }
            return lstUser;
        }
        public static string GetTenUser(long manv)
        {
            SqlConnection con = dbConnection.HamKetNoi();            
            con.Open();
            string sql = string.Format("select Nhanvien.TenNV from DangNhap, NhanVien where TaiKhoan = MaNV and TaiKhoan = {0}", manv);
            SqlCommand command = new SqlCommand(sql, con);
            var name = command.ExecuteScalar();
            return name.ToString();
        }
    }
}
