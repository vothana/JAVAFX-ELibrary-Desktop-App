using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entity.ENUM
{
    public class EnumCode
    {
        public enum ROLE
        {
            ADMIN,
            STUDENT
        }

        public enum BOOKSTATUS
        {
            FREE,
            BORROW
        }

        public enum UPLOAD
        {
            BOOK,
            STUDENT,
            PDF
        }
    }
}
