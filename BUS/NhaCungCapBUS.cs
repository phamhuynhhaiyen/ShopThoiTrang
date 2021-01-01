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
    public class NhaCungCapBUS
    {
        public static DataTable GetAllNCC()
        {
            return NhaCungCapDAO.GetAllNCC();
        }
        public static void InsertNCC(NhaCungCapDTO ncc)
        {
            NhaCungCapDAO.InsertNCC(ncc);
        }
        public static void UpdateNCC(NhaCungCapDTO ncc)
        {
            NhaCungCapDAO.UpdateNCC(ncc);
        }
        public static void DeleteNCC(long mancc)
        {
            NhaCungCapDAO.DeleteNCC(mancc);
        }
        public static int GetNCC(long MaNCC)
        {
            return NhaCungCapDAO.GetNCC(MaNCC);
        }
    }
}
