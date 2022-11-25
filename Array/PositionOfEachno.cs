using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.Array
{
    internal class PositionOfEachno
    {
        static void Maiin()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("position is "+i+" value is "+a[i]);
            }
        }
    }
}
