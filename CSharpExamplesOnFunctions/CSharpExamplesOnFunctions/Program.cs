using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamplesOnFunctions
{
    // Examples on Predefined functions

    //// Program to Reverse a String with Predefined Function
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter Number of Elements you want to hold in an Array");
    //        string str = Console.ReadLine();
    //        int x = Int32.Parse(str);
    //        int[] arr = new int[x];

    //        Console.WriteLine("\n Enter the array elements : ");
    //        for(int i = 0; i < x; i++)
    //        {
    //            string str1 = Console.ReadLine();
    //            arr[i] = Int32.Parse(str1);
    //        }
    //        Array.Reverse(arr);
    //        Console.WriteLine("Reversed Array :");
    //        for(int i = 0; i < x; i++)
    //        {
    //            Console.WriteLine("Element {0} is {1}", i+1, arr[i]);
    //        }
    //        Console.Read();
    //    }
    //}

    //// Program to Sort a String using Predefined Function
    //class Program
    //{
    //    public static void Main()
    //    {
    //        Console.WriteLine("Enter Number of elements you want to hold in the array : ");
    //        string str = Console.ReadLine();
    //        int x = Int32.Parse(str);
    //        int[] a = new int[x];
    //        Console.WriteLine("Enter Array elements : ");
    //        for(int i = 0; i < x; i++)
    //        {
    //            string s1 = Console.ReadLine();
    //            a[i] = Int32.Parse(s1);
    //        }
    //        Array.Sort(a);
    //        Console.WriteLine("Sorted Array : ");
    //        for(int i = 0; i < x; i++)
    //        {
    //            Console.WriteLine("{0}", a[i]);
    //        }
    //        Console.Read();
    //    }
    //}

    // Program to Demonstrate Boxing Operations
    class Program
    {
        int x = 10;
        object obj;
        void boxmethod()
        {
            Program p = new Program();
        }
    }
}
