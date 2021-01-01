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
    }
}
