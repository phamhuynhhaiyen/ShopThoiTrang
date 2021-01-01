using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        public SanPhamDTO(long maSP, string tenSP, long maLoai, long maNCC, long soLuongTon, long giaBan)
        {
            MaSP = maSP;
            TenSP = tenSP;
            MaLoai = maLoai;
            MaNCC = maNCC;
            SoLuongTon = soLuongTon;
            GiaBan = giaBan;
        }
        public SanPhamDTO()
        {

        }
        public long MaSP { get; set; }
        public string TenSP { get; set; }
        public long MaLoai { get; set; }
        public long MaNCC { get; set; }
        public long SoLuongTon { get; set; }
        public long GiaBan { get; set; }
    }
}
