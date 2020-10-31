using System;
using System.Collections.Generic;

namespace ChickenLover
{
   public class Program
    {
        static void Main(string[] args)
        {
            int testcases = int.Parse(Console.ReadLine());
            List<int> chickenLefts = new List<int>();

            if (testcases <= 100)
            {
                for (int i = 0; i<testcases; i++)
                {
                    chickenLefts.Add(int.Parse(Console.ReadLine()));
                }

            }

            foreach (var chicken in chickenLefts)
            {
                if (chicken >= 120)
                {
                    Console.WriteLine("Good Boy Sifat");
                }
                else
                {
                    Console.WriteLine("Naughty Boy Sifat");
                }
            }
        }
    }
}
