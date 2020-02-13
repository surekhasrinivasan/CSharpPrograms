﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamplesOnConversions
{
    //// Program to Perform Binary to Decimal Conversion
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int num, binary_value, decimal_value = 0, base_value = 1, rem;

    //        Console.WriteLine("Enter a Binary Number(1s and 0s) : ");
    //        num = int.Parse(Console.ReadLine()); // maximum five digits 
    //        binary_value = num;
    //        while(num > 0)
    //        {
    //            rem = num % 10;
    //            decimal_value = decimal_value + rem * base_value;
    //            num = num / 10;
    //            base_value = base_value * 2;
    //        }
    //        Console.WriteLine("The Binary number is : " + binary_value );
    //        Console.WriteLine("The Decimal number is : " + decimal_value);
    //        Console.ReadLine();
    //    }
    //}

    //// Program to Convert Decimal to Binary
    //class Program
    //{
    //    static void Main()
    //    {
    //        int num;
    //        Console.WriteLine("Enter a Number: ");
    //        num = int.Parse(Console.ReadLine());

    //        Console.WriteLine("The given decimal number is: " + num);
    //        int quot;
    //        string rem = "";
    //        while(num >= 1)
    //        {
    //            quot = num / 2;
    //            rem += (num % 2).ToString();
    //            num = quot;
    //        }
    //        string bin = "";
    //        for(int i = rem.Length - 1; i >= 0; i--)
    //        {
    //            bin = bin + rem[i];
    //        }
    //        Console.WriteLine("The Binary format for given number is {0}", bin);
    //        Console.Read();
    //    }
    //}

    //// Program to Convert Decimal to Octal
    //class Program
    //{
    //    public static void Main()
    //    {
    //        int decimalNum, quotient, i = 1, j;
    //        int[] octalNum = new int[100];

    //        Console.WriteLine("Enter a Decimal Number : ");
    //        decimalNum = int.Parse(Console.ReadLine());
    //        quotient = decimalNum;
    //        while(quotient != 0)
    //        {
    //            octalNum[i++] = quotient % 8;
    //            quotient = quotient / 8;
    //        }
    //        Console.Write("Equivalent Octal number is : ");
    //        for(j = i-1; j > 0; j--)
    //            Console.Write(octalNum[j]);
    //        Console.ReadLine();
    //    }
    //}

    //// Program to Perform Celsius to Fahrenheit Conversion
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int celsius, faren;
    //        Console.WriteLine("Enter the Temperature in Celsius(degree C) : ");
    //        celsius = int.Parse(Console.ReadLine());
    //        faren = (celsius * 9) / 5 + 32;
    //        Console.WriteLine("The Temperature in Fahrenheit is (degree F) : " + faren);
    //        Console.ReadLine();
    //    }
    //}

    //// Program to Convert Fahrenheit to Celsius 
    //class Program
    //{
    //    static void Main()
    //    {
    //        double celsius;
    //        Console.WriteLine("Enter the Temperature in Fahrenheit(degree F) : ");
    //        double fahrenheit = Convert.ToDouble(Console.ReadLine());
    //        celsius = (fahrenheit - 32) * 5 / 9;
    //        Console.WriteLine("The converted Celsius temperature is : " + celsius);
    //        Console.ReadLine();
    //    }
    //}

    // Program to Create a Gray Code
    class Program
    {
        // grayEncode() method - to convert the number into gray code
        public static ulong grayEncode(ulong n)
        {
            return n ^ (n >> 1);
        }

        // grayDecode() function - compute the binary left shift operator
        public static ulong grayDecode(ulong n)
        {
            ulong i = 1 << 8 * 64 - 2; // long is 64-bit
            ulong p, b = p = n & i;

            while ((i >>= 1) > 0)
                b |= p = n & i ^ p >> 1;
            return b;
        }

        public static void Main()
        {
            Console.WriteLine("Number\tGray");
            for(ulong i =0; i < 10; i++)
            {
                Console.WriteLine(string.Format("{0}\t{1}",i,Convert.ToString((long)grayEncode(i),2)));
            }
            Console.Read();
        }
    }
}
