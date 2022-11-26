using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class Server
    {
       private SqlConnection conn = null;
       private string ServerName = "VOTHANA-CHY\\SQLEXPRESS";
       private string DatabaseName = "MidtermDB";
       private string Table = "Product_Tbl";

        public SqlConnection Conn { get => conn;}
        public string ServerName1 { get => ServerName;}
        public string DatabaseName1 { get => DatabaseName;}
        public string Table1 { get => Table;}
    }

