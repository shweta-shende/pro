using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.collecton
{
    internal class NoOfVowelInStringWitoutDuplicate
    {
        static void Mainn()
        {
            string s = "india";
            char[]ch=s.ToCharArray();
            System.Collections.Generic.HashSet<char> set = new System.Collections.Generic.HashSet<char>();
            for(int i = 0; i < ch.Length; i++)
            {
                set.Add(ch[i]);
            }
            int count = 0;
            foreach(char c in set)
            {
                if(c=='a' || c=='e' || c=='i' || c=='o' || c == 'u')
                {
                    count++;
                    Console.Write(c);
                }
            }
            Console.WriteLine(" = "+count);
        }
    }
}
