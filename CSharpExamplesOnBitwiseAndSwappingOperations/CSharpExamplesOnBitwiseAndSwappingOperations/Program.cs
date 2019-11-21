using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamplesOnBitwiseAndSwappingOperations
{
    //// Program to Accept the Height of a Person & Categorize as Taller, Dwarf and Average
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        float height;
    //        Console.WriteLine("Enter the Height (in centimeters) \n");
    //        height = int.Parse(Console.ReadLine());
    //        if(height < 150.0)
    //        {
    //            Console.WriteLine("Dwarf \n");
    //        }
    //        else if((height >= 150.0) && (height <= 165.0))
    //        {
    //            Console.WriteLine("Average Height \n");
    //        }
    //        else if ((height >= 165.0) && (height <= 195.0))
    //        {
    //            Console.WriteLine("Taller \n");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Abnormal height \n");
    //        }
    //    }
    //}

    //// Program to Find the Frequency of the Word ʺtheʺ in a given Sentence
    //class Program
    //{
    //    public static void Main()
    //    {
    //        string str;
    //        Console.WriteLine("Enter the String : ");
    //        str = Console.ReadLine();
    //        Console.WriteLine(Counting.CountStringOccurrences(str, "the"));
    //        Console.ReadLine();
    //    }
    //}

    //public static class Counting
    //{
    //    public static int CountStringOccurrences(string text, string pattern)
    //    {
    //        int count = 0, i = 0;
    //        while((i = text.IndexOf(pattern, i)) != -1)
    //        {
    //            i += pattern.Length;
    //            count++;
    //        }
    //        return count;
    //    }
    //}

    // Program to Swap the Contents of two Numbers using Bitwise XOR Operation
    class Program
    {
        public static void Main()
        {
            int num1, num2;
            Console.WriteLine("Enter two integers : ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n Before swapping num1 = {0} and num2 = {1}", num1, num2);
            num1 = num1 ^ num2;
            num2 = num1 ^ num2;
            num1 = num1 ^ num2;
            Console.WriteLine("\n After swapping num1 = {0} and num2 = {1}", num1, num2);
            Console.ReadLine();
        }
    }
}
