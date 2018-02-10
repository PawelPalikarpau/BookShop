using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ShopLibrary.ValidationsAndHelpers
{
    public static class Validations
    {
        public static bool IfEmptyField(string str)
        {
            if (str.Length < 1) return true;
            else return false;
        }

        public static bool IfFieldLessThanThree(string str)
        {
            if (str.Length < 3) return true;
            else return false;
        }

        public static bool IfFieldLessThanFour(string str)
        {
            if (str.Length < 4) return true;
            else return false;
        }

        public static bool IfPasswordsDoesntMatch(string pas1, string pas2)
        {
            if (pas1 != pas2) return true;
            else return false;
        }

        public static bool IsNumeric(string str)
        {
            Int64 number = 0;
            bool i = Int64.TryParse(str, out number);
            return i;
        }

        public static bool IsMoney(string str)
        {
            decimal number = 0;
            bool i = decimal.TryParse(str, out number);
            return i;
        }

        public static bool IsValidEmail(string newEmail)
        {
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            Match match = regex.Match(newEmail);
            if (match.Success)
                return true;
            else
                return false;
        }
    }
}
