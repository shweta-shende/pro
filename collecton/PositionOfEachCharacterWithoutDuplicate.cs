using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.collecton
{
    internal class PositionOfEachCharacterWithoutDuplicate
    {
        static void Mainn()
        {
            string s = "tester";
            char[] ch = s.ToCharArray();
            System.Collections.Generic.HashSet<char> set = new System.Collections.Generic.HashSet<char>();
            for(int i = 0; i < s.Length ; i++)
            {
                set.Add(ch[i]);
            }
           foreach(char c in set)
            {
                for(int i = 0; i < s.Length ; i++)
                {
                    if(c == ch[i])
                    {
                        Console.WriteLine(c+" "+(i+1));
                        break;
                    }
                }
            }
        }
    }
}
