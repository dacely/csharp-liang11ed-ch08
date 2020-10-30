using System;
using System.Collections.Generic;
using System.Text;

namespace Liang_Ch08
{
    class L03_FindNearestPoints
    {
        public static void Execute()
        {
            Random random = new Random();
            const int NUMBER_OF_POINTS = 100;
            double[,] points = new double[NUMBER_OF_POINTS, 2];

            for (int i = 0; i < NUMBER_OF_POINTS; i++)
            {
                points[i, 0] = 20 * random.NextDouble() - 10;
                points[i, 1] = 20 * random.NextDouble() - 10;
                Console.WriteLine("Point {0, 2}: ({1, 5:F2}, {2, 5:F2})", i, points[i, 0], points[i, 1]);
            }

            int p1 = 0;
            int p2 = 1;
            double shortestDistance = Distance(points[p1, 0], points[p1, 1], points[p2, 0], points[p2, 1]);
            int totalComparisons = 0;

            for (int i = 0; i < NUMBER_OF_POINTS; i++)
            {
                for (int j = i + 1; j < NUMBER_OF_POINTS; j++)
                {
                    double d = Distance(points[i, 0], points[i, 1], points[j, 0], points[j, 1]);

                    if (d < shortestDistance)
                    {
                        shortestDistance = d;
                        p1 = i;
                        p2 = j;
                    }

                    ++totalComparisons;
                }
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("Closest two points:");
            Console.WriteLine("\tPoint {0, 2:D2}: ({1, 5:F2}, {2, 5:F2})", p1, points[p1, 0], points[p1, 1]);
            Console.WriteLine("\tPoint {0, 2:D2}: ({1, 5:F2}, {2, 5:F2})", p2, points[p2, 0], points[p2, 1]);
            Console.WriteLine("\nDistance: {0:F2}", shortestDistance);
            Console.WriteLine("Number of distance comparisons: {0:D}", totalComparisons);
        }

        private static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
