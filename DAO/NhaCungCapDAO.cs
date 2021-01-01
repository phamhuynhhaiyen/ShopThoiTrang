using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhaCungCapDAO
    {
        public static DataTable GetAllNCC()
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            SqlDataAdapter command = new SqlDataAdapter("SELECT * FROM NhaCungCap", con);
            DataTable dataTable = new DataTable();
            command.Fill(dataTable);
            return dataTable;

        }
       
        public static void InsertNCC(NhaCungCapDTO ncc)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format(@"INSERT INTO NhaCungCap VALUES({0}, N'{1}',N'{2}')", ncc.MaNCC, ncc.TenNCC, ncc.DiaChi);
            SqlCommand command = new SqlCommand(sql, con);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            con.Close();
        }
        public static int GetNCC(long MaNCC)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            string sql = string.Format(@"SELECT COUNT(*) FROM NhaCungCap WHERE [MaNCC] = {0}", MaNCC);
            con.Open();
            SqlCommand command = new SqlCommand(sql, con);
            object count = command.ExecuteScalar();
            return ((int)count);
            con.Close();

        }

        public static void UpdateNCC(NhaCungCapDTO ncc)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format(@"UPDATE NhaCungCap Set [TenNCC] = N'{1}', [DiaChi] = N'{2}' WHERE MaNCC= {0}", ncc.MaNCC, ncc.TenNCC, ncc.DiaChi);
            SqlCommand command = new SqlCommand(sql, con);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            con.Close();
        }
        public static void DeleteNCC(long mamcc)
        {
            SqlConnection con = dbConnection.HamKetNoi();
            con.Open();
            string sql = string.Format(@"DELETE FROM NhaCungCap WHERE MaNCC= {0}", mamcc);
            SqlCommand command = new SqlCommand(sql, con);
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}
