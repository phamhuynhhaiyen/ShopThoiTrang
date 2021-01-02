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
        public static DataSet GetThangHD(int nam)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string cl =string.Format( @" SELECT MONTH(HoaDon.NgayLap) as Thang , sum(HoaDon.TongTien) as Tien  FROM  HoaDon  WHERE  YEAR(HoaDon.NgayLap) = {0} group by MONTH(HoaDon.NgayLap) ", nam);           
            SqlCommand cmd = new SqlCommand(cl, con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            con.Close();
            return ds;
        }
        public static DataTable GetHoaDon(long mahd)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format(@"SELECT MAHD, TENKH, TENNV, NGAYLAP, TongTien FROM HoaDon, KhachHang, NhanVien WHERE HoaDon.MaNV = NhanVien.MaNV AND HoaDon.SDT = KhachHang.SDT AND MAHD = {0}", mahd);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter command = new SqlDataAdapter(sql, con);
            DataTable dataTable = new DataTable();
            command.Fill(dataTable);
            return dataTable;
        }
        public static DataTable GetNamHD()
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();

            string sql = string.Format("SELECT YEAR(NGAYlAP) AS 'YEAR' FROM HoaDon GROUP BY YEAR(NgayLap)");
            SqlDataAdapter command = new SqlDataAdapter(sql, con);
            DataTable dataTable = new DataTable();
            command.Fill(dataTable);
            return dataTable;
            
        }
        public static DataTable GetHoaDonTheoSDT(string sdt)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format(@"SELECT MAHD, TENKH, TENNV, NGAYLAP, TongTien FROM HoaDon, KhachHang, NhanVien WHERE HoaDon.MaNV = NhanVien.MaNV AND HoaDon.SDT = KhachHang.SDT AND HoaDon.SDT = {0}", sdt);
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter command = new SqlDataAdapter(sql, con);
            DataTable dataTable = new DataTable();
            command.Fill(dataTable);
            return dataTable;
        }
        public static long TongDoanhThu(long nam)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format("select sum(TongTien) as Tong from HoaDon where Year(NgayLap) = {0}", nam);
            SqlCommand command = new SqlCommand(sql, con);
            var tong = command.ExecuteScalar();
            return (long)tong;
        }
        public static DataTable GetThangHDDGV(int nam)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format(@" SELECT MONTH(HoaDon.NgayLap) as Thang , sum(HoaDon.TongTien) as Tien  FROM  HoaDon  WHERE  YEAR(HoaDon.NgayLap) = {0} group by MONTH(HoaDon.NgayLap) ", nam);
            SqlDataAdapter command = new SqlDataAdapter(sql, con);
            DataTable dataTable = new DataTable();
            command.Fill(dataTable);
            return dataTable;           
        }

    }
}
