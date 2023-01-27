using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
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

        public static string ToLowerCase(string a)
        {
            string result = "";
            for(int i = 0; i < a.Length; i++)
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

        public static string Voyelles(string a)
        {
            string voy = "";
            string list = "aeiouy";

            for (int i = 0; i < a.Length; i++)
            {
                foreach(char c in list)
                {
                    if (a[i].ToString() == ToLowerCase(c.ToString()))
                    {
                        voy += a[i];
                    }
                }
            }

            return voy;
        }
    }
}
