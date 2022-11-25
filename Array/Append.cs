using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.Array
{
    internal class Append
    {
        //append 0 at the last
        static void Mainn()
        {
            int[] a = { 1, 2, 3, 0, 4, 0, 8, 0 };
            int m = 0;
            int n=a.Length-1;
            int[] temp = new int[a.Length];
           
        
            for(int i=0; i<a.Length; i++)
            {
                if (a[i] != 0)
                {
                    temp[m] = a[i];
                    m++;
                }
                else
                {
                    temp[n] = a[i];
                    n--;
                }
            }
            for(int j = 0; j < temp.Length; j++)
            {
                Console.WriteLine(temp[j]);
            }
        }
    }
}

