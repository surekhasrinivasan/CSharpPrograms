using System;
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

    //// Program to Create a Gray Code
    //class Program
    //{
    //    // grayEncode() method - to convert the number into gray code
    //    public static ulong grayEncode(ulong n)
    //    {
    //        return n ^ (n >> 1);
    //    }

    //    // grayDecode() function - compute the binary left shift operator
    //    public static ulong grayDecode(ulong n)
    //    {
    //        ulong i = 1 << 8 * 64 - 2; // long is 64-bit
    //        ulong p, b = p = n & i;

    //        while ((i >>= 1) > 0)
    //            b |= p = n & i ^ p >> 1;
    //        return b;
    //    }

    //    public static void Main()
    //    {
    //        Console.WriteLine("Number\tGray");
    //        for(ulong i =0; i < 10; i++)
    //        {
    //            Console.WriteLine(string.Format("{0}\t{1}",i,Convert.ToString((long)grayEncode(i),2)));
    //        }
    //        Console.Read();
    //    }
    //}

    //// Program to Obtain the Character from the User and Convert the Case of the Character
    //class Program
    //{
    //    static void Main()
    //    {
    //        char a;
    //        int i;
    //        Console.WriteLine("Enter the Character : ");
    //        a = Convert.ToChar(Console.ReadLine());
    //        i = (int)a;
    //        if(a >= 65 && a <= 90)
    //        {
    //            Console.WriteLine("The Character is : {0}", char.ToLower(a));
    //        }
    //        else if(a >= 97 && a <= 122)
    //        {
    //            Console.WriteLine("The Character is : {0}", char.ToUpper(a));
    //        }
    //        Console.ReadLine();
    //    }
    //}

    //// Program to Convert a Given Number of Days in terms of Years, Weeks & Days
    //class Program
    //{
    //    static void Main()
    //    {
    //        int ndays, year, week, days, DAYSINWEEK = 7;
    //        Console.WriteLine("Enter the number of days : ");
    //        ndays = int.Parse(Console.ReadLine());
    //        year = ndays / 365;
    //        week = (ndays % 365) / DAYSINWEEK;
    //        days = (ndays % 365) % DAYSINWEEK;
    //        Console.WriteLine("{0} is equivalent to {1} years, {2} weeks and {3} days",
    //                            ndays, year, week, days);
    //        Console.ReadLine();
    //    }
    //}

    //// Program to Perform Currency Conversions
    //class Program
    //{
    //    static void Main()
    //    {
    //        int choice;
    //        Console.WriteLine("Enter your choice :\n 1 - Dollar to Rupee \n" +
    //                          " 2 - Euro to Rupee \n 3 - Malaysian Ringgit to Rupee ");
    //        choice = int.Parse(Console.ReadLine());

    //        switch (choice)
    //        {
    //            case 1:
    //                Double dollar, rupee, val;
    //                Console.WriteLine("Enter the Dollar Amount : ");
    //                dollar = double.Parse(Console.ReadLine());
    //                Console.WriteLine("Enter the Dollar value : ");
    //                val = double.Parse(Console.ReadLine());
    //                rupee = dollar * val;
    //                Console.WriteLine("{0} Dollar Equals {1} Rupees", dollar, rupee);
    //                break;
    //            case 2:
    //                Double Euro, rupe, valu;
    //                Console.WriteLine("Enter the Euro Amount : ");
    //                Euro = double.Parse(Console.ReadLine());
    //                Console.WriteLine("Enter the Euro value : ");
    //                valu = double.Parse(Console.ReadLine());
    //                rupe = Euro * valu;
    //                Console.WriteLine("{0} Euro Equals {1} Rupees", Euro, rupe);
    //                break;
    //            case 3:
    //                Double ringit, rup, value;
    //                Console.WriteLine("Enter the Ringgit Amount : ");
    //                ringit = double.Parse(Console.ReadLine());
    //                Console.WriteLine("Enter the Ringgit value : ");
    //                value = double.Parse(Console.ReadLine());
    //                rup = ringit * value;
    //                Console.WriteLine("{0} Malaysian Ringgit equals {1} Rupees", ringit, rup);
    //                break;
    //        }
    //        Console.ReadLine();
    //    }
    //}

    //// Program to Convert HexaDecimal Number to Decimal
    //class Program
    //{
    //    static void Main()
    //    {
    //        string Input;
    //        Console.WriteLine("Enter a Hexadecimal Number : ");
    //        Input = Console.ReadLine();
    //        int Output = int.Parse(Input, System.Globalization.NumberStyles.HexNumber);
    //        Console.WriteLine("The Decimal value is " + Output);
    //        Console.Read();
    //    }
    //}

    //// Program to Perform Decimal to HexaDecimal Conversion
    //class Program
    //{
    //    static void Main()
    //    {
    //        int decimalNumber, quotient;
    //        int i = 1, j, temp=0;
    //        char[] hexadecimalNumber = new char[100];
    //        char temp1;
    //        Console.WriteLine("Enter a Decimal Number : ");
    //        decimalNumber = int.Parse(Console.ReadLine());
    //        quotient = decimalNumber;
    //        while(quotient != 0)
    //        {
    //            temp = quotient % 16;
    //            if (temp < 10)
    //                temp = temp + 48;
    //            else
    //                temp = temp + 55;
    //            temp1 = Convert.ToChar(temp);
    //            hexadecimalNumber[i++] = temp1;
    //            quotient = quotient / 16;
    //        }
    //        Console.Write("Equivalent HexaDecimal Number is ");
    //        for(j = i -1; j > 0; j--)
    //            Console.Write(hexadecimalNumber[j]);
    //        Console.Read();
    //    }
    //}

    // Program to Perform Conversions of Meter to Kilometer and viceversa
    class Program
    {
        static void Main()
        {
            double m1 = 200;
            Console.WriteLine("Meter    ::    Kilometer");
            double k1 = ConvertDistance.cMtK(m1);
            Console.WriteLine("{0}    ::    {1}", m1, k1);
            double m4 = 3107;
            double k4 = ConvertDistance.cMtK(m4);
            Console.WriteLine("{0}   ::     {1}", m4, k4);
            double k3 = 5.1;
            Console.WriteLine();
            Console.WriteLine("Kilometer     ::     Meter");
            double m3 = ConvertDistance.cKtM(k3);
            Console.WriteLine("{0}           ::     {1}", k3, m3);
            double k2 = 3.219;
            double m2 = ConvertDistance.cKtM(k2);
            Console.WriteLine("{0}         ::    {1}", k2, m2);
            Console.Read();
        }
    }

    public static class ConvertDistance
    {
        public static double cMtK(double meters)
        {
            return meters / 1000;
        }

        public static double cKtM(double kilometers)
        {
            return kilometers * 1000;
        }
    }
}
