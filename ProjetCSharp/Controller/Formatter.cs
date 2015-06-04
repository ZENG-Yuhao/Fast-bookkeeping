using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjetCSharp.Controller
{
    public class Formatter
    {
        public static bool EmailCheck(string email)
        {
            bool result;
            string pattern = @"^\S+@\S+.com$|^\S+@\S+.fr$";
            Regex rgx = new Regex(pattern);
            result = rgx.IsMatch(email);
            return result;
        }

        public static bool NumberCheck(string numStr)
        {
            bool result;
            string pattern = @"^\d+(.\d+)?$";
            Regex rgx = new Regex(pattern);
            result = rgx.IsMatch(numStr);
            return result;
        }
    }
}
