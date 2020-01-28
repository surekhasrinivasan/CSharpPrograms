using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamplesOnSorting
{
    //// Program to perform Radix Sort
    //class Program
    //{
    //    private int[] data;
    //    private IList<IList<int>> digits = new List<IList<int>>();
    //    private int maxLength = 0;

    //    public Program()
    //    {
    //        for(int i = 0; i < 10; i++)
    //        {
    //            digits.Add(new List<int>());
    //        }
    //        Console.WriteLine("Enter the Number of Records : ");
    //        int count = int.Parse(Console.ReadLine());
    //        data = new int[count];
    //        Console.ReadLine();
    //        for(int i =0; i < count; i++)
    //        {
    //            Console.Write("Enter Record {0} : ", i + 1);

    //            data[i] = int.Parse(Console.ReadLine());

    //            if (maxLength < data[i].ToString().Length)
    //                maxLength = data[i].ToString().Length;
    //        }
    //    }

    //    public void RadixSort()
    //    {
    //        for(int i = 0; i < maxLength; i++)
    //        {
    //            for(int j = 0; j < data.Length; j++)
    //            {
    //                int digit = (int)((data[j] % Math.Pow(10, i + 1)) / Math.Pow(10, i));
    //                digits[digit].Add(data[j]);
    //            }

    //            int index = 0;
    //            for(int k = 0; k < digits.Count; k++)
    //            {
    //                IList<int> selDigit = digits[k];

    //                for (int l = 0; l < selDigit.Count; l++)
    //                {
    //                    data[index++] = selDigit[l];
    //                }
    //            }
    //            ClearDigits();
    //        }
    //        printSortedData();
    //    }

    //    public void ClearDigits()
    //    {
    //        for(int k = 0; k < digits.Count; k++)
    //        {
    //            digits[k].Clear();
    //        }
    //    }

    //    public void printSortedData()
    //    {
    //        Console.WriteLine("The Sorted Numbers are : ");
    //        for(int i = 0; i < data.Length; i++)
    //        {
    //            Console.WriteLine(data[i]);
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        new Program().RadixSort();
    //        Console.ReadLine();
    //    }
    //}

    // Program to Perform a Selection Sort
    class Program
    {
        static void Main()
        {
            int array_size = 10;
            int[] array = new int[10] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };
            Console.WriteLine("The Array before selection sort is : ");
            for(int i = 0; i < array_size; i++)
            {
                Console.WriteLine(array[i]);
            }

            int tmp, min_key;

            for(int j = 0; j < array_size; j++)
            {
                min_key = j;

                for(int k = j + 1; k < array_size; k++)
                {
                    if(array[k] < array[min_key])
                    {
                        min_key = k;
                    }
                }
                tmp = array[min_key];
                array[min_key] = array[j];
                array[j] = tmp;
            }

            Console.WriteLine("The array after selection sort is: ");
            for(int i =0; i < 10; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }

}
