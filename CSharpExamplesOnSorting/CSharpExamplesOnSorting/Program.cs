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
            for(int i=0; i<10; i++)
            {
                digits.Add(new List<int>());
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
