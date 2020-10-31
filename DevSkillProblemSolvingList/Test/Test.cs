using System;
using System.Collections.Generic;
using System.Numerics;

namespace Problems
{
    public class Test
    {
        //public static List<List<int>> RemoveLeadingZeroFromListOfList(List<List<int>> numbers)
        //{
        //    List<List<int>> newList = new List<List<int>>();

        //    int startP = -1;


        //    foreach (var nums in numbers)
        //    {
        //        startP = -1;
        //        foreach (var n in nums)
        //        {
        //            if (n != 0)
        //            {
        //                startP = Array.IndexOf(nums.ToArray(), n);
        //                break;
        //            }
        //        }

        //        List<int> tempList = new List<int>();
        //        for (int i = 0; i < nums.Count() - startP; i++)
        //        {
        //            tempList.Add(nums[i + startP]);
        //        }
        //        newList.Add(tempList);


        //    }
        //    return newList;
        //}
        public static long ReverseNum(long num)
        {
            long sum = 0;
            while (num > 0)
            {
                sum = sum * 10 + num % 10;
                
                num = num / 10;
            }
            return sum;
        }
        public static long RemoveLeadingZero(long num)
        {
            string strInput = num.ToString();
            strInput = strInput.TrimStart('0');
            return long.Parse(strInput);
        }

        static void Main(string[] args)
        {
           

            //List<long[]> listArr = new List<long[]>();
            //List<long[]> reverseArr = new List<long[]>();

            //List<long> numSum = new List<long>();
            //List<long> reverseSum = new List<long>();

            //string line;
            //while ((line = Console.ReadLine()) != null)
            //{
            //    string[] inputs = line.Split(',');
            //    long firstNum = long.Parse(inputs[0]);
            //    long secondNum = long.Parse(inputs[1]);
            //    listArr.Add(new long[] { firstNum, secondNum });
            //}

            //foreach (var nums in listArr)
            //{
            //    long[] newStr = new long[nums.Length];
            //    for (int j = 0; j < nums.Length; j++)
            //    {

            //        newStr[j] = ReverseNum(nums[j]);
            //    }
            //    reverseArr.Add(newStr);
            //}

            //foreach (var nums in reverseArr)
            //{
            //    long sum = 0;
            //    for (int i = 0; i < nums.Length; i++)
            //    {
            //        sum = sum + nums[i];
            //    }
            //    numSum.Add(sum);

            //}

            //foreach (var num in numSum)
            //{
            //    reverseSum.Add(ReverseNum(RemoveLeadingZero(num)));
            //}
            //foreach (var num in reverseSum)
            //{
            //    Console.WriteLine(num);
            //}

        }
    }
}
