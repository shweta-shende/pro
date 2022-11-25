using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.Array
{
    internal class posOfEachNoDupli
    {
        static void Mainn()
        {
            int[] a = { 9, 2, 1, 8, 5,5,2 };
            for (int i = 0; i < a.Length; i++)
            {

                Console.WriteLine(a[i] + " " + (i + 1));
            }
        }
    }
}
