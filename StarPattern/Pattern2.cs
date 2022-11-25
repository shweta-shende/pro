using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.StarPattern
{
    internal class Pattern2
    {
        
        static void Mainnn()
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j=1; j <= 5; j++)
                {
                    if(i == j || (i + j) == 6)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
