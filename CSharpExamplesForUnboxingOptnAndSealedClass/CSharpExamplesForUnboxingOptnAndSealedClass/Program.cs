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

    // Program to create Sealed Class
    class Program
    {
        static void Main()
        {
            SealedClass sc = new SealedClass();
        }
    }

    sealed class SealedClass
    {
        public int x;
        public int y;
    }
}
