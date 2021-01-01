using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhachHangBUS
    {
        public static string GetTEnKH(string sdt)
        {
            return DAO.KhachHangDAO.GetTenKhachHang(sdt);
        }
        public static List<KhachHangDTO> GetAllKH()
        {
            return DAO.KhachHangDAO.GetAllKH();
        }
        public static void InsertKhachHang(KhachHangDTO kh)
        {
            DAO.KhachHangDAO.InsertKhachHang(kh);
        }
    }
}
