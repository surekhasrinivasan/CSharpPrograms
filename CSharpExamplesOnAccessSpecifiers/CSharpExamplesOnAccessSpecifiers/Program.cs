using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamplesOnAccessSpecifiers
{
    // Program to Illustrate the Use of Access Specifiers
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class One
    {
        private int x;
        protected int y;
        internal int z;
        public int a;
        protected internal int b;
    }
}
