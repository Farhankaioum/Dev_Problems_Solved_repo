using System;

namespace SquareNumber
{
    public class Program
    {

        static void Main(string[] args)
        {
            int caseCount = 1;
            int testcase = int.Parse(Console.ReadLine());
            while (testcase > 0)
            {
                int num;
                var result = int.TryParse(Console.ReadLine(), out num);
                if (result)
                {
                    int r = (int)Math.Sqrt(num + 0.0001);
                    if ((r * r) == num)
                    {
                        Console.WriteLine("Case " + caseCount + ": YES");
                        caseCount++;
                    }
                    else
                    {
                        Console.WriteLine("Case " + caseCount + ": NO");
                        caseCount++;
                    }

                    testcase--;
                }
                
            }

        }
    }
}
