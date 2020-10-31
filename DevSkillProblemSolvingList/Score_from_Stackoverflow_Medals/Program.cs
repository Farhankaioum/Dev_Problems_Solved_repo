using System;
using System.Collections.Generic;

namespace Score_from_Stackoverflow_Medals
{
   public class Program
    {
        static void Main(string[] args)
        {
          
            int testcases = int.Parse(Console.ReadLine());
            int[] totalPoints = new int[testcases];

            if (testcases >= 1 && testcases <= 20)
            {
                for (int i = 0; i<testcases; i++)
                {
                    var inputs = Console.ReadLine().Split(' ');
                    int bronze = int.Parse(inputs[0]);
                    int silver = int.Parse(inputs[1]);
                    int gold = int.Parse(inputs[2]);

                    if ((bronze >= 1 && bronze <= 100) && (silver >= 1 && silver <= 100) && (gold >= 1 && gold <= 100))
                    {
                        int sum = (bronze * 10) + (silver * 50) + (gold * 100);

                        totalPoints[i] = sum;
                    }
                }
            }
            for (int i = 0; i<totalPoints.Length; i++)
            {
                Console.WriteLine(totalPoints[i]);
            }
        }
    }
}
