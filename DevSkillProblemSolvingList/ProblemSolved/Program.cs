using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolved
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int[]> initialInput = new List<int[]>();
            List<int> workingHour = new List<int>();

            List<int> totalHours = new List<int>();
            

            string line;

            while ((line = Console.ReadLine()) != null)
            {
                string[] inputs = line.Split(' ');

                int totalHour = Convert.ToInt32(inputs[0]);
                if (totalHour > 0 && totalHour <= 100)
                {
                    workingHour.Add(totalHour);
                }

               
                int workingPerson = Convert.ToInt32(inputs[1]);

                if (workingPerson > 0 && workingPerson <= 100)
                {
                    int sum = 0;
                    for (int i = 0; i < workingPerson; i++)
                    {
                        int input = Convert.ToInt32(Console.ReadLine());
                        if (input > 0 && input <= 24)
                        {
                            sum = sum + input;
                        }
                       
                    }
                    totalHours.Add(sum);


                }
               
            }
            for (int i = 0; i<workingHour.Count(); i++)
            {
                if (totalHours[i] >= workingHour[i])
                {
                    Console.WriteLine("Project will finish within 1 day.");
                }
                else
                {
                    double result = Math.Ceiling(Convert.ToDouble(workingHour[i]) / Convert.ToDouble(totalHours[i])) ;
                    Console.WriteLine($"Project will finish within {result} days.");

                }
            }
        }
    }
}
