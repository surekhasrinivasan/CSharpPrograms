
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamplesForMathematicalOperations
{
    //// Program to Check whether the Entered Number is Even or Odd
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int i;
    //        Console.Write("Enter a Number: ");
    //        i = int.Parse(Console.ReadLine());

    //        if(i % 2 == 0)
    //        {
    //            Console.Write("Entered Number is an Even number");
    //            Console.Read();
    //        }
    //        else
    //        {
    //            Console.Write("Entered Number is an Odd Number");
    //            Console.Read();
    //        }
    //    }
    //}

    //// Program to Swap 2 numbers 
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int num1, num2, temp;
    //        Console.Write("Enter the First Number: ");
    //        num1 = int.Parse(Console.ReadLine());
    //        Console.Write("Enter the Second Number: ");
    //        num2 = int.Parse(Console.ReadLine());
    //        temp = num1;
    //        num1 = num2;
    //        num2 = temp;
    //        Console.Write("After Swapping : ");
    //        Console.Write("\nFirst Number: " + num1);
    //        Console.Write("\nSecond Number: " + num2);
    //        Console.Read();
    //    }
    //}

    //// Program to Get a number and display the sum of the digits 
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int sum = 0, num, remainder;
    //        Console.Write("Enter a Number : ");
    //        num = int.Parse(Console.ReadLine());
    //        while(num != 0)
    //        {
    //            remainder = num % 10;
    //            num = num / 10;
    //            sum = sum + remainder;
    //        }
    //        Console.WriteLine("The sum of the digits of the Number is : " + sum);
    //        Console.ReadLine();
    //    }
    //}

    // Program to Get a Number and Display the NUmber with its Reverse
    class Program
    {
        static void Main(string[] args)
        {
            int num, reverse = 0;
            Console.WriteLine("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            while(num != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + num % 10;
                num = num / 10;
            }
            Console.WriteLine("Reverse of Entered Number is " + reverse);
            Console.ReadLine();
        }
    }
}
