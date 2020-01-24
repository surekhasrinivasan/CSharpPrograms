using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamplesOnSorting
{
    // Program to perform Radix Sort
    class Program
    {
        private int[] data;
        private IList<IList<int>> digits = new List<IList<int>>();
        private int maxLength = 0;

        public Program()
        {
            for(int i = 0; i < 10; i++)
            {
                digits.Add(new List<int>());
            }
            Console.WriteLine("Enter the Number of Records : ");
            int count = int.Parse(Console.ReadLine());
            data = new int[count];
            Console.ReadLine();
            for(int i =0; i < count; i++)
            {
                Console.Write("Enter Record {0} : ", i + 1);

                data[i] = int.Parse(Console.ReadLine());
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
