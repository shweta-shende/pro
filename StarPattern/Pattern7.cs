using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.StarPattern
{
    internal class Pattern7
    {
        static void Mainnn()
            
        {
            int a = 1;
            for(int i = 1; i <=5 ; i++)
            {
                for(int j = 5; j >i ; j--)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <=a ; k++)
                {
                    Console.Write("*");
                }
                a = a + 2;
                Console.WriteLine();

            }

        }
    }
}
