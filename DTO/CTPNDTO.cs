using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTPNDTO
    {
        public CTPNDTO(long maphieu, long maSP, int soLuong, long giaNhap, long thanhTien)
        {
            MaPhieu = maphieu;
            MaSP = maSP;
            SoLuong = soLuong;
            GiaNhap = giaNhap;
            ThanhTien = thanhTien;
        }
        public CTPNDTO()
        {

        }
        public long MaPhieu { get; set; }
        public long MaSP { get; set; }
        public int SoLuong { get; set; }
        public long GiaNhap { get; set; }
        public long ThanhTien { get; set; }
    }
}
