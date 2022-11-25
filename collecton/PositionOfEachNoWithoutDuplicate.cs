using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.collecton
{
    internal class PositionOfEachNoWithoutDuplicate
    {
        static void Mainn()
        {
            int[] a = { 1, 2, 2, 3, 3, 4, 5, 6 };
            System.Collections.Generic.HashSet<int> b = new System.Collections.Generic.HashSet<int>();
            for(int i = 0; i < a.Length; i++)
            {
                b.Add(a[i]);
            }
            foreach(int n in b)
            {
                for(int i = 0; i < a.Length; i++)
                {
                    if(n == a[i])
                    {
                        Console.WriteLine(n+" "+(i+1));
                        break;
                    }
                }
            }
        }
    }
}
