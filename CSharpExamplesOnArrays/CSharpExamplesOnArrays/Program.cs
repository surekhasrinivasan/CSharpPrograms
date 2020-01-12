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

    //// Program to Find the Rank of a given Array
    //class Program
    //{
    //    static void Main()
    //    {
    //        int[] arr = new int[5] { 1, 2, 3, 4, 5 };
    //        int[,] arr2 = new int[10, 3];

    //        // Function rank denotes the dimensions of the array 
    //        Console.WriteLine("Total dimensions of array is : " + arr.Rank);
    //        Console.WriteLine("Total dimensions of array is : " + arr2.Rank);
    //        Console.ReadLine();
    //    }
    //}

    //// Program to Demonstrate Jagged Arrays
    //class Program
    //{
    //    static void Main()
    //    {
    //        int[][] jag = new int[3][];
    //        jag[0] = new int[2];
    //        jag[0][0] = 11;
    //        jag[0][1] = 12;
    //        jag[1] = new int[1] { 11 };
    //        jag[2] = new int[3] { 14, 15, 16 };
    //        for(int i=0; i< jag.Length; i++)
    //        {
    //            int[] innerArray = jag[i];
    //            for(int a = 0; a < innerArray.Length; a++)
    //            {
    //                Console.WriteLine(innerArray[a] + " ");
    //            }
    //        }
    //        Console.Read();
    //    }
    //}

    //// Program to Get 2 Arrays as Input and Produce a 3rd Array by Appending one to other
    //class Program
    //{
    //    static void Main()
    //    {
    //        int[] arr1 = new int[5];
    //        int[] arr2 = new int[5];
    //        int[] arr3 = new int[arr1.Length + arr2.Length];

    //        Console.WriteLine("Enter any 5 elements for the First Array : ");
    //        for(int i = 0; i < 5; i++)
    //        {
    //            arr1[i] = int.Parse(Console.ReadLine());
    //        }

    //        Console.WriteLine("Enter any 5 elements for the Second Array : ");
    //        for (int i = 0; i < 5; i++)
    //        {
    //            arr2[i] = int.Parse(Console.ReadLine());
    //        }

    //        // Buffer.BlockCopy() function is used to merge two int arrays. 
    //        // This method acts upon bytes, not elements. Using foreach loop print 
    //        // the elements in third array after appending with first and second arrays.

    //        Buffer.BlockCopy(arr1, 0, arr3, 0, arr1.Length * sizeof(int));
    //        Buffer.BlockCopy(arr2, 0, arr3, arr1.Length * sizeof(int), arr2.Length * sizeof(int));

    //        Console.WriteLine("Elements in the Third array after appending" + " First and Second Arrays : ");
    //        foreach(int value in arr3)
    //        {
    //            Console.WriteLine(value);
    //        }
    //        Console.ReadLine();
    //    }
    //}

    //// Program to Search an element with Array Indices
    //class Program
    //{
    //    public static void Main()
    //    {
    //        int[] integers = { 0, 10, 100, 1000, 100000 };
    //        Console.WriteLine("Array indices and elements: ");
    //        for(int i = 0; i < integers.Length; i++)
    //        {
    //            Console.Write("[{0}]={1, -5}", i, integers[i]);
    //        }
    //        Console.WriteLine();
    //        FindObject(integers, 25);
    //        FindObject(integers, 1000);
    //        FindObject(integers, 2000000);
    //        Console.ReadLine();
    //    }

    //    public static void FindObject(Array arr, Object obj)
    //    {
    //        int index = Array.BinarySearch(arr, 0, arr.Length, obj);
    //        Console.WriteLine();
    //        if(index > 0)
    //        {
    //            Console.WriteLine("Object: {0} found at [{1}]", obj, index);
    //        }
    //        else if(~index == arr.Length)
    //        {
    //            Console.WriteLine("Object: {0} not found. " + 
    //                "No array object has a greater value.", obj);
    //            Console.WriteLine();
    //        }
    //        else
    //        {
    //            Console.WriteLine("Object: {0} not found. " +
    //                "Next larger object found at [{1}].", obj, ~index);
    //        }
    //    }
    //}

    //// Program to implement use of Indexers
    //class Program
    //{
    //    static void Main()
    //    {
    //        values newval = new values();
    //        newval[3] = 58;
    //        newval[5] = 60;

    //        for(int i = 0; i < 10; i++)
    //        {
    //            Console.WriteLine("Element #{0} = {1}", i, newval[i]);
    //        }
    //        Console.WriteLine("Press any key to Exit.");
    //        Console.ReadKey();
    //    }
    //}

    //class values
    //{
    //    private int[] val = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
    //    public int Length
    //    {
    //        get { return val.Length; }
    //    }
    //    public int this[int index]
    //    {
    //        get
    //        {
    //            return val[index];
    //        }
    //        set
    //        {
    //            val[index] = value;
    //        }
    //    }
    //}

    // Program to Find Minimum and Maximum of Numbers
    class Program
    {
        public static void Main()
        {
            int[] arr = { 10, -10, -20, 0, 15, 20, 30 };

        }
    }
}

