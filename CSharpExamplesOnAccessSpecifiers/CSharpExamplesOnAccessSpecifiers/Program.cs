﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamplesOnAccessSpecifiers
{
    //// Program to Illustrate the Use of Access Specifiers
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Two B = new Two();
    //        B.show();
    //    }
    //}

    //class One
    //{
    //    private int x;
    //    protected int y;
    //    internal int z;
    //    public int a;
    //    protected internal int b;
    //}

    //class Two : One
    //{
    //    public void show()
    //    {
    //        Console.WriteLine("Values are : ");
    //        //x = 10;
    //        y = 20;
    //        z = 30;
    //        a = 40;
    //        b = 50;

    //        //Console.WriteLine(x); // Error - x is not accessible 
    //        Console.WriteLine(y);
    //        Console.WriteLine(z);
    //        Console.WriteLine(a);
    //        Console.WriteLine(b);
    //        Console.ReadLine();
    //    }
    //}

    //// Program to Print a Diamond Using Nested Loop
    //class Program
    //{
    //    public static void Main()
    //    {
    //        int number, i, k, count = 1;

    //        Console.Write("Enter number of rows \n");
    //        number = int.Parse(Console.ReadLine());

    //        count = number - 1;
    //        for(k = 1; k <= number; k++)
    //        {
    //            for (i = 1; i <= count; i++)
    //                Console.Write(" ");
    //            count--;
    //            for (i = 1; i <= 2 * k - 1; i++)
    //                Console.Write("*");
    //            Console.WriteLine();
    //        }
    //        count = 1;
    //        for (k = 1; k <= number - 1; k++)
    //        {
    //            for (i = 1; i <= count; i++)
    //                Console.Write(" ");
    //            count++;
    //            for (i = 1; i <= 2 * (number - k) - 1; i++)
    //                Console.Write("*");
    //            Console.WriteLine();
    //        }
    //        Console.ReadLine();
    //    }
    //}

    // Program to Illustrate LeftShift Operations
    class Program
    {
        public static void Main()
        {
            int x = 1024 * 1024 * 1024;
            uint p = 1024 * 1024 * 1024;
            int y = -42;

            Console.WriteLine("Left Shift Operations : ");
            Console.WriteLine("{0}, {1}, {2}", x, x * 2, x<< 1);
            Console.WriteLine("{0}, {1}, {2}", p, p * 2, p << 1);
            Console.WriteLine("{0}, {1}, {2}", x, x * 4, x << 2);
            Console.WriteLine("{0}, {1}, {2}", p, p * 4, p << 2);
            Console.WriteLine("{0}, {1}, {2}", y, y * 1024 * 1024 * 64, x << 26);
            Console.ReadLine();
        }
    }
}
