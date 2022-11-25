using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.StarPattern
{
    internal class Pattern4
    {
        static void Mainn()
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int j=5; j >i; j--)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();    

            }
        }
    }
}
