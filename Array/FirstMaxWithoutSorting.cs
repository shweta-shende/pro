using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.Array
{
    internal class FirstMaxWithoutSorting
    {
        static void Mainm()
        {
            int[] a = { 1, 2, 3, 4, 5, 66, 77, 88, 99 };
            int fmax = a[0];
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i] > fmax)
                {
                    fmax = a[i];
                }
            }
            Console.WriteLine("first max value is "+fmax);    
        }
    }
}
