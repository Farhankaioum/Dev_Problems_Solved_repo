using System;

namespace BackToSchool
{
    public class Program
    {
        static void Main(string[] args)
        {
            int testcase = int.Parse(Console.ReadLine());
            int caseCount = 1;
            while (testcase > 0)
            {
                var inputs = Console.ReadLine().Split(' ');

                int cx = int.Parse(inputs[0]);
                int cy = int.Parse(inputs[1]);

                double radius = double.Parse(inputs[2]);

                int px = int.Parse(inputs[3]);
                int py = int.Parse(inputs[4]);

                double result = Math.Pow((px - cx), 2) + Math.Pow((py - cy), 2);
                result = Math.Sqrt(result);
                if (result < radius)
                {
                    Console.WriteLine("Case " + caseCount + ": Inside");
                    caseCount++;
                }
                else if (result == radius)
                {
                    Console.WriteLine("Case " + caseCount + ": OnCircle");
                    caseCount++;
                }
                else
                {
                    Console.WriteLine("Case " + caseCount + ": Outside");
                    caseCount++;
                }

                testcase--;
            }
        }
    }
}
