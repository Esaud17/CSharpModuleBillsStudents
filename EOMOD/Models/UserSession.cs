using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOMOD.Models
{
    class UserSession
    {
        public static bool Session { get; set; }
        public static String Name { get; set; }
        public static String StatusBar { get; set; }
        public static String User { get; set; }
        public static String Pwd { get; set; }
    }
}
