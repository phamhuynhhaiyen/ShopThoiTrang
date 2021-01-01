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
    public class SanPhamDAO
    {
        public static DataTable GetAllSanPham()
        {
            SqlConnection con = dbConnection.HamKetNoi();           
            con.Open();
            SqlDataAdapter command = new SqlDataAdapter("SELECT * FROM SANPHAM", con);
            DataTable dataTable = new DataTable();
            command.Fill(dataTable);
            return dataTable;
            
        }
        public static string GetTenSanPham(long maSP)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format("select tensp from sanpham where MaSP = {0}", maSP);
            SqlCommand command = new SqlCommand(sql, con);
            var TenSP = command.ExecuteScalar();
            return TenSP.ToString();

        }
        public static long GetGiaSanPham(long maSP)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format("select GiaBan from sanpham where MaSP = {0}", maSP);
            SqlCommand command = new SqlCommand(sql, con);
            var Gia = command.ExecuteScalar();
            return (long)Gia;

        }
        public static int GetSoLuongTon(long maSP)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format("select SoLuongTon from sanpham where MaSP = {0}", maSP);
            SqlCommand command = new SqlCommand(sql, con);
            var sl = command.ExecuteScalar();
            return (int)sl;

        }
    }
}
