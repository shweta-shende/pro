using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.Array
{
    internal class Min3rdNo
    {
        static void Mainm()
        {
            int[] a = { 2, 4, 3, 1, 5, 7, 9 };
            for(int i= 0; i < a.Length; i++)
            {
                for(int j=i;j<a.Length;j++)
                {
                    if(a[i] < a[j])
                    {
                        int temp=a[i];  
                        a[i]=a[j];
                        a[j]=temp;
                    }
                }
            }
            Console.WriteLine("3rd min no is " + a[a.Length-3]);
        }
    }
}
