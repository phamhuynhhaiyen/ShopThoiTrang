﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class PhieuNhapDAO
    {
        public static DataTable GetAllPhieuNhap()
        {
            SqlConnection con = dbConnection.HamKetNoi();
            string sql = string.Format(@"SELECT MaPhieuNhap, TenNV, NgayLap, TongTien FROM PhieuNhap, NhanVien WHERE PhieuNhap.MaNV = NhanVien.MaNV ");
            con.Open();
            SqlDataAdapter command = new SqlDataAdapter(sql, con);
            DataTable dataTable = new DataTable();
            command.Fill(dataTable);
            return dataTable;

        }
        public static DataTable GetPhieuNhap(long maPN)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            string sql = string.Format(@"SELECT MaPhieuNhap, TenNV, NgayLap, TongTien FROM PhieuNhap, NhanVien WHERE PhieuNhap.MaNV = NhanVien.MaNV AND MaPhieuNhap = {0}", maPN);
            con.Open();           
            SqlDataAdapter command = new SqlDataAdapter(sql, con);
            DataTable dataTable = new DataTable();
            command.Fill(dataTable);
            return dataTable;

        }
        public static void InsertPhieuNhap(long MaNV, DateTime NgayLap)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format(@"INSERT INTO PhieuNhap ([MaNV], [NgayLap]) VALUES({0}, N'{1}')", MaNV, NgayLap);
            SqlCommand command = new SqlCommand(sql, con);          
            command.ExecuteNonQuery();
            con.Close();
        }
        public static long GetMaPN()
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            
            SqlCommand command = new SqlCommand("SELECT TOP 1 (MaPhieuNhap) FROM PhieuNhap ORDER BY MaPhieuNhap DESC", con);
            var maPN = command.ExecuteScalar();
            return (long)maPN;
        }
        public static void InsertCTPN(CTPNDTO ctpn)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format(@"INSERT INTO CTPN ([MaPhieuNhap], [MaSP], [SoLuong], [GiaNhap], [ThanhTien]) VALUES({0}, {1}, {2}, {3}, {4})", ctpn.MaPhieu, ctpn.MaSP,ctpn.SoLuong,ctpn.GiaNhap, ctpn.ThanhTien);
            SqlCommand command = new SqlCommand(sql, con);
            command.ExecuteNonQuery();
            con.Close();
        }
        public static DataTable GetCTPN(long maPN)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            string sql = string.Format(@"SELECT CTPN.MaSP, TenSP, SoLuong, GiaNhap, ThanhTien FROM CTPN, SanPham WHERE CTPN.MaSP = SanPham.MaSP AND MaPhieuNhap IN (SELECT MaPhieuNhap FROM PhieuNhap WHERE MaPhieuNhap = {0})", maPN);
            con.Open();
            SqlDataAdapter command = new SqlDataAdapter(sql, con);
            DataTable dataTable = new DataTable();
            command.Fill(dataTable);
            return dataTable;
            
        }
        public static DataSet GetThangPN(int nam)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string cl = string.Format(@" SELECT MONTH(PhieuNhap.NgayLap) as ThangPN , sum(PhieuNhap.TongTien) as TienPN  FROM  PhieuNhap WHERE  YEAR(PhieuNhap.NgayLap) = {0} group by MONTH(PhieuNhap.NgayLap)", nam);
            SqlCommand cmd = new SqlCommand(cl, con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            con.Close();
            return ds;
        }
        public static DataTable GetNamPN()
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();

            string sql = string.Format("SELECT YEAR(NGAYlAP) AS 'YEAR' FROM PhieuNhap GROUP BY YEAR(NgayLap)");
            SqlDataAdapter command = new SqlDataAdapter(sql, con);
            DataTable dataTable = new DataTable();
            command.Fill(dataTable);
            return dataTable;

        }
        public static DataTable GetPhieuTheoNgay(DateTime NgayLap)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            string sql = string.Format(@"SELECT MaPhieuNhap, TenNV, NgayLap, TongTien FROM PhieuNhap, NhanVien WHERE PhieuNhap.MaNV = NhanVien.MaNV AND NgayLap = '{0}'", NgayLap);
            con.Open();
            SqlDataAdapter command = new SqlDataAdapter(sql, con);
            DataTable dataTable = new DataTable();
            command.Fill(dataTable);
            return dataTable;

        }
        public static long TongChiPhi(long nam)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format("select sum(TongTien) as Tong from PhieuNhap where Year(NgayLap) = {0}", nam);
            SqlCommand command = new SqlCommand(sql, con);
            var tong = command.ExecuteScalar();
            return (long)tong;
        }
        public static DataTable GetThangPNDGV(int nam)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format(@" SELECT MONTH(PhieuNhap.NgayLap) as ThangPN , sum(PhieuNhap.TongTien) as TienPN  FROM  PhieuNhap WHERE  YEAR(PhieuNhap.NgayLap) = {0} group by MONTH(PhieuNhap.NgayLap)", nam);
            SqlDataAdapter command = new SqlDataAdapter(sql, con);
            DataTable dataTable = new DataTable();
            command.Fill(dataTable);
            return dataTable;
        }
    }
}
