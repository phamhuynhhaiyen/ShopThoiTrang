using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuyenDTO
    {
        public QuyenDTO()
        {
        }

        public QuyenDTO(long maQuyen, string tenQuyen)
        {
            MaQuyen = maQuyen;
            TenQuyen = tenQuyen;
        }

        public long MaQuyen { get; set; }
        public string TenQuyen { get; set; }
    }
}
