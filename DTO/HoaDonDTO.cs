using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        public HoaDonDTO(long maHD, string sdt, DateTime ngayLap, long tongTien)
        {
            MaHD = maHD;
            this.sdt = sdt;
            NgayLap = ngayLap;
            TongTien = tongTien;
            
        }

        public long MaHD { get; set; }
        public string sdt { get; set; }
        DateTime NgayLap { get; set; }
        public long TongTien { get; set; }
        
    }
}
