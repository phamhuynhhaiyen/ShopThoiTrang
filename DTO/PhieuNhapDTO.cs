using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapDTO
    {
        public PhieuNhapDTO(long maPN, long maNV, DateTime ngayLap, long tongTien)
        {
            MaPN = maPN;
            MaNV = maNV;
            NgayLap = ngayLap;
            TongTien = tongTien;
        }
        public PhieuNhapDTO()
        {

        }
        public long MaPN { get; set; }
        public long MaNV { get; set; }
        public DateTime NgayLap { get; set; }
        public long TongTien { get; set; }
    }
}
