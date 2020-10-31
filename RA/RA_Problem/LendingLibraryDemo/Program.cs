using System;
using System.Collections.Generic;

namespace ExampleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // for question-6 lamda method
            Func<int, int, int> Sum = (num1, num2) => { return num1 + num2; };
            int result = Sum(10,20);
            


        }
    }
    // answer 1 end here
}
