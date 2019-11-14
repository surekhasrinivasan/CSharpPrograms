using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamplesForDateFormatAndYears
{
    // Program to check whether the entered year is a leap year or not
    class Program
    {
        static void Main(string[] args)
        {
        }

        int year;
        public void readdata()
        {
            Console.WriteLine("Enter the Year in Four Digits: ");
            year = Convert.ToInt32(Console.ReadLine());
        }
    }
}
