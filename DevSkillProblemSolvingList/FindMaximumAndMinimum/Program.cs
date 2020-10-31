using System;
using System.Collections.Generic;
using System.Linq;


public class Test
{
    public static int FindMax(List<int> nums)
    {
        int max = nums[0];
        for (int i = 1; i < nums.Count(); i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
            }
        }
        return max;
    }
    public static int FindMin(List<int> nums)
    {
        int min = nums[0];
        for (int i = 1; i < nums.Count(); i++)
        {
            if (nums[i] < min)
            {
                min = nums[i];
            }
        }
        return min;
    }

    static void Main(string[] args)
    {

        List<List<int>> listOfNumbers = new List<List<int>>();

        int countTestCase = Convert.ToInt32(Console.ReadLine());
        if (countTestCase >= 1 && countTestCase <= 100)
        {
            for (int i = 0; i < countTestCase; i++)
            {
                var inputs = Console.ReadLine().Split(' ');
                List<int> tempList = new List<int>();
                if (inputs.Length >= 2 && inputs.Length <= 50)
                {
                    for (int j = 0; j < inputs.Length; j++)
                    {
                        if (inputs[j].Length <= 3)
                        {
                            var tempInput = Convert.ToInt32(inputs[j]);
                           
                                tempList.Add(tempInput);
                        }
                    }
                    listOfNumbers.Add(tempList);
                }

            }
        }

        int cas = 1;
        foreach (var nums in listOfNumbers)
        {
            int max = nums[0];
            int min = nums[0];
            int count = nums.Count();

            for (int i = 1; i < nums.Count(); i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }

            }
            for (int i = 1; i < nums.Count(); i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }

            Console.WriteLine($"Case {cas}: Among {count} numbers {max} is maximum and {min} is minimum");
            cas++;
        }
    }
}

