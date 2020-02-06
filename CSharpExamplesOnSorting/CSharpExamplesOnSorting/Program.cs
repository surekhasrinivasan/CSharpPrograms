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

    //// Program to Perform a Selection Sort
    //class Program
    //{
    //    static void Main()
    //    {
    //        int array_size = 10;
    //        int[] array = new int[10] { 100, 50, 20, 40, 10, 60, 80, 70, 90, 30 };
    //        Console.WriteLine("The Array before selection sort is : ");
    //        for(int i = 0; i < array_size; i++)
    //        {
    //            Console.WriteLine(array[i]);
    //        }

    //        int tmp, min_key;

    //        for(int j = 0; j < array_size; j++)
    //        {
    //            min_key = j;

    //            for(int k = j + 1; k < array_size; k++)
    //            {
    //                if(array[k] < array[min_key])
    //                {
    //                    min_key = k;
    //                }
    //            }
    //            // Interchange the value of array element using 
    //            // temporary variable ‘t’ and print the values.

    //            tmp = array[min_key];
    //            array[min_key] = array[j];
    //            array[j] = tmp;
    //        }

    //        Console.WriteLine("The array after selection sort is: ");
    //        for(int i =0; i < 10; i++)
    //        {
    //            Console.WriteLine(array[i]);
    //        }
    //        Console.ReadLine();
    //    }
    //}

    //// Program to Demonstrate Heap Sort
    //class Program
    //{
    //    int[] arr = { 2, 5, 1, 10, 6, 9, 3, 7, 4, 8 };

    //    public void print()
    //    {
    //        for(int i = 0; i < arr.Length; i++)
    //        {
    //            Console.WriteLine("{0}", arr[i]);
    //        }            
    //    }

    //    public void hsort()
    //    {
    //        int i, t;
    //        for(i = 5; i >= 0; i--)
    //        {
    //            adjust(i, 9);
    //        }
    //        for(i = 8; i >=0; i--)
    //        {
    //            t = arr[i + 1];
    //            arr[i + 1] = arr[0];
    //            arr[0] = t;
    //            adjust(0, i);
    //        }
    //    }

    //    public void adjust(int i, int n)
    //    {
    //        int t, j;
    //        try
    //        {
    //            t = arr[i];
    //            j = 2 * i;
    //            while(j <= n)
    //            {
    //                if (j < n && arr[j] < arr[j + 1])
    //                    j++;
    //                if (t >= arr[j])
    //                    break;
    //                arr[j / 2] = arr[j];
    //                j *= 2;
    //            }
    //            arr[j / 2] = t;
    //        }
    //        catch(IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine("Array out of bounds ", e);
    //        }
    //    }

    //    public static void Main()
    //    {
    //        Program obj = new Program();
    //        Console.WriteLine("Elements before sorting : ");
    //        obj.print();
    //        obj.hsort();
    //        Console.WriteLine("Elments after sorting : ");
    //        obj.print();
    //        Console.Read();
    //    }
    //}

    //// Program to Perform Bubble Sort
    //class Program
    //{
    //    static void Main()
    //    {
    //        int[] arr = { 3, 2, 1, 5, 4 };

    //        int t;
    //        Console.WriteLine("The Array before sorting is : ");
    //        for(int i = 0; i < arr.Length; i++)
    //        {
    //            Console.WriteLine(arr[i]);
    //        }

    //        for(int j = 0; j <= arr.Length - 2; j++)
    //        {
    //            for(int i = 0; i <= arr.Length - 2; i++)
    //            {
    //                if(arr[i] > arr[i + 1])
    //                {
    //                    t = arr[i + 1];
    //                    arr[i + 1] = arr[i];
    //                    arr[i] = t;
    //                }
    //            }
    //        }
    //        Console.WriteLine("The Sorted Array : ");
    //        foreach(int array in arr)
    //        {
    //            Console.Write(array + " ");
    //        }
    //        Console.ReadLine();
    //    }
    //}

    //// Program to Perform Insertion Sort
    //class Program
    //{
    //    static void Main()
    //    {
    //        int[] arr = new int[5] { 83, 12, 3, 34, 60 };
    //        int i;
    //        Console.WriteLine("The array before sorting : ");
    //        for(i = 0; i < 5; i++)
    //        {
    //            Console.WriteLine(arr[i]);
    //        }
    //        insertSort(arr, 5);
    //        Console.WriteLine("The sorted array is : ");
    //        for(i = 0; i < 5; i++)
    //        {
    //            Console.WriteLine(arr[i]);
    //        }
    //        Console.ReadLine();
    //    }

    //    // insertion sort() method is used to sort elements in ascending. 
    //    // The second element of an array is compared with the elements that
    //    // appear before it, only first element in this case. If the second
    //    // element is smaller than first element, second element is inserted in 
    //    // the position of the first element. 
    //    static void insertSort(int[] data, int n)
    //    {
    //        int i, j;
    //        for(i = 1; i < n; i++)
    //        {
    //            int item = data[i];
    //            int ins = 0;
    //            for(j = i - 1; j >=0 && ins != 1;)
    //            {
    //                if (item < data[j])
    //                {
    //                    data[j + 1] = data[j];
    //                    j--;
    //                    data[j + 1] = item;
    //                }
    //                else ins = 1;
    //            }
    //        }
    //    }
    //}

    //// Program to Perform Merge Sort
    //class Program
    //{
    //    static void Main()
    //    {
    //        int[] numbers = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
    //        int len = 9;
    //        Console.WriteLine("MergeSort : ");
    //        sortMethod(numbers, 0, len - 1);
    //        for(int i = 0; i < 9; i++)
    //            Console.WriteLine(numbers[i]);
    //        Console.Read();
    //    }

    //    public static void mergeMethod(int[] numbers, int left, int mid, int right)
    //    {
    //        int[] temp = new int[25];
    //        int i, left_end, num_elements, tmp_pos;
    //        left_end = (mid - 1);
    //        tmp_pos = left;
    //        num_elements = (right - left + 1);

    //        while ((left <= left_end) && (mid <= right))
    //        {
    //            if (numbers[left] <= numbers[mid])
    //                temp[tmp_pos++] = numbers[left++];
    //            else
    //                temp[tmp_pos++] = numbers[mid++];
    //        }

    //        while (left <= left_end)
    //            temp[tmp_pos++] = numbers[left++];
    //        while (mid <= right)
    //            temp[tmp_pos++] = numbers[mid++];
    //        for(i = 0; i < num_elements; i++)
    //        {
    //            numbers[right] = temp[right];
    //            right--;
    //        }
    //    }

    //    public static void sortMethod(int[] numbers, int left, int right)
    //    {
    //        int mid;
    //        if(right > left)
    //        {
    //            mid = (right + left) / 2;
    //            sortMethod(numbers, left, mid);
    //            sortMethod(numbers, (mid + 1), right);
    //            mergeMethod(numbers, left, (mid + 1), right);
    //        }
    //    }
    //}

    // Program to Implement Quick Sort
    class Program
    {

    }

    class quickSort
    {
        private int[] array = new int[20];
        private int len;

        public void QuickSort()
        {
            sort(0, len - 1);
        }

        public void sort(int left, int right)
        {
            int pivot, leftend, rightend;

            leftend = left;
            rightend = right;
            pivot = array[left];

            while(left < right)
            {
                while((array[right] >= pivot) && (left < right))
                {
                    right--;
                }
                if(left != right)
                {
                    array[left] = array[right];
                    left;
                }
            }
        }
    }
}
