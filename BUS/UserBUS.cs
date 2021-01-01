using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class UserBUS
    {
        public static List<UserDTO> GetAllUser()
        {
            return UserDAO.GetAllUser();
        }
        public static string GetTenUser(long manv)
        {
            return UserDAO.GetTenUser(manv);
        }
    }
}
