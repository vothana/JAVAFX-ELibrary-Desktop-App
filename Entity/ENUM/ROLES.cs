using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entity.ENUM
{
    public class User
    {
        public static string USERROLE;
    }

    public class StudentInfo
    {
        public static int ID;
        public static string studentName;
        public static string studentPic;
    }

    public enum ROLE{
        ADMIN,
        STUDENT
    }

}
