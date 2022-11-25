using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.collecton
{
    internal class RemoveDuplicateCharacterInString
    {
        static void Mainn()
        {
            string s = "i love love bang bang city";
            string[]st=s.Split(' ');
            System.Collections.Generic.HashSet<string> set=new System.Collections.Generic.HashSet<string>();
            for(int i = 0; i < st.Length; i++)
            {
                set.Add(st[i]);
            }
            foreach(string s2 in set)
            {
                Console.Write(s2+" ");
            }
        }
    }
}
