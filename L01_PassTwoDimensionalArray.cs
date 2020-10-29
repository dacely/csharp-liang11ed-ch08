using System;
using System.Collections.Generic;
using System.Text;

namespace Liang_Ch08
{
    class L01_PassTwoDimensionalArray
    {
        public static void TestJagged()
        {
            int[][] m = GetJaggedArray();
            Console.WriteLine("Jagged Array: ");
            PrintJagged(m);
            Console.WriteLine("\nSum: {0:D}", SumJagged(m));
        }

        public static void TestRectangular()
        {
            int[,] m = GetRectangularArray();
            Console.WriteLine("Rectangular Array: ");
            PrintRectangularArray(m);
            Console.WriteLine("\nSum: {0:D}", SumRectangular(m));
        }

        private static int[][] GetJaggedArray()
        {
            int[][] jagArr = new int[5][];

            for (int i = 0; i < jagArr.Length; i++)
            {
                jagArr[i] = new int[i + 1];
                for (int j = 0; j < i + 1; j++)
                    jagArr[i][j] = i + j + 1;
            }

            return jagArr;
        }

        private static int SumJagged(int[][] jagArr)
        {
            int total = 0;

            for (int i = 0; i < jagArr.Length; i++)
                for (int j = 0; j < jagArr[i].Length; j++)
                    total += jagArr[i][j];

            return total;
        }

        private static void PrintJagged(int[][] jagArr)
        {
            foreach (int[] arr in jagArr)
            {
                foreach (int item in arr)
                    Console.Write($"{item,3:D}");

                Console.WriteLine();
            }
        }
    
        private static int[,] GetRectangularArray()
        {
            int[,] recArr = new int[3, 5];

            for (int i = 0; i < recArr.GetLength(0); i++)
                for (int j = 0; j < recArr.GetLength(1); j++)
                    recArr[i, j] = (j + 1) * (2 + i);
            
            return recArr;
        }

        private static int SumRectangular(int[,] recArr)
        {
            int sum = 0;

            for (int i = 0; i < recArr.GetLength(0); i++)
                for (int j = 0; j < recArr.GetLength(1); j++)
                    sum += recArr[i, j];

            return sum;
        }

        private static void PrintRectangularArray(int[,] recArr)
        {
            for (int i = 0; i < recArr.GetLength(0); i++)
            {
                for (int j = 0; j < recArr.GetLength(1); j++)
                    Console.Write($"{recArr[i,j],3:D}");

                Console.WriteLine();
            }
        }
    }
}
