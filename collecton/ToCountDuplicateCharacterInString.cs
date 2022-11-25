using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.collecton
{
    internal class ToCountDuplicateCharacterInString
    {
        static void Mainn()
        {
            string s = "tester";
            char[]ch=s.ToCharArray();   
            System.Collections.Generic.HashSet<char> set = new System.Collections.Generic.HashSet<char>();
            for(int i = 0; i < s.Length; i++)
            {
                set.Add(ch[i]);
            }
            foreach(char c in set)
            {
                int count = 0;
                for(int i = 0; i < s.Length; i++)
                {
                    if(c == ch[i])
                    {
                        count++;
                    }
                }
                if(count == 1)
                {
                    Console.WriteLine(c+" "+count);
                }
            }
        }
    }
}
