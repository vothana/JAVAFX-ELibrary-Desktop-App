using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Server;

namespace Library.Database
{
    internal class Query
    {
        private SqlConnection conn = Server.Connection();

        public SqlDataReader QueryAll(string table)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + table, conn);
            SqlDataReader data = cmd.ExecuteReader();
            return data;
        }
        public SqlDataReader QueryBy(string table, string by,  string code)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + table + " WHERE " + by + " = " + code , conn);
            SqlDataReader data = cmd.ExecuteReader();
            return data;
        }

        public SqlDataReader QueryString(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader data = cmd.ExecuteReader();
            return data;
        }
    }
}
