using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.collecton
{
    internal class PositionOfEachCharacterInString
        //without duplicate
    {
        static void Mainn()
        {
            string s = "tester";
            System.Collections.Generic.HashSet<char> set = new System.Collections.Generic.HashSet<char>();
            char[]ch=s.ToCharArray();
            for(int i = 0; i < s.Length; i++)
            {
                set.Add(ch[i]);
            }
            foreach(char c in set)
            {
                for(int i = 0; i<s.Length; i++)
                {
                    if(c == ch[i])
                    {
                        Console.WriteLine(c+" is present in "+(i+1)+" position ");
                        break;
                    }
                }
            }
        }
    }
}
