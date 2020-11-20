using System;
using System.Collections.Generic;

namespace ThreeBox
{
   public class Program
    {
        public static double CalculateAD(List<double> num)
        {
            string final = string.Empty;

            double AB = num[0];
            double BC = num[1];
            double CD = num[2];
            double result = Math.Sqrt((AB * AB) + (BC * BC) + (CD * CD));
            double finalResult = Math.Round(result, 2);

            return finalResult;
        }
        static void Main(string[] args)
        {
            List<List<double>> sampleData = new List<List<double>>();
            int testcaseCount = int.Parse(Console.ReadLine());
            if (testcaseCount <= 30)
            {
                for (int i = 0; i < testcaseCount; i++)
                {
                    var inputs = Console.ReadLine().Split(' ');

                    double input1 = double.Parse(inputs[0]);
                    double input2 = double.Parse(inputs[1]);
                    double input3 = double.Parse(inputs[2]);
                    if ((input1 > 0 && input1 < 1000) && (input2 > 0 && input3 < 1000) && (input3 > 0 && input3 < 1000))
                    {
                        List<double> tempList = new List<double>();
                        tempList.Add(input1);
                        tempList.Add(input2);
                        tempList.Add(input3);

                        sampleData.Add(tempList);
                    }


                }
            }
            foreach (var num in sampleData)
            {
                var result = Program.CalculateAD(num);

                var inputs = result.ToString().Split('.');
                if (inputs.Length > 1)
                {
                    if (inputs[1].Length == 1)
                    {
                        Console.WriteLine(result + "0");
                    }
                    else
                        Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine(result + ".00");
                }


            }


        }
    }
}
