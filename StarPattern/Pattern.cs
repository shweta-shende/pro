using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.StarPattern
{
    internal class Pattern
    {
        static void Mainnn()
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j= 1; j <= 5; j++)
                {
                    if(i==1 || i==5 || j==1 || j == 5)
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
