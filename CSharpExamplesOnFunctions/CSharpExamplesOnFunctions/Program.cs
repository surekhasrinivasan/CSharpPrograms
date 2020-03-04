﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamplesOnFunctions
{
    // Examples on Predefined functions

    // Program to Reverse a String with Predefined Function
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of Elements you want to hold in an Array");
            string str = Console.ReadLine();
            int x = Int32.Parse(str);
            int[] arr = new int[x];

            Console.WriteLine("\n Enter the array elements : ");
            for(int i = 0; i < x; i++)
            {
                string str1 = Console.ReadLine();
                arr[i] = Int32.Parse(str1);
            }
            Array.Reverse(arr);
        }
    }
}
