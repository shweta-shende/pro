using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.collecton
{
    internal class OccurenceOfEachNoInString
    {
        static void Mainn()
        {
            string s = "i love i love bang city";
            string[]st=s.Split(' ');
            System.Collections.Generic.HashSet<string> set = new System.Collections.Generic.HashSet<string>();
            for(int i=0; i<st.Length; i++)
            {
                set.Add(st[i]);
            }
            foreach(string str in set)
            {
                int count = 0;
                for(int i=0; i<st.Length; i++)
                {
                    if (str.Equals(st[i]))
                    {
                        count++;
                    }
                }
                Console.WriteLine(str+" = is repeating "+count+"time");
            }
        }
    }
}
