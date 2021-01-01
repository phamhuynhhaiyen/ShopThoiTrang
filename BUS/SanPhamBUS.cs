using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class SanPhamBUS
    {
        public static DataTable GetAllSanPham()
        {
            return SanPhamDAO.GetAllSanPham();
        }
        public static DataTable GetAllLoai()
        {
            return SanPhamDAO.GetAllLoai();
        }
        public static string GetTenSP(long masp)
        {
            return SanPhamDAO.GetTenSanPham(masp);
        }
        public static long GetGiaSanPham(long maSP)
        {
            return SanPhamDAO.GetGiaSanPham(maSP);

        }
        public static int GetSoLuongTon(long maSP)
        {
            return SanPhamDAO.GetSoLuongTon(maSP);
        }
        public static void InsertSP( string ten, long maloai, long ncc)
        {
            SanPhamDAO.InsertSP(ten, maloai, ncc);
        }
        public static void DeleteSP(long masp)
        {
            SanPhamDAO.DeleteSP(masp);
        }
    }
}
