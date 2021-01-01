using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCapDTO
    {
        
            private long maNCC;
            private string tenNCC;
            private string diaChi;

            public NhaCungCapDTO(long maNCC, string tenNCC, string diaChi)
            {
                this.maNCC = maNCC;
                this.tenNCC = tenNCC;
                this.diaChi = diaChi;
            }

            public long MaNCC { get => maNCC; set => maNCC = value; }
            public string TenNCC { get => tenNCC; set => tenNCC = value; }
            public string DiaChi { get => diaChi; set => diaChi = value; }
        
    }
}
