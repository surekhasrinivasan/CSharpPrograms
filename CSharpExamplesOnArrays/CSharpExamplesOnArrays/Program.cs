using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamplesOnArrays
{
    // Program to Convert a 2D Array into 1D Array
    class Program
    {
        int m, n;
        int[,] a;
        int[] b;

        Program(int x, int y)
        {
            m = x;
            n = y;
            a = new int[m, n];
            b = new int[m * n];
        }
    }
}
