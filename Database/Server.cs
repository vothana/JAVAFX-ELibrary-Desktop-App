using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

 public static class Server
 {
    private static SqlConnection connection = null;
    private static string SERVER = "VOTHANA-CHY\\SQLEXPRESS";
    private static string DB = "ELIBRARY";

    
    public enum TABLE
    {
        BOOK,
        STUDENT,
        LOANLIST
    }



    public static SqlConnection Connection()
    {
        try
        {
            string connString = " Data Source = " + SERVER + "; Initial Catalog = " + DB + " ; Integrated Security = true";
            connection = new SqlConnection(connString);
            return connection;
        }
        catch (Exception ex)
        { 
            MessageBox.Show(ex.Message, "Connection Error");
            return null; 
        }
    }
}

