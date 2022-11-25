using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace pro.StringProgram
{
    internal class PallindromeString
    {
        static void Mainn()
        {
            string s = "abcdcba";
            char[] chars = s.ToCharArray();
            string rev = "";
            for(int i=chars.Length-1; i>=0; i--)
            {
                rev = rev + chars[i];    
            }
            if (rev.Equals(s))
            {
                Console.WriteLine("its pallindrome");
            }
            else
            {
                Console.WriteLine("It is not PallindromeString");
            }

        }
    }
}
