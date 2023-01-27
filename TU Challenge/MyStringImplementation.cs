using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static string BazardString(string input)
        {
            string result = "";
            string end = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                    result += input[i];
                else
                    end += input[i];
            }
            result += end;

            return result;
        }

        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            return string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input);
        }

        public static string MixString(string a, string b)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b)) throw new ArgumentException();

            string result = "";
            for (int i = 0; i < a.Length + b.Length; i++)
            {
                if (i < a.Length)
                    result += a[i];
                if (i < b.Length)
                    result += b[i];
            }
            return result;
        }

        public static string Reverse(string a)
        {
            char[] charArray = a.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string ToLowerCase(string a)
        {
            string result = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] >= 'A' && a[i] <= 'Z')
                {
                    result += (char)(a[i] + 32);
                }
                else if (a[i] == 'É') result += 'é';
                else result += a[i];
            }

            return result;
        }

        public static string UnBazardString(string input)
        {
            string result = "";
            string end = "";
            string start = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (i < input.Length / 2) start += input[i];
                else end += input[i];
            }
            for (int i = 0; i < input.Length / 2; i++)
            {
                result += start[i];
                result += end[i];
            }

            return result;
        }

        public static string Voyelles(string a)
        {
            string voy = "";
            string list = "aeiouyAEIOUY";

            for (int i = 0; i < a.Length; i++)
            {
                foreach (char c in list)
                {
                    if (a[i] == c && !voy.Contains(a[i]))
                    {
                        voy += ToLowerCase(c.ToString());
                    }
                }
            }

            return voy;
        }
    }
}
