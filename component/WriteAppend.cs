using Library.Entity.ENUM;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Library.component
{
    public class WriteToFile
    {
        public bool Write(string insertStatement)
        {
            string filePath = CurrentPath.CurrentDir + "SQL\\ELibrary.sql";
            DateTime now = DateTime.Now;
            string pcName = System.Environment.MachineName;

            try
            {
                // Checking the above file
                if (System.IO.File.Exists(filePath))
                {
                    List<string> list = new List<string>();
                    list = System.IO.File.ReadAllLines(filePath).ToList();
                    list.Add("\n--Modified by: " + pcName + " Generated:" + now);
                    list.Add(insertStatement);
                    System.IO.File.WriteAllLines(filePath, list);
                    return true;
                }
                else
                {
                    MessageBox.Show("File not exist : " + filePath);
                    return false;
                }
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
