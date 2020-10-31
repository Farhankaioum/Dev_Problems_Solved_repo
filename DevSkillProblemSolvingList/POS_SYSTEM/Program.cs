using System;
using System.Collections.Generic;
using System.Linq;

namespace POS_SYSTEM
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> productBuyTotalAmount = new List<double>();
            List<int> submitMoney = new List<int>();

            int testcases = int.Parse(Console.ReadLine());
            
            if (testcases >= 1 && testcases <= 50)
            {
                for (int i = 0; i < testcases; i++)
                {
                    double total = 0;

                    int productItemCount = int.Parse(Console.ReadLine());
                    if (productItemCount >= 1 && productItemCount <= 20)
                    {
                        for (int p = 0; p < productItemCount; p++)
                        {
                            var inputs = Console.ReadLine().Split(' ');

                            double product = double.Parse(inputs[0]);
                            int quantity = int.Parse(inputs[1]);

                            if ((product >= 1.00 && product <= 2000.00) && (quantity >= 1 && quantity <= 20))
                            {
                                total = total + (product * quantity);
                                
                            }
                            
                        }
                       
                    }
                    // total product sum added
                    productBuyTotalAmount.Add(total);

                    int totalsubmit = int.Parse(Console.ReadLine());

                    if (totalsubmit >= total)
                    {
                        submitMoney.Add(totalsubmit);
                    }
                }
            }


            //find the result area
            int cascount = 1;
            for (int i = 0; i < submitMoney.Count(); i++)
            {
                var returnAmount = (int) Math.Abs(submitMoney[i] - productBuyTotalAmount[i]);
                Console.WriteLine("Case " + cascount + ": " + returnAmount);
                cascount++;
            }
        }
    }
}
