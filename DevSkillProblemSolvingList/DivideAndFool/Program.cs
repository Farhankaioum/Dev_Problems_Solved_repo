using System;

namespace DivideAndFool
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            int testcase = int.Parse(Console.ReadLine());
            while (testcase > 0)
            {

                var inputs = Console.ReadLine().Split(' ');
                int num1 = int.Parse(inputs[0]);
                int num2 = int.Parse(inputs[1]);
                int digit = int.Parse(inputs[2]);
                int x = num1 % num2;
                Console.Write(num1 / num2 + ".");

                while (digit > 0)
                {
                    x = x * 10;
                    Console.Write(x / num2);
                    x = x % num2;
                    digit--;
                }
                Console.WriteLine();

                testcase--;
            }


        }
    }
}
