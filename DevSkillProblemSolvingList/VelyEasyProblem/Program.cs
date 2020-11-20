using System;
using System.Linq;


namespace VelyEasyProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcase = int.Parse(Console.ReadLine());
            if (testcase >= 1 && testcase <= 20)
            {
                for (int i = 0; i<testcase; i++)
                {
                    string input = Console.ReadLine();
                    if (input.Length <= 50 && input.All(char.IsLower))
                    {
                        var result = input.Contains("r") ? "Not vely easy" : "Vely easy";
                        Console.WriteLine(result);
                    }
                }
               
            }
        }
    }
}
