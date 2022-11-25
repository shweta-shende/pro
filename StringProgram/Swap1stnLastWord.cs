using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.StringProgram
{
    internal class Swap1stnLastWord
    {
        static void Mainmm()
        {
            string s = "i love this city";
            string[]st= s.Split(" ");
            string temp = st[0];
            st[0] = st[st.Length - 1];
            st[st.Length - 1] = temp;
            for(int i = 0; i < st.Length; i++)
            {
                Console.WriteLine(st[i]+" ");
            }

        }
    }
}
