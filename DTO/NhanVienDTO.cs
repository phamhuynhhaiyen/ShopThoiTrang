using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVienDTO
    {
        public NhanVienDTO(long maNV, string tenNV, long maQuyen, DateTime ngaySinh, string gioiTinh, string sDT, string matKhau)
        {
            MaNV = maNV;
            TenNV = tenNV;
            MaQuyen = maQuyen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            SDT = sDT;
            MatKhau = matKhau;
        }
        public NhanVienDTO()
        {

        }
        public long MaNV { get; set; }
        public string TenNV { get; set; }
        public long MaQuyen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }
        public string MatKhau { get; set; }
    }
}
