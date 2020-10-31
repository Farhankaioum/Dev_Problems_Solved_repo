using System;
using System.Collections.Generic;

namespace NumberBase
{
    public class Program
    {
        static void Main(string[] args)
        {
            int testcase = int.Parse(Console.ReadLine());
            while (testcase > 0)
            {
                var inputs = Console.ReadLine().Split(',');

                int number = int.Parse(inputs[0]);
                int baseN = int.Parse(inputs[1]);
                string finalValue = string.Empty;
                List<string> totalValue = new List<string>();
                if (number <= 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    while (number > 0)
                    {
                        int result = number % baseN;
                        if (result > 9)
                        {
                            totalValue.Add(((char)(55 + result)).ToString());
                        }
                        else
                        {
                            totalValue.Add(result.ToString());
                        }

                        number = number / baseN;
                    }
                    totalValue.Reverse();
                    foreach (var to in totalValue)
                    {
                        Console.Write(to);
                    }
                    Console.WriteLine();
                }
                testcase--;
            }
        }
    }
}
