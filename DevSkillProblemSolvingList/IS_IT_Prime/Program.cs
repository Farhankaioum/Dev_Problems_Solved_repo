using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_IT_Prime
{
   public class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = new List<int>();

            int testcases = int.Parse(Console.ReadLine());
            if (testcases <= 5000)
            {
                for (int i = 0; i<testcases; i++)
                {
                    int num = int.Parse(Console.ReadLine());
                    if (num >= 0 && num <= 10000)
                    {
                        inputNumbers.Add(num);
                    }
                    
                }
            }
            int count = 0;
            foreach (var nums in inputNumbers)
            {
                if (nums == 0 || nums == 1)
                {
                    Console.WriteLine("No");
                }
                else if (nums == 2)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    count = 0;
                    for (int i = 2; i <= nums / 2; i++)
                    {
                        if (nums % i == 0)
                        {
                            count++;
                            break;
                        }
                    }
                    if (count > 0)
                    {
                        Console.WriteLine("No");
                    }
                    else
                    {
                        Console.WriteLine("Yes");
                    }
                }
            }
        }
    }
}
