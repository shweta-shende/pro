using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.StarPattern
{
    internal class Pattern1
    {static void Mainn()
            {Console.WriteLine("Enter Employee name");
                string empname = Console.ReadLine();
                Console.WriteLine("Enter Employee type permanet or contractual");
                string emptype = Console.ReadLine();
                Console.WriteLine("Enter the yop of employee");
                int yop = Convert.ToInt32(Console.ReadLine());
                getEmpdetails(empname, emptype, yop);
 }  static void getEmpdetails(string empname, string emptype, int yop)
            {
                int sal = 200000;
                int sal2 = 300000;
                int sal3 = 400000;

                int sal4 = 150000;
                int sal5 = 250000;
                int sal6 = 300000;

                int empid = 0;
 if (emptype == "permanet" && yop < 2)
                {
                    Console.WriteLine(empname);
                    Console.WriteLine("salary" + sal);
                    empid++;
                    Console.WriteLine(empid);
                }
                else if (emptype == "permanet" && yop > 2 && yop < 5)
                {
                    Console.WriteLine(empname);
                    Console.WriteLine("sal " + sal2);
                    empid++;
                    Console.WriteLine(empid);
                }
                else if (emptype == "permanet" && yop > 5)
                {
                    Console.WriteLine(empname);
                    Console.WriteLine("sal " + sal3);
                    empid++;
                    Console.WriteLine(empid);
                }

                else if (emptype == "Contractual" && yop < 2)
                {
                    Console.WriteLine(empname);
                    Console.WriteLine("sal" + sal4);
                    empid++;
                    Console.WriteLine(empid);
                }
                else if (emptype == "Contractual" && yop > 2 && yop < 5)
                {
                    Console.WriteLine(empname);
                    Console.WriteLine("sal" + sal5);
                    empid++;
                    Console.WriteLine(empid);
                }
                else if (emptype == "Contractual" && yop > 5)
                {
                    Console.WriteLine(empname);
                    Console.WriteLine("sal" + sal6);
                    empid++;
                    Console.WriteLine(empid);
                }
            }
        }
    }
    

