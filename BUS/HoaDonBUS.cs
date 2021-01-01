using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonBUS
    {
        public static void InsertHoaDon(string sdt, long MaNV, DateTime NgayLap, long Tongtien)
        {
            DAO.HoaDonDAO.InsertHoaDon(sdt, MaNV, NgayLap, Tongtien);
        }

        public static long GetMaHD()
        {
            return DAO.HoaDonDAO.GetMaHD();
        }
        public static void InsertCTHD(CTHDDTO cthd)
        {
            DAO.HoaDonDAO.InsertCTHD(cthd);
        }
        public static DataTable GetAllHoaDon()
        {
            return DAO.HoaDonDAO.GetAllHoaDon();
        }
        public static DataTable GetCTHD(long mahd)
        {
            return DAO.HoaDonDAO.GetCTHD(mahd);
        }
        public static DataSet GetThangHD(int nam)
        {
            return DAO.HoaDonDAO.GetThangHD(nam);
        }
        public static DataTable GetNamHD()
        {
            return DAO.HoaDonDAO.GetNamHD();
        }
        public static DataTable GetHoaDon(long mahd)
        {
            return DAO.HoaDonDAO.GetHoaDon(mahd);
        }
        public static DataTable GetHoaDonTheoSDT(string sdt)
        {
            return DAO.HoaDonDAO.GetHoaDonTheoSDT(sdt);
        }
        public static long TongDoanhThu(long nam)
        {
            return DAO.HoaDonDAO.TongDoanhThu(nam);
        }


    }
}
