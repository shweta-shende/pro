using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.collecton
{
    internal class PositionOfEachWordInString
    {
        static void Mainn()
        {
            string s = "i love i love banglore city";
            string[]st=s.Split(' ');
            System.Collections.Generic.HashSet<string> set = new System.Collections.Generic.HashSet<string>();
            for(int i=0; i<st.Length; i++)
            {
                set.Add(st[i]);
            }
            foreach(string str in set)
            {
                for(int i=0; i<st.Length; i++)
                {
                    if (str.Equals(st[i]))
                    {
                        Console.WriteLine(str+" is present in "+(i+1)+" position");
                        break;

                    }
                }
            }
        }
    }
}
