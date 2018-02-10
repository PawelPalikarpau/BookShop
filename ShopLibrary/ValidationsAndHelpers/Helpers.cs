using ShopLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ShopLibrary.ValidationsAndHelpers
{
    public static class Helpers
    {
        public static string RandomString()
        {
            Random random = new Random();
            const string input = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string output = "";
            
            for (int x = 0; x < 4; x++)
            {
                for (int i = 0; i < 4; i++)
                {
                    output += input[random.Next(0, input.Length)];
                }
                output += "-";
            }
            
            output = output.Substring(0, output.Length - 1);
            return output;
        }
    }
}
