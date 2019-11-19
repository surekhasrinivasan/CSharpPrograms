﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamplesOnBitwiseAndSwappingOperations
{
    // Program to Accept the Height of a Person & Categorize as Taller, Dwarf and Average
    class Program
    {
        static void Main(string[] args)
        {
            float height;
            Console.WriteLine("Enter the Height (in centimeters) \n");
            height = int.Parse(Console.ReadLine());
            if(height < 150.0)
            {
                Console.WriteLine("Dwarf \n");
            }else if((height >= 150.0) && (height <= 165.0))
            {
                Console.WriteLine("Average Height \n");
            }
        }
    }
}
