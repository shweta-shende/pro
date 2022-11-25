using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.Array
{
    internal class PrintDuplicateWithCount
    {
        static void Mainn()
        {
            int[] a = { 4, 3, 1, 1, 3, 5 };
            Boolean f = false;
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if(a[i]==a[j])
                    {
                        count++;
                        Console.WriteLine("print duplicate element " + a[i]);
                        f=true;
                        
                    }
                    
                    
                }
                
                

                
            }
            Console.WriteLine(count);
           
           
        }
    }
}
