using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.Array
{
    internal class DescendingOrder
    {
        static void Maiin()
        {
            int[] a = { 2,5,8,9,1,6};
            Console.WriteLine("descending order");
            for(int i = 0; i < a.Length; i++)
            {
                for(int j=i+1;j<a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
                Console.WriteLine(a[i]);
            }
            
        }
    }
}
