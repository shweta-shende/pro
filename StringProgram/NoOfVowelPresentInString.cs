using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.StringProgram
{
    internal class NoOfVowelPresentInString
    {
        static void Mainn()
        {
            string s = "india";
            int count = 0;
            char[]ch=s.ToCharArray();
            for(int i = 0; i < ch.Length; i++)
            {
                if(ch[i] == 'a' || ch[i] == 'e' || ch[i] == 'i' || ch[i] == 'o' || ch[i] == 'u')
                {
                    count++;
                    Console.Write(ch[i]);
                }
            }
            Console.WriteLine("="+count);
            
        }
    }
}
