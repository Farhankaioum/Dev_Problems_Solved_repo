using System;
using System.Collections.Generic;

namespace TomorrowIsEid
{
   public class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            if (input > 0 && input <= 30)
            {
                if (input >= 29)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
