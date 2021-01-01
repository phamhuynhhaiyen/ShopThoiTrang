using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserDTO
    {
        public UserDTO()
        {
        }

        public UserDTO(long taiKhoan, string matKhau)
        {
            TaiKhoan = taiKhoan;
            MatKhau = matKhau;
        }

        public long TaiKhoan { get; set; }
        public string MatKhau { get; set; }
    }
}
