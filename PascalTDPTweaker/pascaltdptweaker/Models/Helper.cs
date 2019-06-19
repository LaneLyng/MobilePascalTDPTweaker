using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTDPTweaker.Models
{
    public static class Helper
    {
        public static byte[] HexToDecString(string hexString)
        {
            if (hexString == null || (hexString.Length & 1) == 1)
            {
                throw new ArgumentException();
            }

            byte[] sb = new byte[hexString.Length / 2];
            int j = 0;

            for (var i = 0; i < hexString.Length; i += 2)
            {
                var hexChar = byte.Parse(hexString.Substring(i, 2), System.Globalization.NumberStyles.HexNumber);
                sb[j] = hexChar;
                j++;
            }
            return sb;
        }

        public static string HexToString(string hexString)
        {
            if (hexString == null || (hexString.Length & 1) == 1)
            {
                throw new ArgumentException();
            }

            var sb = new StringBuilder();

            for (var i = 0; i < hexString.Length; i += 2)
            {
                var hexChar = hexString.Substring(i, 2);
                sb.Append((char)Convert.ToByte(hexChar, 16));
            }
            return sb.ToString();
        }

        public static string ReverseTDP(string s)
        {
            string tdp = s.Substring(6, 2) + s.Substring(4, 2) + s.Substring(2, 2) + s.Substring(0, 2);
            return tdp;
        }

        public static string Spacing(string s)
        {
            string str = s.Substring(0, 2) + " " + s.Substring(2, 2) + " " + s.Substring(4, 2) + " " + s.Substring(6, 2);
            return str;
        }

        public static string ReverseTemp(string s)
        {
            string temp = s.Substring(2, 2) + s.Substring(0, 2);
            return temp;
        }
    }
}
