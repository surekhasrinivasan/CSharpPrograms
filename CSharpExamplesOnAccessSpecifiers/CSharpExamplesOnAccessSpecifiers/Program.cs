using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamplesOnAccessSpecifiers
{
    // Program to Illustrate the Use of Access Specifiers
    class Program
    {
        static void Main(string[] args)
        {
            Two B = new Two();
            B.show();
        }
    }

    class One
    {
        private int x;
        protected int y;
        internal int z;
        public int a;
        protected internal int b;
    }

    class Two : One
    {
        public void show()
        {
            Console.WriteLine("Values are : ");
            //x = 10;
            y = 20;
            z = 30;
            a = 40;
            b = 50;

            //Console.WriteLine(x); // Error - x is not accessible 
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
