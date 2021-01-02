using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NhanVienDAO
    {
        public static DataTable GetAllNhanVien()
        {
            SqlConnection con = dbConnection.HamKetNoi();
            List<NhanVienDTO> lstNhanVien = new List<NhanVienDTO>();                  
            con.Open();
            SqlDataAdapter command = new SqlDataAdapter("SELECT MaNV, TenNV, TenQuyen, NgaySinh, GioiTinh, SDT FROM NhanVien, Quyen where NhanVien.MaQuyen = Quyen.MaQuyen",con);
            DataTable dataTable = new DataTable();
            command.Fill(dataTable);
            return dataTable;
            
        }
        public static int GetNhanVien(long manv , string mk)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            MD5 mh = MD5.Create();
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(mk);
                byte[] hash = mh.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                }

            con.Open();
            string sql = string.Format(@"SELECT COUNT(*) FROM NHANVIEN WHERE [MaNV] = {0} AND  MATKHAU ='{1}' "  , manv ,sb);
            SqlCommand command = new SqlCommand(sql, con);
            object count = command.ExecuteScalar();
            return ((int)count);
            con.Close();
        }
        public static int GetNhanVien(long manv)
        {
            SqlConnection con = dbConnection.HamKetNoi();
          
            con.Open();
            string sql = string.Format(@"SELECT COUNT(*) FROM NHANVIEN WHERE [MaNV] = {0} ", manv);
            SqlCommand command = new SqlCommand(sql, con);
            object count = command.ExecuteScalar();
            return ((int)count);
            con.Close();
        }



        public static string GetMKNhanVien(long manv)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
        
            string sql = string.Format(@"SELECT MATKHAU FROM NHANVIEN WHERE [MaNV] = {0}", manv);
            SqlCommand command = new SqlCommand(sql, con);
            var count = command.ExecuteScalar();
            return ((string)count);
            con.Close();
        }
        public static void InsertNhanVien(long manv, string tennv, long maquyen, DateTime ngaysinh, string gioitinh, string sdt, string mk)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();

            MD5 mh = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(mk);
            byte[] hash = mh.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            string sql = string.Format(@"INSERT INTO NhanVien ([MaNV], [TenNV], [MaQuyen], [NgaySinh], [GioiTinh], [SDT] ,[MATKHAU] ) VALUES({0}, N'{1}',{2},N'{3}', N'{4}', '{5}', '{6}' )", manv, tennv,maquyen,ngaysinh,gioitinh,sdt,sb);
            SqlCommand command = new SqlCommand(sql, con);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            con.Close();
        }
        public static void UpdateNhanVien(long manv, string tennv, long maquyen, DateTime ngaysinh, string gioitinh, string sdt)
        {

         

            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format(@"UPDATE NhanVien Set [TenNV] = N'{1}', [MaQuyen] = {2} ,[NgaySinh] = '{3}', [GioiTinh] =N'{4}', [SDT]='{5}' WHERE MaNV= {0}", manv, tennv, maquyen, ngaysinh, gioitinh, sdt);
            SqlCommand command = new SqlCommand(sql, con);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            con.Close();
        }
        
        public static void DeleteNhanVien(long manv)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format(@"DELETE FROM NhanVien WHERE MaNV= {0}", manv);
            SqlCommand command = new SqlCommand(sql, con);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            con.Close();
        }
        public static List<QuyenDTO> GetAllQuyen()
        {
            SqlConnection con = dbConnection.HamKetNoi();
            List<QuyenDTO> listQuyen = new List<QuyenDTO>();
            SqlCommand command = new SqlCommand("SELECT * FROM Quyen", con);
            command.CommandType = CommandType.Text;
            con.Open();
            using (SqlDataReader dataReader = command.ExecuteReader())
            {
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        QuyenDTO temp = new QuyenDTO();
                        long MaQuyen = dataReader.GetInt64(dataReader.GetOrdinal("MaQuyen"));
                        if (MaQuyen != null)
                        {
                            temp.MaQuyen = MaQuyen;
                            temp.TenQuyen = dataReader["TenQuyen"].ToString();
                            
                        }
                        listQuyen.Add(temp);
                    }
                }
            }
            return listQuyen;
        }
        public static string GetTenNhanVien(long manv)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format(@"SELECT TENNV FROM NHANVIEN WHERE [MaNV] = {0}", manv);
            SqlCommand command = new SqlCommand(sql, con);
            var count = command.ExecuteScalar();
            return ((string)count);
            con.Close();
        }
        public static void UpdateTaiKhoan(long manv, string mk)
        {
            MD5 mh = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(mk);
            byte[] hash = mh.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format(@"UPDATE NhanVien Set [MatKhau] = N'{1}' WHERE MaNV= {0}", manv, sb);
            SqlCommand command = new SqlCommand(sql, con);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            con.Close();
        }
        public static long GetQuyenNhanVien(long manv)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format(@"SELECT MaQuyen FROM NHANVIEN WHERE [MaNV] = {0}", manv);
            SqlCommand command = new SqlCommand(sql, con);
            var count = command.ExecuteScalar();
            return ((long)count);
            con.Close();
        }
    }
}
