using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.StringProgram
{
    internal class ReverseString
    {
        static void Mainn()
        {
            string s = "shweta";
            //char[]ch=s.ToCharArray();
            for(int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i]);
            }
        }
    }
}
