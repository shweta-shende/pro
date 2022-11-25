using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.StringProgram
{
    internal class Segregate
    {
        static void Mainmm()
        {
            string s = "a$23%2bgf*";
            string alpha = " ";
            string num = " ";
            string spc = " ";
            char[] ch = s.ToCharArray();
            for(int i=0; i < ch.Length; i++)
            {
                if(ch[i] >='A' && ch[i] <='Z' || ch[i]>='a' && ch[i] <= 'z')
                {
                    alpha=alpha+ch[i];
                }
                else if(ch[i]>='0' && ch[i] <= '9')
                {
                    num=num+ch[i];
                }
                else
                {
                    spc=spc+ch[i];
                }
               
            }
            Console.WriteLine(alpha+num+spc);
        }
    }
}
