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
    public class NhanVienBUS
    {
        public static DataTable GetAllNhanVien()
        {
            return NhanVienDAO.GetAllNhanVien();
        }
        public static int GetNhanVien(long manv)
        {
            return NhanVienDAO.GetNhanVien(manv);
        }
        public static void InsertNhanVien(NhanVienDTO nv)
        {
            NhanVienDAO.InsertNhanVien(nv);
        }
        public static void UpdateNhanVien(NhanVienDTO nv)
        {
            NhanVienDAO.UpdateNhanVien(nv);
        }
        public static void DeleteNhanVien(long manv)
        {
            NhanVienDAO.DeleteNhanVien(manv);
        }
        public static List<QuyenDTO> GetAllQuyen()
        {
            return NhanVienDAO.GetAllQuyen();
        }
    }
}
