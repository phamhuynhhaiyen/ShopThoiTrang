using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class PhieuNhapBUS
    {
        public static DataTable GetAllPhieuNhap()
        {
            return PhieuNhapDAO.GetAllPhieuNhap();
        }
        public static DataTable GetPhieuNhap(long maPN)
        {
            return PhieuNhapDAO.GetPhieuNhap(maPN);
        }
        public static void InsertPhieuNhap(long MaNV, DateTime NgayLap)
        {
            PhieuNhapDAO.InsertPhieuNhap(MaNV, NgayLap);
        }
        public static long GetMaPN()
        {
            return PhieuNhapDAO.GetMaPN();
        }
        public static void InsertCTPN(CTPNDTO ctpn)
        {
            PhieuNhapDAO.InsertCTPN(ctpn);
        }
        public static DataTable GetCTPN(long maPN)
        {
            return PhieuNhapDAO.GetCTPN(maPN);
        }
    }
}
