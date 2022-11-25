
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.Array
{
    internal class FirstAndSecondMin
    {
        static void Mainne()
        {
            int[] a = { 3, 2, 7, 9, 8 };
            int fmin = a[0];
            int smin = a[0];
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i] <= fmin)
                {
                    if (a[i] != fmin)
                    {
                        smin = fmin;
                    }
                    fmin = a[i];
                }
                else if(fmin==smin || a[i] < smin)
                {
                    smin=a[i];
                }
            }
            Console.WriteLine("1st min "+fmin);
            Console.WriteLine("2nd min "+smin);
        }
    }
}
