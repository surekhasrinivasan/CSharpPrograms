﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamplesForUnboxingOptnAndSealedClass
{
    //// Program to display Squarefeet of a House 
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int length, width, area;
    //        Console.WriteLine("Enter the length of room in feet: ");
    //        length = Convert.ToInt32(Console.ReadLine());
    //        Console.WriteLine("Enter the width of room in feet: ");
    //        width = Convert.ToInt32(Console.ReadLine());

    //        area = length * width;
    //        Console.WriteLine("House is " + area + " square feet.");
    //        Console.ReadLine();
    //    }
    //}

    //// Program to create Sealed Class
    //class Program
    //{
    //    static void Main()
    //    {
    //        SealedClass sc = new SealedClass();
    //        sc.x = 100;
    //        sc.y = 180;
    //        Console.WriteLine("x = {0}, y = {1}", sc.x, sc.y);
    //        Console.ReadLine();
    //    }
    //}

    //sealed class SealedClass
    //{
    //    public int x;
    //    public int y;
    //}

    //// Program to perform Unboxing Operation 
    //class Program
    //{
    //    int data;
    //    void insert(object x)
    //    {
    //        data = (int)x * 5;            
    //    }
    //    object delete()
    //    {
    //        data = 0;
    //        return (object)data;
    //    }

    //    public static void Main()
    //    {
    //        Program p = new Program();
    //        p.insert(10);
    //        Console.WriteLine("Data : {0}", p.data);
    //        Console.WriteLine("Data : {0}", p.delete());
    //        Console.ReadLine();
    //    }        
    //}

    //// Program to display all the Prime Numbers between 1 to 100
    //class Program
    //{
    //    static void Main()
    //    {
    //        bool isPrime = true;
    //        Console.WriteLine("Prime Numbers: ");
    //        for (int i = 2; i <= 100; i++)
    //        {
    //            for (int j = 2; j <= 100; j++)
    //            {
    //                if (i != j && i % j == 0)
    //                {
    //                    isPrime = false;
    //                    break;
    //                }
    //            }
    //            if (isPrime)
    //            {
    //                Console.WriteLine("\t" + i);
    //            }
    //            isPrime = true;
    //        }
    //        Console.ReadKey();
    //    }
    //}

    // Program to accept a number from the User and display it if it is Positive
    class Program
    {

    }
}
