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
            SqlDataAdapter command = new SqlDataAdapter("SELECT MaSP, TenSP, TenLoai, TenNCC, SoLuongTon FROM SANPHAM, LoaiSanPham, NhaCungCap WHERE SanPham.MaLoai = LoaiSanPham.MaLoai AND NhaCungCap.MaNCC = SanPham.MaNCC", con);
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
        public static DataTable GetAllLoai()
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            SqlDataAdapter command = new SqlDataAdapter("SELECT * From LoaiSanPham", con);
            DataTable dataTable = new DataTable();
            command.Fill(dataTable);
            return dataTable;

        }
        public static void InsertSP(string ten, long maloai, long mancc)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format(@"INSERT INTO SanPham ([TenSP], [MaLoai], [MaNCC])  VALUES(N'{0}', {1},{2})", ten, maloai, mancc);
            SqlCommand command = new SqlCommand(sql, con);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            con.Close();
        }
        public static void DeleteSP(long masp)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format(@"DELETE SanPham WHERE [MaSP] = {0}", masp);
            SqlCommand command = new SqlCommand(sql, con);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}
