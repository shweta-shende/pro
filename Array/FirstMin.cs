using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.Array
{
    internal class FirstMin
    {
        static void Mainm()
        {
            int[] a = { 1, 2, 9, 3, 2 };
            int fmin = a[0];
            for(int i= 0; i < a.Length; i++)
            {
                if(a[i] < fmin)
                {
                    fmin = a[i];
                }
            }
            Console.WriteLine("first min is "+fmin);
        }
    }
}
