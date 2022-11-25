using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.StringProgram
{
    public class MaxStringInArray
    {
        static void Mainn()
        {
            string[] s = { "abcdes","abcde","abcd","abc"};
            string maxLength = s[0];
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > maxLength.Length)
                {
                    maxLength = s[i];
                }
            }
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i].Length == maxLength.Length)
                {
                    Console.WriteLine(s[i]);
                }
            }
        }
    }
}
