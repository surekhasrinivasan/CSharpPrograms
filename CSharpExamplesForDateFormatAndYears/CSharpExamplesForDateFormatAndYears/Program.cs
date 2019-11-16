using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamplesForDateFormatAndYears
{
    //// Program to check whether the entered year is a leap year or not
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Program obj = new Program();
    //        obj.readdata();
    //        obj.leap();
    //    }

    //    int year;
    //    public void readdata()
    //    {
    //        Console.WriteLine("Enter the Year in Four Digits: ");
    //        year = Convert.ToInt32(Console.ReadLine());
    //    }

    //    public void leap()
    //    {
    //        if((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
    //        {
    //            Console.WriteLine("{0} is a Leap Year", year);
    //        }
    //        else
    //        {
    //            Console.WriteLine("{0} is not a Leap Year", year);
    //        }
    //    }
    //}

    //// Program to Display the Date in various Formats
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        DateTime date = new DateTime(2019, 11, 15);
    //        Console.WriteLine("Some Date Formats : ");
    //        Console.WriteLine("Date and Time: {0}", date);
    //        Console.WriteLine(date.ToString("yyyy-MM-dd"));
    //        Console.WriteLine(date.ToString("dd-MMM-yy"));
    //        Console.WriteLine(date.ToString("M/d/yyyy"));
    //        Console.WriteLine(date.ToString("M/d/yy"));
    //        Console.WriteLine(date.ToString("MM/dd/yyyy"));
    //        Console.WriteLine(date.ToString("MM/dd/yy"));
    //        Console.WriteLine(date.ToString("yy/MM/dd"));
    //        Console.Read();
    //    }
    //}

    // Program to compare two Dates
    class Program
    {
        static void Main(string[] args)
        {
            DateTime sd = new DateTime(2019, 06, 11);
            Console.WriteLine("Starting Date : {0}", sd);
            DateTime ed = sd.AddDays(10);
        }
    }
}
