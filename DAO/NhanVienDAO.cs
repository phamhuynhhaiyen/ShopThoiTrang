using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
            //    using (SqlDataReader dataReader = command.ExecuteReader())
            //    {
            //    if (dataReader.HasRows)
            //    {
            //            while (dataReader.Read())
            //            {
            //                    NhanVienDTO temp = new NhanVienDTO();
            //                    long MaNV = dataReader.GetInt64(dataReader.GetOrdinal("MaNV"));
            //                    if (MaNV != null)
            //                    {
            //                        temp.MaNV = MaNV;
            //                        temp.TenNV = dataReader["TenNV"].ToString();
            //                        string MaQuyen = dataReader["MaQuyen"].ToString();
            //                        if (MaQuyen != null)
            //                            temp.MaQuyen = Convert.ToInt64(MaQuyen);
            //                        string NgaySinh = dataReader["NgaySinh"].ToString();
            //                        if (NgaySinh != null)
            //                            temp.NgaySinh = Convert.ToDateTime(NgaySinh);
            //                        temp.GioiTinh = dataReader["GioiTinh"].ToString();
            //                    temp.SDT = dataReader["SDT"].ToString();

            //                }
            //                    lstNhanVien.Add(temp);
            //            }
            //     }
            //}           
            //return lstNhanVien;
        }
        public static int GetNhanVien(long manv)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format(@"SELECT COUNT(*) FROM NHANVIEN WHERE [MaNV] = {0}", manv);
            SqlCommand command = new SqlCommand(sql, con);
            object count = command.ExecuteScalar();
            return ((int)count);
            con.Close();
        }
        public static void InsertNhanVien(NhanVienDTO nv)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format(@"INSERT INTO NhanVien ([MaNV], [TenNV], [MaQuyen], [NgaySinh], [GioiTinh], [SDT]) VALUES({0}, N'{1}',{2},N'{3}', N'{4}', '{5}')", nv.MaNV, nv.TenNV, nv.MaQuyen, nv.NgaySinh, nv.GioiTinh, nv.SDT);
            SqlCommand command = new SqlCommand(sql, con);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            con.Close();
        }
        public static void UpdateNhanVien(NhanVienDTO nv)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format(@"UPDATE NhanVien Set [TenNV] = N'{1}', [MaQuyen] = {2} ,[NgaySinh] = '{3}', [GioiTinh] =N'{4}', [SDT]='{5}' WHERE MaNV= {0}", nv.MaNV, nv.TenNV, nv.MaQuyen, nv.NgaySinh, nv.GioiTinh, nv.SDT);
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
    }
}
