using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Utils
    {
        private Utils() { }

        public static bool StringToBool(string sValue)
        {
            if (sValue.Equals("YES"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static string BoolToString(bool isValue)
        {
            if (isValue)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }

        }
    }
}
