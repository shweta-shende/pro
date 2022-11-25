using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.Array
{
    internal class PrimeNo
    {
        static void Mainn()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            for(int i = 0; i < a.Length; i++)
            {
                int n=a[i];
                int j = 2;
                while (j <= n)
                {
                    if (n % j == 0)
                    {
                        break;
                    }
                    else
                    {
                        j++;
                    }
                    if(j == n)
                    {
                        Console.WriteLine(n);
                    }
                }
            }
        }
    }
}
