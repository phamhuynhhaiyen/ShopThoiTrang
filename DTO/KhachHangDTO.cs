using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public KhachHangDTO()
        {
        }

        public KhachHangDTO(string sdt, string tenKH)
        {
            this.sdt = sdt;
            TenKH = tenKH;          
        }

        public string sdt { get; set; }
        public string TenKH { get; set; }
        

    }
}
