using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro.collecton
{
    internal class Encap
    {
        private int atmPIN;
        public int getReturn()
        {
            return atmPIN;
        }
        public void setValue(int pin)
        {
            atmPIN = pin;
        }
    }
    class A
    {
        static void Mainn()
        {
            Encap e = new Encap();
            e.setValue(1111);
            Console.WriteLine(e.getReturn());
        }
    }
}
