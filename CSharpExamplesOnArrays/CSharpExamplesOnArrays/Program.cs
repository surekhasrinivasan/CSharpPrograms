﻿using System;
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

        public void readmatrix()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("a[{0},{1}]=", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void printd()
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", a[i, j]);

                }
                Console.Write("\n");
            }
        }

        public void convert()
        {
            int k = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    b[k++] = a[i, j];
                }
            }
        }

    }
}
