using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTHDDTO
    {
        public CTHDDTO(long maHD, long maSP, int soLuong, long thanhTien)
        {
            MaHD = maHD;
            MaSP = maSP;
            SoLuong = soLuong;
            ThanhTien = thanhTien;
        }

        public long MaHD { get; set; }
        public long MaSP { get; set; }
        public int SoLuong { get; set; }
        public long ThanhTien { get; set; }
    }
}
