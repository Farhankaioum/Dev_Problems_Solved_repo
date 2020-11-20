using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixNCryption
{
   public class Program
    {
        static void Main(string[] args)
        {
            List<List<List<int>>> daysRuns = new List<List<List<int>>>();

            int testcase = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i<testcase; i++)
            {
                List<List<int>> runs = new List<List<int>>();
                for (int a = 0; a <2; a++)
                {
                    
                        var inputs = Console.ReadLine().Split(' ');
                        int bdIn1 = Convert.ToInt32(inputs[0]);
                        int bdIn2 = Convert.ToInt32(inputs[1]);

                        int pakIn1 = Convert.ToInt32(inputs[2]);
                        int pakIn2 = Convert.ToInt32(inputs[3]);

                        int sumBd = 0;
                        int sumPak = 0;

                        if ((bdIn1 >= 0 && bdIn1 <= 999) && bdIn2 >= 0 && bdIn2 <= 999)
                        {
                            sumBd = bdIn1 + bdIn2;
                        }
                        if ((pakIn1 >= 0 && pakIn1 <= 999) && pakIn2 >= 0 && pakIn2 <= 999)
                        {
                            sumPak = pakIn1 + pakIn2;
                        }

                    runs.Add(new List<int> { sumBd, sumPak});
                }
                daysRuns.Add(runs);
            }
            int count = 0;
            foreach (var runs in daysRuns)
            {
                count = 0;
                foreach (var run in runs)
                {
                    for (int i = 0; i<run.Count()-1; i++)
                    {
                        if (run[i] > run[i+1])
                        {
                            count++;
                        }
                    }
                   
                }
                if (count > 1)
                {
                    Console.WriteLine("Banglawash");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
         

        }
    }
}
