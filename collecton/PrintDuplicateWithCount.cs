using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.collecton
{
    internal class PrintDuplicateWithCount
    {
        static void Mainn()
        {
            int[] a = { 1, 1, 2, 2, 3, 4, 5, 5, };
            System.Collections.ArrayList a2 = new System.Collections.ArrayList();
            for(int i = 0; i < a.Length; i++)
            {
                a2.Add(a[i]);
            }
            foreach(int n in a2)
            {
                int count = 0;
                for (int i = 0; i<a.Length; i++)
                {
                    if (n ==a[i])
                    {
                       count++;
                        
                    }
                  

                }
                Console.WriteLine(n+" "+count);
                
            }
        }
    }
}
