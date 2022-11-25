using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.Array
{
    internal class randmm
    {
        
        
            static void Mainnn()
            {
            int a = 10;
            int b = 20;
            int c = a+b;
            Console.WriteLine(c);
                Random r = new Random();
                long l = r.Next() + r.Next() + r.Next();
                Console.WriteLine(l);
            }
        }
    }

