using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.collecton
{
    internal class RemoveDuplicate
    {
        static void Mainn()
        {
            int[] a = { 1, 3, 9, 6, 3, 6 };
            System.Collections.Generic.HashSet<int> b = new System.Collections.Generic.HashSet<int>();
            for(int i = 0; i < a.Length; i++)
            {
                b.Add(a[i]);
            }
            foreach(int n in b)
            {
                Console.Write(n+" ");
            }
        }
    }
}
