using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entity.ENUM
{
    public static class CurrentPath
    {
        private static string currentDir;
        public static string CurrentDir { get => currentDir; set => currentDir = value; }
    }
}
