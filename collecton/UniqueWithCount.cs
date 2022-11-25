using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.collecton
{
    internal class UniqueWithCount
    {
        static void Mainnn()
        {
            int[] a = { 1, 2, 3, 3, 2, 4, 5 };
            System.Collections.Generic.HashSet<int> b = new HashSet<int>();
            for(int i = 0; i < a.Length; i++)
            {
                b.Add(a[i]);
            }
            foreach (int n in b)
            {
                int count = 0;
              
                count++;
                Console.WriteLine(n + " "+count);
            }
           
        }
        
    }
}
