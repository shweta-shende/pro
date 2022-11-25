using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.Array
{
    internal class AddArray
    {
        static void Mainn()
        {
            int[] a = { 2, 1, 4, 6, 8, 7 };
            int[] b = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < a.Length; i++) {
                Console.WriteLine(a[i] + b[i]);
                    }
        }
    }
}