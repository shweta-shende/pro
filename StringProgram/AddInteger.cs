using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.StringProgram
{
    internal class AddInteger
    {
        static void Mainn()
        {
            string s = "b2c4d1";
            int sum = 0;
            char[]ch=s.ToCharArray();
            for(int i = 0; i < s.Length; i++)
            {
                if (ch[i] >='0' && ch[i] <= '9')
                {
                    sum = sum + (ch[i]-'0');
                }
            }
            Console.WriteLine(sum);
        }
    }
}
