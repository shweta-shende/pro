using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.Array
{
    internal class AscendingOrder
    {
        static void Mainm()
        {
            int[] a = { 3, 2, 1, 4, 5, 6, 7, 8 };
            for(int i = 0; i < a.Length; i++)
            {
                for(int j=0;j<a.Length;j++)
                {
                    if(a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("ascending order");
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
