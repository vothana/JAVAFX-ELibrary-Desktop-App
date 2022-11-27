using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Database
{
    internal class Query
    {
        private SqlConnection conn = null;
        private string ServerName = "VOTHANA-CHY\\SQLEXPRESS";
        private string DatabaseName = "MidtermDB";
        private string Table = "Product_Tbl";

        public void openConnection()
        {
            try
            {
                string connString = " Data Source = " + ServerName + "; Initial Catalog = " + DatabaseName + " ; Integrated Security = true";
                conn = new SqlConnection(connString);
                conn.Open();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Connection Error"); }
        }

    }
}
