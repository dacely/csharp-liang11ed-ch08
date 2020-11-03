using System;
using System.Collections.Generic;
using System.Text;

namespace Liang_Ch08
{
    class T02_PassByReference
    {
        public static void M1()
        {
            int x = 1;
            Console.WriteLine("M1: x = {0}", x);
            M2(ref x);
            Console.WriteLine("M1: x = {0}", x);
        }

        private static void M2(ref int y)
        {
            y = 2;
            Console.WriteLine("M2: y = {0}", y);
            M3(y);
            Console.WriteLine("M2: y = {0}", y);
        }

        private static void M3(int z)
        {
            z = 3;
            Console.WriteLine("M3: z = {0}", z);
        }
    }
}
