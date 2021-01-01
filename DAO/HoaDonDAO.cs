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
    public class HoaDonDAO
    {
        public static void InsertHoaDon(string sdt, long MaNV, DateTime NgayLap, long tongtien)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format(@"INSERT INTO HoaDon ([SDT], [MaNV], [NgayLap], [TongTien]) VALUES(N'{0}', {1}, N'{2}', {3})",sdt, MaNV, NgayLap, tongtien);
            SqlCommand command = new SqlCommand(sql, con);
            command.ExecuteNonQuery();
            con.Close();
        }
        public static void InsertCTHD(CTHDDTO cthd)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format(@"INSERT INTO CTHD VALUES({0}, {1}, {2}, {3})", cthd.MaHD, cthd.MaSP, cthd.SoLuong, cthd.ThanhTien);
            SqlCommand command = new SqlCommand(sql, con);
            command.ExecuteNonQuery();
            con.Close();
        }
        public static long GetMaHD()
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();

            SqlCommand command = new SqlCommand("SELECT TOP 1 (MaHD) FROM HoaDon ORDER BY MaHD DESC", con);
            var maPN = command.ExecuteScalar();
            return (long)maPN;
        }
        public static DataTable GetAllHoaDon()
        {
            SqlConnection con = dbConnection.HamKetNoi();
            string sql = string.Format(@"SELECT MaHD, TenKH, TenNV, NgayLap, TongTien FROM HoaDon, NhanVien, KhachHang WHERE HoaDon.MaNV = NhanVien.MaNV  AND KhachHang.SDT = HoaDon.SDT");
            con.Open();
            SqlDataAdapter command = new SqlDataAdapter(sql, con);
            DataTable dataTable = new DataTable();
            command.Fill(dataTable);
            return dataTable;

        }
        public static DataTable GetCTHD(long mahd)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            string sql = string.Format(@"SELECT CTHD.MaSP, TenSP, SoLuong, GiaBan, ThanhTien FROM CTHD, SanPham WHERE CTHD.MaSP = SanPham.MaSP AND MaHD IN (SELECT MaHD FROM HoaDon WHERE MaHD = {0})", mahd);
            con.Open();
            SqlDataAdapter command = new SqlDataAdapter(sql, con);
            DataTable dataTable = new DataTable();
            command.Fill(dataTable);
            return dataTable;

        }
    }
}
