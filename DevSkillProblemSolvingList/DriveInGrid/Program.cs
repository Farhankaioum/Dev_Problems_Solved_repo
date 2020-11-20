using System;

namespace DriveInGrid
{
    public class Program
    {
       
        public static long DriveThe(int num1, int num2)
        {
            long total = 1;
            
            for(int i = 0; i < num2; i++)
            {
                total = total * (num1 - i);
                total = total / (i + 1);
            }
            return total;
        }
        static void Main(string[] args)
        {
            int testcase = int.Parse(Console.ReadLine());
            while (testcase > 0)
            {
                var inputs = Console.ReadLine().Split(' ');
                int num1 = int.Parse(inputs[0]);
                int num2 = int.Parse(inputs[1]);
                int total = num1 + num2;

                Console.WriteLine(DriveThe(total, num2));
                
                testcase--;
            }

        }
    }
}
