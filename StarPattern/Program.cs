using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.StarPattern
{
    public class Program
    {
        static void Mainn()
        {
            Console.WriteLine("enter employee name");
            string empname=Console.ReadLine();
            Console.WriteLine("enter employee type permanent or contractual");
            string emptype = Console.ReadLine();
           
            Console.WriteLine("enter year of exp of employee");
            int yop =Convert.ToInt32(Console.ReadLine());

            ProgramMethod(empname, emptype, yop);
            
            
        }
        static void ProgramMethod(string empname,string emptype,int yop)
        {

             int sal=200000;
            int sal1 = 300000;
            int sal2 = 400000;

            int sal3 = 150000;
            int sal4 = 250000;
            int sal5 = 300000;
            
            int empid = 0;
          
            if(emptype== "permanent" && yop < 2  )
            {
                Console.WriteLine(empname);
                Console.WriteLine(sal);
                empid++;
                Console.WriteLine(empid);
                
               


            }
            else if(emptype == "permanent" && yop > 2 && yop < 5 )
           {
               Console.WriteLine(empname);
               Console.WriteLine(sal1);
                empid++;
                Console.WriteLine(empid);
                
            }
           else if(emptype == "permanent" && yop >= 5)
            {
                Console.WriteLine(empname);
                Console.WriteLine(sal2);
                empid++;
                Console.WriteLine(empid);
                
            }
            else if(emptype == "contractual" && yop < 2)
            {
                Console.WriteLine(empname);
                Console.WriteLine(sal3);
                empid++;
                Console.WriteLine(empid);
                
            }
            else if (emptype == "contractual" && yop >= 2 && yop<5)
            {
                Console.WriteLine(empname);
                Console.WriteLine(sal4);
                empid++;
                Console.WriteLine(empid);
                
            }
            else if (emptype == "contractual" && yop >=5 )
            {
                Console.WriteLine(empname);
                Console.WriteLine(sal5);
                empid++;
                Console.WriteLine(empid);
                
            }
            




        }

    }
}
