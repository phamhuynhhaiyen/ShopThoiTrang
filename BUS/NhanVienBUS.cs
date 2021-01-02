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
        public static int GetNhanVien(long manv , string mk)
        {
            return NhanVienDAO.GetNhanVien(manv,mk);
        }
        public static int GetNhanVien(long manv)
        {
            return NhanVienDAO.GetNhanVien(manv);
        }
        public static void InsertNhanVien(long manv, string tennv, long maquyen, DateTime ngaysinh, string gioitinh, string sdt, string mk)
        {
            NhanVienDAO.InsertNhanVien(manv,tennv,maquyen,ngaysinh, gioitinh, sdt,mk);
        }
        public static void UpdateNhanVien(long manv, string tennv, long maquyen, DateTime ngaysinh, string gioitinh, string sdt)
        {
            NhanVienDAO.UpdateNhanVien(manv, tennv, maquyen, ngaysinh, gioitinh, sdt);
        }
        public static void DeleteNhanVien(long manv)
        {
            NhanVienDAO.DeleteNhanVien(manv);
        }
        public static List<QuyenDTO> GetAllQuyen()
        {
            return NhanVienDAO.GetAllQuyen();
        }
        public static string GetMKNhanVien(long manv)
        {
            return NhanVienDAO.GetMKNhanVien(manv);
        }
        public static string GetTenNhanVien(long manv)
        {
            return NhanVienDAO.GetTenNhanVien(manv);
        }
        public static void UpdateTaiKhoan(long manv, string mk)
        {
            NhanVienDAO.UpdateTaiKhoan(manv, mk);
        }
        public static long GetQuyenNhanVien(long manv)
        {
            return NhanVienDAO.GetQuyenNhanVien(manv);
        }
    }
}
