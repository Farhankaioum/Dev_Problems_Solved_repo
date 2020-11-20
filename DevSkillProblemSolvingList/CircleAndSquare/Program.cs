using System;

namespace CircleAndSquare
{
    public class Program
    {
        static void Main(string[] args)
        {
            int testcase = int.Parse(Console.ReadLine());
            while (testcase > 0)
            {
                var inputs = Console.ReadLine().Split(' ');

                double input1 = double.Parse(inputs[0]);
                double input2 = double.Parse(inputs[1]);

                var value = Math.Floor(Math.Sqrt(2 * Math.Pow(input1, 2)));
                var radius = Math.Floor(input2);
                if (radius == value)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }

                testcase--;
            }

          
        }
    }
}
