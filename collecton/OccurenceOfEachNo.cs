using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.collecton
{
    internal class OccurenceOfEachNo
    {
        static void Mainn()
        {
            int[] a = { 1, 2, 3, 4, 5, 5, 3 };
            System.Collections.Generic.HashSet<int> b = new HashSet<int>();
            for(int i = 0; i < a.Length; i++)
            {
                b.Add(a[i]);
            }
            foreach(int n in b)
            {
                int count = 0;
                for(int i = 0; i < a.Length; i++)
                {
                    if (n == a[i])
                    {
                        count++;    
                    }
                }
                Console.WriteLine(n+" occured "+count);
            }
        }
    }
}
