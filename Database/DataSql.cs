using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Database
{
    internal class DataSql
    {
        private SqlConnection conn = Server.Connection();

        public SqlDataReader QueryAll(string table)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + table, conn);
            SqlDataReader data = cmd.ExecuteReader();
            return data;
        }
        public SqlDataReader QueryBy(string table, string by, string code)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + table + " WHERE " + by + " = " + code, conn);
            SqlDataReader data = cmd.ExecuteReader();
            return data;
        }

        public SqlDataReader QueryString(string query)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader data = cmd.ExecuteReader();
            return data;
        }

        public int GetMinID(string table)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT min(ID) FROM " + table, conn);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            return id;
        }

        public SqlDataReader Search(string table, string field, string searchText)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + table + " WHERE " + field + " LIKE '%" + searchText + "%'", conn);
            SqlDataReader data = cmd.ExecuteReader();
            return data;
        }
    }
}
