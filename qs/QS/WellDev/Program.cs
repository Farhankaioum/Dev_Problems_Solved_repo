using System;

namespace WellDev
{
    class Program
    {
        static int recurse(int a, int b)
        {
            if (a % b == 2)
                return a;
            else
                return recurse(a + b, a-b);
        }

        static void Main(string[] args)
        {
            var value = recurse(7, 2);
            Console.WriteLine(value);
        }
    }
}
