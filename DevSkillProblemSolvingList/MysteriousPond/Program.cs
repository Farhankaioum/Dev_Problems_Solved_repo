using System;
using System.Collections.Generic;
using System.Linq;

namespace MysteriousPond
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            int testcase = int.Parse(Console.ReadLine());
            while (testcase > 0)
            {
                List<string> names = new List<string>();
                List<int> times = new List<int>();

                int friendCount = int.Parse(Console.ReadLine());
                for (int i = 0; i < friendCount; i++)
                {
                    var inputs = Console.ReadLine().Split(' ');

                    names.Add(inputs[0]);
                    times.Add(int.Parse(inputs[1]));
                }

                int max = times[0];
                int maxPostion = 0;
                int min = times[0];
                int minPostion = 0;
                for (int i = 1; i < times.Count(); i++)
                {
                    if (times[i] > max)
                    {
                        max = times[i];
                        maxPostion = i;
                    }
                    if (times[i] < min)
                    {
                        min = times[i];
                        minPostion = i;
                    }
                }
                Console.WriteLine(names[maxPostion] + " " + names[minPostion]);

                testcase--;
            }
            
        }
    }
}
