using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.Array
{
    internal class AddingArray
    {
        static void Mainn()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 1, 2, 3, 4, 5,6,7 };
            int length=a.Length;
            if (a.Length < b.Length)
            {
                length=b.Length;
            }
            for(int i=0; i<length; i++)
            {
                try
                {
                    Console.WriteLine(a[i] + b[i]);
                }
                catch (Exception e)
                {
                    if(a.Length<b.Length)
                    {
                        Console.WriteLine(b[i]);
                    }
                    else
                    {
                        Console.WriteLine(a[i]);
                    }

                }

            }
        }
    }
}
    