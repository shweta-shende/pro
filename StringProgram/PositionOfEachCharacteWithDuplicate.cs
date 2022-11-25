using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.StringProgram
{
    internal class PositionOfEachCharacteWithDuplicate
    {
        static void Mainnn()
        {
            string s = "tester";
            char[]ch=s.ToCharArray();
            for(int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(ch[i] + " " + (i + 1));
            }
            
            
        }
    }
}
