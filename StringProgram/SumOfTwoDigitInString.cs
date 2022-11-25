using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.StringProgram
{
    internal class SumOfTwoDigitInString
    {
        static void Mainn()
        {
            string s = "11b22n33n2";
            int sum = 0;
            int tsum = 0;
            char[]ch=s.ToCharArray();
            for(int i = 0; i < s.Length; i++)
            {
                if (ch[i]>='0' && ch[i] <= '9')
                {
                    int n=s.ToCharArray()[i]-48;
                    tsum = tsum * 10 + n;

                }
                else
                {
                    sum = sum + tsum;
                    tsum = 0;

                }

                
            }
            sum = sum + tsum;
            Console.WriteLine(sum);

        }
    }
}
