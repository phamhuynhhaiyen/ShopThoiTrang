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
        public static DataSet GetThangPN(int nam)
        {
            return PhieuNhapDAO.GetThangPN(nam);
        }
        public static DataTable GetNamPN()
        {
            return PhieuNhapDAO.GetNamPN();
        }
        public static DataTable GetPhieuTheoNgay(DateTime NgayLap)
        {
            return PhieuNhapDAO.GetPhieuTheoNgay(NgayLap);
        }
        public static long TongChiPhi(long nam)
        {
            return DAO.PhieuNhapDAO.TongChiPhi(nam);
        }
    }
}
