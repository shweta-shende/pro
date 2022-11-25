using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.StringProgram
{
    internal class MinLengthInString
    {
        static void Mainn()
        {
            string[] s = { "abcd", "abc", "ab", "a" };
            string minLength = s[0];
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i].Length < minLength.Length)
                {
                    minLength = s[i];
                }
            }
            for(int i = 0; i < s.Length; i++)
            {
                if(s[i].Length == minLength.Length)
                {
                    Console.WriteLine(s[i]);
                }
            }
        }
    }
}
