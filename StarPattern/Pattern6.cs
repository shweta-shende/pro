using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.StarPattern
{
    internal class Pattern6
    {
        static void Mainn()
        {
            for(int i = 1; i <=5;i++)
            {
                for(int j = 1; j <= 5; j++)
                {
                    if(i == j || i==5 || j==1)
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
