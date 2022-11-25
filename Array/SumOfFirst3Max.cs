using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.Array
{
    internal class SumOfFirst3Max
    {
        static void Mainm()
        {
            int[] a = { 2, 4, 3, 6, 8, 7 };
            for(int i= 0; i < a.Length; i++)
            {
                for(int j = i; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            int sum = 0;
            for(int i= 0; i < 3; i++)
            {
                sum=sum+a[i];
            }
            Console.WriteLine(sum);
        }
    }
}
