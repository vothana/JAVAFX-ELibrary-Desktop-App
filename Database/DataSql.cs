using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Server;

namespace Library.Database
{
    internal class DataSql
    {
        private SqlConnection conn = Server.Connection();

        public SqlDataReader QueryAll(string table)
        {
            handleConnStateOpen();
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + table, conn);
            SqlDataReader data = cmd.ExecuteReader();
            return data;
        }
        public SqlDataReader QueryBy(string table, string by, string code)
        {
            handleConnStateOpen();
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + table + " WHERE " + by + " = " + code, conn);
            SqlDataReader data = cmd.ExecuteReader();
            return data;
        }

        public SqlDataReader QueryString(string query)
        {
            handleConnStateOpen();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader data = cmd.ExecuteReader();
            return data;
        }

        public int GetMinID(string table, string id)
        {
            handleConnStateOpen();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT min(" + id + ") FROM " + table, conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }catch(Exception ex) { Console.WriteLine(ex.Message); };
            
            return 0;
        }
        public int GetMaxID(string table, string id)
        {
            handleConnStateOpen();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT max(" + id + ") FROM " + table, conn);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); };

            return 0;
        }

        public SqlDataReader Search(string table, string field, string searchText)
        {
            handleConnStateOpen();
            SqlCommand cmd = new SqlCommand("SELECT * FROM " + table + " WHERE " + field + " LIKE '%" + searchText + "%'", conn);
            SqlDataReader data = cmd.ExecuteReader();
            return data;
        }

        public bool delete(string table, string by, string code)
        {
            try
            {
                handleConnStateOpen();
                SqlCommand cmd = new SqlCommand("DELETE FROM " + table + " WHERE " + by + " = " + code, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); Console.WriteLine("Error" + ex.Message); return false; };
        }

        public bool mutaion(string method, string table, IDictionary<string, object> data, string by, string code )
        {
            handleConnStateOpen();
            SqlCommand cmd;
            string parameters = "";
            string values = "";
            int i = 1;
            if (method == "POST")
                foreach (KeyValuePair<string, object> entry in data)
                {
                    parameters += "[" + entry.Key + "]";
                    values += " @" + entry.Key;
                    if (i < data.Count) { 
                        parameters += " , ";
                        values += " , ";
                    }
                    i++;
                }
            else if (method == "PUT")
                foreach (KeyValuePair<string, object> entry in data)
                {
                    parameters += "[" + entry.Key + "]" + " = @" + entry.Key;
                    if (i < data.Count) { parameters += " , "; }
                    i++;
                }

            try
            {
                if (method == "POST")
                    cmd = new SqlCommand("INSERT INTO " + table + " ( " + parameters  + " ) VALUES ( " + values + " );", conn);
                else if (method == "PUT")
                    cmd = new SqlCommand("UPDATE " + table + " SET " + parameters + " WHERE " + by + " = " + code, conn);
                else
                    cmd = null;
                //MessageBox.Show("UPDATE " + table + " SET " + parameters + " WHERE " + by + " = " + code);

                foreach (KeyValuePair<string, object> entry in data)
                {
                    cmd.Parameters.AddWithValue(entry.Key, entry.Value);
                    // MessageBox.Show("cmd.Parameters.AddWithValue(" + entry.Key + " , " + entry.Value + " )");
                }
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex) {Console.WriteLine("Error" + ex.Message); return false; };
        }










        private void handleConnStateOpen()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Open();
            }
            else
            {
                conn.Open();
            }
        }
    }
}
