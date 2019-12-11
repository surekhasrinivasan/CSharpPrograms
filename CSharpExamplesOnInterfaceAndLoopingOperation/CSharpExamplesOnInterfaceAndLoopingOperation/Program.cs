using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamplesOnInterfaceAndLoopingOperation
{
    //// Program to implement PhoneBook
    //class Program
    //{
    //   static void Main(string[] arg)
    //    {
    //        Hashtable tab = new Hashtable();
    //        string fileName;
    //        if(arg.Length > 0)
    //        {
    //            fileName = arg[0];
    //        }
    //        else
    //        {
    //            fileName = "phoneBook.txt";
    //        }
    //        StreamReader r = File.OpenText(fileName);
    //        string line = r.ReadLine();
    //        while(line != null)
    //        {
    //            int pos = line.IndexOf('=');
    //            string name = line.Substring(0, pos).Trim();
    //            long phone = Convert.ToInt64(line.Substring(pos + 1));
    //            tab[name] = phone;
    //            line = r.ReadLine();
    //        }
    //        r.Close();
    //        for (; ; )
    //        {
    //            Console.Write("Name : ");
    //            string name = Console.ReadLine().Trim();
    //            if (name == "")
    //                break;
    //            object phone = tab[name];
    //            if (phone == null)
    //                Console.WriteLine("-- Not Found in Phone Book");
    //            else
    //                Console.WriteLine(phone);
    //        }
    //    }
    //}

    //// Program to Implement for-each in Interface
    //class GrowableArray : IEnumerable
    //{
    //    object[] a;

    //    public GrowableArray(int size)
    //    {
    //        a = new object[size];
    //    }
    //    public GrowableArray() : this(8) { }
    //    void Grow()
    //    {
    //        object[] b = new object[2 * a.Length];
    //        Array.Copy(a, b, a.Length);
    //        a = b;
    //    }

    //    public object this[int i]
    //    {
    //        set
    //        {
    //            if (i >= a.Length) Grow();
    //            a[i] = value;
    //        }
    //        get
    //        {
    //            if (i >= a.Length) Grow();
    //            return a[i];
    //        }
    //    }
    //    public IEnumerator GetEnumerator()
    //    {
    //        return new GAEnumerator(a);
    //    }
    //    class GAEnumerator : IEnumerator
    //    {
    //        object[] a;
    //        int i = -1;
    //        public GAEnumerator(object[] a) { this.a = a; }
    //        public object Current
    //        {
    //            get
    //            {
    //                return a[i];
    //            }
    //        }
    //        public void Reset()
    //        {
    //            i = -1;
    //        }
    //        public bool MoveNext()
    //        {
    //            do i++;
    //            while (i < a.Length && a[i] == null);
    //            if (i == a.Length)
    //                return false;
    //            else return true;
    //        }
    //    }
    //}

    //class Test
    //{
    //    public static void Main()
    //    {
    //        GrowableArray a = new GrowableArray(2);
    //        a[0] = 0;
    //        a[1] = 1;
    //        a[3] = 3;
    //        foreach (object x in a) Console.Write(" " + x);
    //        Console.ReadLine();
    //    }
    //}    

    //// Program to calculate Acceleration
    //class Program
    //{
    //    public static void Main()
    //    {
    //        int velocity, time, acceleration;

    //        Console.WriteLine("Enter the Velocity: ");
    //        velocity = int.Parse(Console.ReadLine());

    //        Console.WriteLine("Enter the Time: ");
    //        time = int.Parse(Console.ReadLine());

    //        acceleration = velocity / time;
    //        Console.WriteLine("Acceleration : {0}", acceleration);
    //        Console.ReadLine();
    //    }
    //}

    // Program to find a number using Pythagoras Theorem
    class Program
    {
        public static void Main()
        {
            double num1, num2, result;
            Console.WriteLine("Enter the first value: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second value: ");
            num2 = double.Parse(Console.ReadLine());

            result = Math.Sqrt(num1 * num1 + num2 * num2);
            Console.WriteLine("The Other number is : {0}", result);
            Console.ReadLine();
        }
    }
}
