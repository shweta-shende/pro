using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.Array
{
    internal class FirstAndSecondMax
    {
        static void Mainn()
        {
            int[] a = { 1, 7, 99, 55, 33 };
            int fmax = a[0];
            int smax = a[0];
            for(int i= 0; i <a.Length; i++)
            {
                if (a[i] > fmax)
                {
                    fmax = a[i];
                }
                else if (fmax==smax || a[i] > smax)
                {
                    smax = a[i];
                }
            }
            Console.WriteLine(fmax);
            Console.WriteLine(smax);

        }
    }
}
