using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamplesOnArrays
{
    //// Program to Convert a 2D Array into 1D Array
    //class Program
    //{
    //    int m, n;
    //    int[,] a;
    //    int[] b;

    //    Program(int x, int y)
    //    {
    //        m = x;
    //        n = y;
    //        a = new int[m, n];
    //        b = new int[m * n];
    //    }

    //    public void readmatrix()
    //    {
    //        for (int i = 0; i < m; i++)
    //        {
    //            for (int j = 0; j < n; j++)
    //            {
    //                Console.WriteLine("a[{0},{1}]=", i, j);
    //                a[i, j] = Convert.ToInt32(Console.ReadLine());
    //            }
    //        }
    //    }

    //    public void printd()
    //    {
    //        for (int i = 0; i < m; i++)
    //        {
    //            for (int j = 0; j < n; j++)
    //            {
    //                Console.Write("{0}\t", a[i, j]);

    //            }
    //            Console.Write("\n");
    //        }
    //    }

    //    public void convert()
    //    {
    //        int k = 0;
    //        for (int i = 0; i < m; i++)
    //        {
    //            for (int j = 0; j < n; j++)
    //            {
    //                b[k++] = a[i, j];
    //            }
    //        }
    //    }

    //    public void printoned()
    //    {
    //        for (int i = 0; i < m * n; i++)
    //        {
    //            Console.WriteLine("{0}\t", b[i]);
    //        }
    //    }

    //    // In this program we read the elements of the 2-Dimensional matrix. 
    //    // Using for loop assign the value of ‘a[i,j]’ variable to b[] 
    //    // array variable. Increment the value of base index ‘k’ variable. 
    //    // Print the value of one dimensional array.

    //    public static void Main()
    //    {
    //        Program obj = new Program(2, 3);
    //        Console.WriteLine("Enter the Elements : ");
    //        obj.readmatrix();
    //        Console.WriteLine("\t\t Given 2-D Array(Matrix) is : ");
    //        obj.printd();
    //        obj.convert();
    //        Console.WriteLine("\t\t Converted 1-D Array is :");
    //        obj.printoned();

    //        Console.ReadLine();
    //    }
    //}

    //// Program to get the length of the Array
    //class Program
    //{
    //    static void Main()
    //    {
    //        int[] arrayA = new int[5];
    //        int lengthA = arrayA.Length;
    //        Console.WriteLine("Length of ArrayA : {0}", lengthA);

    //        long longLength = arrayA.LongLength;
    //        Console.WriteLine("Length of the LongLength Array : {0}", longLength);

    //        int[,] twoD = new int[5, 10];
    //        Console.WriteLine("The Size of 2D Array is : {0}", twoD.Length);
    //        Console.ReadLine();
    //    }
    //}

    //// Program to Get Lower Bound and Upper Bound of an Array
    //class Program
    //{
    //    static void Main()
    //    {
    //        Array stringArray = Array.CreateInstance(typeof(String), 6);
    //        stringArray.SetValue("Mango", 0);
    //        stringArray.SetValue("Orange", 1);
    //        stringArray.SetValue("Apple", 2);
    //        stringArray.SetValue("Grape", 3);
    //        stringArray.SetValue("Cherry", 4);
    //        stringArray.SetValue("Watermelon", 5);

    //        Console.WriteLine("The Lower Bound of the Array : {0}", 
    //                            stringArray.GetLowerBound(0).ToString());
    //        Console.WriteLine("The Upper Bound of the Array : {0}",
    //                        stringArray.GetUpperBound(0).ToString());
    //        Console.ReadLine();
    //    }
    //}

    // Program to Find the Rank of a given Array
    class Program
    {
        static void Main()
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
        }
    }
}

