using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.Array
{
    internal class MultiplicationOf1stThreeMax
    {
        static void Mainq()
        {
            int[] a = {2,3,5,7,8,9,10};
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = i; j < a.Length; j++)
                {
                    if(a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];    
                        a[j] = temp;
                    }
                }
            }
            int mul = 1;
            for(int i = 0; i < 3; i++)
            {
                mul=mul*a[i];
                
            }
            Console.WriteLine(mul);
        }
    }
}
