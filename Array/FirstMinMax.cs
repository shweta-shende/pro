using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.Array
{
    internal class FirstMinMax
    {
        static void Mainn()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7 };
            for(int i= 0; i < a.Length; i++)
            {
                for(int j = i; j < a.Length; j++)
                {
                    if(a[i]>a[j])
                    {
                        int temp=a[i];
                        a[i]=a[j];
                        a[j]=temp;
                    } 
                }

               
            }
            Console.WriteLine("max is " + a[a.Length - 1]);
            Console.WriteLine("min is " + a[0]);
        }
    }
}
