using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamplesOnNumericalOperations
{
    // Program to find Magnitude of integer
    class Program
    {
        public static void Main()
        {
            int num, magnitude = 0;
            Console.WriteLine("Enter the number: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Number: " +num);
            while (num > 0)
            {
                magnitude++;
                num = num / 10;
            };
            Console.WriteLine("Magnitude: " + magnitude);
            Console.Read();
        }
    }
}
