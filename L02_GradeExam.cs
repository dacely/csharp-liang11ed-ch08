using System;
using System.Collections.Generic;
using System.Text;

namespace Liang_Ch08
{
    class L02_GradeExam
    {
        public static void Execute()
        {
            char[,] answers =
            {
                {'A', 'B', 'A', 'C', 'C', 'D', 'E', 'E', 'A', 'D'},
                {'D', 'B', 'A', 'B', 'C', 'A', 'E', 'E', 'A', 'D'},
                {'E', 'D', 'D', 'A', 'C', 'B', 'E', 'E', 'A', 'D'},
                {'C', 'B', 'A', 'E', 'D', 'C', 'E', 'E', 'A', 'D'},
                {'A', 'B', 'D', 'C', 'C', 'D', 'E', 'E', 'A', 'D'},
                {'B', 'B', 'E', 'C', 'C', 'D', 'E', 'E', 'A', 'D'},
                {'B', 'B', 'A', 'C', 'C', 'D', 'E', 'E', 'A', 'D'},
                {'E', 'B', 'E', 'C', 'C', 'D', 'E', 'E', 'A', 'D'}
            };

            char[] keys = { 'D', 'B', 'D', 'C', 'C', 'D', 'A', 'E', 'A', 'D' };
            int[] grades = new int[answers.GetLength(0)];
            int bestStudent = 0;
            int bestGrade = 0;

            for (int i = 0; i < answers.GetLength(0); i++)
            {
                for (int j = 0; j < answers.GetLength(1); j++)
                {
                    if (answers[i, j] == keys[j])
                    {
                        grades[i]++;
                    }
                }

                if (grades[i] > bestGrade)
                {
                    bestGrade = grades[i];
                    bestStudent = i;
                }
            }

            for (int s = 0; s < grades.Length; s++)
            {
                Console.WriteLine("Student {0}: {1}", s, grades[s]);
            }

            Console.WriteLine("\nBest Student");
            Console.WriteLine("Student {0}: {1}", bestStudent, bestGrade);
        }
    }
}
