using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class dbConnection
    {
        public static SqlConnection HamKetNoi()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-OCUUTDBF\SQLEXPRESS;Initial Catalog=QLshopthoitrang;User ID=sa;Password=123");
            return con;
        }

    }
}
