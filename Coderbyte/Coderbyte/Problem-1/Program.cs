using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1
{
    class Program
    {
        public static string SumMultiplier(int[] arr)
        {
            var sum = arr.Sum();
            sum *= 2;
            var multiple = new List<int>();

            if (arr.Count() > 1)
            {
                foreach (var i in arr)
                {
                    if (i < 0)
                    {
                        multiple.Add(i * -1);
                    }
                    else multiple.Add(i);
                }

                multiple.Sort();
                var result = multiple[multiple.Count - 2] * multiple[multiple.Count - 1];
                return result > sum ? "true" : "false";
            }

            else
                return "false";

        }

        public static void swapTwoNumber(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void Permutation(int[] list, int k, int m)
        {
            int i;
            if (k == m)
            {
                for (i = 0; i <= m; i++)
                    Console.Write("{0}", list[i]);
                Console.Write(" ");
            }
            else
                for (i = k; i <= m; i++)
                {
                    swapTwoNumber(ref list[k], ref list[i]);
                    Permutation(list, k + 1, m);
                    swapTwoNumber(ref list[k], ref list[i]);
                }
        }
    

    static void Main(string[] args)
        {
            // 5
            int input = 910;
            var listOfSeperatedNum = new List<int>();
            var listOfArrangedNum = new List<int>();

            while (input > 0)
            {
                listOfSeperatedNum.Add(input % 10);
                input = input / 10;
            }

            listOfSeperatedNum.Reverse();

           

            var newArray = listOfSeperatedNum;
            var digit = newArray[0];
            newArray.RemoveAt(0);

            Permutation(newArray.ToArray(), 0, newArray.Count());

            Console.WriteLine();


            // 4
            //Console.WriteLine(SumMultiplier(new int[] { 2 }));

            //var input = new int[] { 4, 5, 5, 12 };
            //var newOne = input.ToList();

            //int sum = 0;
            //for (int i = 0; i < input.Length; i++)
            //{
            //    sum = sum + input[i];
            //}

            //int bigNumber = 0;

            //for (int i = 0; i < input.Length; i++)
            //{
            //    for (int j = i; j <1 ; j++)
            //    {
            //        var s = input[i] * input[j];
            //        if (s > bigNumber)
            //        {
            //            bigNumber = s;
            //        }
            //    }

            //}

            //sum = sum * 2;

            //if (bigNumber > sum)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}

            // 3
            //string input = "Hello World";
            //var splitedInput = input.Split(' ');
            //int count = splitedInput.Length ;

            //for (int i = 0; i < splitedInput.Length; i++)
            //{
            //    count++;
            //}
            //Console.WriteLine(count);

            // 2
            //int input = 126;
            //int hours = input / 60;
            //int minute = input % 60;
            //Console.WriteLine($"{hours}:{minute}");


            // 1
            //var input = "Coderbyte";
            //var charArray = input.ToCharArray();
            //Array.Reverse(charArray);
            //var reverseInput = new string(charArray);

            //Console.WriteLine(reverseInput);
        }
    }
}
