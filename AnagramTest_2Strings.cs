using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Jim Morrison";
            string str2 = "Mr mojo risin";

            Console.WriteLine(Anagram(str1, str2));
        }

        public static bool Anagram(string str1, string str2)
        {
            if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
            {
                return false;
            }

            str1 = str1.Replace(" ", "");
            str2 = str2.Replace(" ", "");

            Console.WriteLine(str1);
            Console.WriteLine(str2);

            str1 = str1.ToLower();
            str2 = str2.ToLower();

            Console.WriteLine(str1);
            Console.WriteLine(str2);

            str1 = StringTools.Alphabetize(str1);
            str2 = StringTools.Alphabetize(str2);

            Console.WriteLine(str1);
            Console.WriteLine(str2);

            if (str1.Length == str2.Length)
            {
                if (str1.Contains(str2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
    }
    public class StringTools
    {
        /// <summary>
        /// Alphabetize the characters in the string.
        /// </summary>
        public static string Alphabetize(string s)
        {
            // 1.
            // Convert to char array.
            char[] a = s.ToCharArray();

            // 2.
            // Sort letters.
            Array.Sort(a);

            // 3.
            // Return modified string.
            return new string(a);
        }
    }
}
