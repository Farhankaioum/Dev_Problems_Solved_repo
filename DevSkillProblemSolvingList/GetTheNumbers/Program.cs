using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Test
{
    static void Main(string[] args)
    {

        List<List<List<string>>> reportsTotal = new List<List<List<string>>>();

        Dictionary<string, List<string>> successList = new Dictionary<string, List<string>>();
        Dictionary<string, List<string>> failedList = new Dictionary<string, List<string>>();

        

        List<Dictionary<string, List<string>>> finalList = new List<Dictionary<string, List<string>>>();

        int testCase = Convert.ToInt32(Console.ReadLine());
        if (testCase <= 10)
        {
            for (int i = 0; i < testCase; i++)
            {
                int howMuchInput = Convert.ToInt32(Console.ReadLine());
                List<List<string>> totalInput = new List<List<string>>();
                if (howMuchInput <= 100)
                {
                    
                    List<string> originalsNum = new List<string>();
                    List<string> reportsNum = new List<string>();

                    for (int b = 0; b < howMuchInput; b++)
                    {
                        originalsNum.Add(Console.ReadLine());
                    }
                    totalInput.Add(originalsNum);

                    for (int b = 0; b < howMuchInput; b++)
                    {
                        reportsNum.Add(Console.ReadLine());
                    }
                    totalInput.Add(reportsNum);
                }

                reportsTotal.Add(totalInput);
                Console.WriteLine();
            }
        }

        int count = 0;
        string message = string.Empty;
        string reportNum = string.Empty;
        foreach (var nums in reportsTotal)
        {
            for (int i = 0; i<nums[0].Count(); i++)
            {
                count = 0;

                var firstdigit = nums[0][i].Substring(0,3);
                var lastdigit = nums[0][i].Substring(nums[0][i].Length - 4 ,4);
                for (int j= 0; j<nums[1].Count(); j++)
                {
                    var inputs = nums[1][j].Split(',');

                    var inputValue = inputs[0];
                    

                    var msg = inputs[1];
                    

                    var inpuValueFirst = inputValue.Substring(0,3);
                    var inputValueLast = inputValue.Substring(inputValue.Length - 4, 4);
                    if (firstdigit == inpuValueFirst && lastdigit == inputValueLast)
                    {
                        count++;
                        reportNum = inputValue;
                        message = msg;
                    }
                }
                if (count > 1)
                {
                    successList.Add(Guid.NewGuid().ToString(), new List<string> { reportNum ,"Confused"});
                    failedList.Add(Guid.NewGuid().ToString(), new List<string> { reportNum ,"Confused"});
                }
                else
                {
                    if (message.ToUpper() == "SUCCESS")
                    {
                        successList.Add(Guid.NewGuid().ToString(), new List<string> { reportNum, nums[0][i]});
                    }
                    else if(message.ToUpper() == "FAILED")
                    {
                        failedList.Add(Guid.NewGuid().ToString(), new List<string> { reportNum, nums[0][i] });
                    }
                }
            }
            finalList.Add(successList);
            finalList.Add(failedList);

            
        }


        //for (int i = 0; i<successList.Count(); i++)
        //{

        //}

        //Console.WriteLine(finalList.Count());


        foreach (var list in successList)
        {
            foreach (var l in list.Value)
            {
                Console.Write(l + " : ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        foreach (var list in failedList)
        {
            foreach (var l in list.Value)
            {
                Console.Write(l + " : ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // ** For print input value ** //
        //Console.WriteLine();
        //foreach (var nums in reports)
        //{
        //    foreach (var num in nums)
        //    {
        //        foreach (var n in num)
        //        {
        //            Console.WriteLine(n);
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine("\n\n");
        //}
        // ** End ** //
    }
}

