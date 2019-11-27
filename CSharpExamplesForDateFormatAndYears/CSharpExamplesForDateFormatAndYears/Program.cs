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

    //// Program to compare two Dates
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        DateTime sd = new DateTime(2019, 06, 11);
    //        Console.WriteLine("Starting Date : {0}", sd);
    //        DateTime ed = sd.AddDays(10);
    //        Console.WriteLine("Ending Date : {0}", ed);
    //        if(sd < ed)
    //            Console.WriteLine("{0} Occurs Before {1}", sd, ed);
    //        Console.Read();
    //    }
    //}

    //// Program to Display the ATM Transaction
    //class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        int amount = 1000, deposit, withdraw;
    //        int choice, pin = 0, x = 0;
    //        Console.WriteLine("Enter your Pin Number : ");
    //        pin = int.Parse(Console.ReadLine());
    //        while (true)
    //        {
    //            Console.WriteLine("*********Welcome to ATM Service***************\n");
    //            Console.WriteLine("1. Check Balance\n");
    //            Console.WriteLine("2. Withdraw Cash\n");
    //            Console.WriteLine("3. Deposit Cash\n");
    //            Console.WriteLine("4. Quit\n");
    //            Console.WriteLine("**********************************************\n\n");
    //            Console.WriteLine("Enter your choice : ");
    //            choice = int.Parse(Console.ReadLine());
    //            switch (choice)
    //            {
    //                case 1:
    //                    Console.WriteLine("\n YOUR BALANCE IN $ : {0}", amount);
    //                    break;
    //                case 2:
    //                    Console.WriteLine("\n ENTER THE AMOUNT TO WITHDRAW: ");
    //                    withdraw = int.Parse(Console.ReadLine());
    //                    if(withdraw % 100 != 0)
    //                    {
    //                        Console.WriteLine("\n PLEASE ENTER THE AMOUNT IN MULTIPLES OF 100");
    //                    }
    //                    else if(withdraw > (amount - 500))
    //                    {
    //                        Console.WriteLine("\n INSUFFICIENT BALANCE");
    //                    }
    //                    else
    //                    {
    //                        amount = amount - withdraw;
    //                        Console.WriteLine("\n\n PLEASE COLLECT CASH");
    //                        Console.WriteLine("\n YOUR CURRENT BALANCE IS {0}", amount);
    //                    }
    //                    break;
    //                case 3:
    //                    Console.WriteLine("\n ENTER THE AMOUNT TO DEPOSIT : ");
    //                    deposit = int.Parse(Console.ReadLine());
    //                    amount = amount + deposit;
    //                    Console.WriteLine("YOUR BALANCE IS {0}", amount);
    //                    break;
    //                case 4:
    //                    Console.WriteLine("\n THANK YOU FOR USING ATM");
    //                    break;                   
    //                }
    //            Console.WriteLine("\n\n THANKS FOR USING OUR ATM SERVICE");
                
    //        }            
    //    }
    //}

    // Program to Generate Random Numbers 
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Some Random numbers that are generated are: ");
            for(int i = 1; i < 10; i++)
            {
                Randfunc();
            }
        }

        static Random r = new Random();
        static void Randfunc()
        {
            int n = r.Next();
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
