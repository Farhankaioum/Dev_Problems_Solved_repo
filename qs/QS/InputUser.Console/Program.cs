using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InputUser.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number2 = { 5, 2, 3, 11};
            //var reverseValue = Reverse(number2);
            //foreach (var item in reverseValue)
            //{
            //    System.Console.Write(item + " ");
            //}
            //System.Console.WriteLine();

            //var values = SplitOddAndEvenPositionNumber(number2);

            //foreach (var item in values.oddNumber)
            //{
            //    System.Console.Write(item + " ");
            //}

            // 2d array
            var number = new int[2, 3];
            number[0,0] = 1;
            number[0, 1] = 1;
            number[0, 2] = 10;
            number[1, 0] = 1;
            number[1, 1] = 1;
            number[1, 2] = 20;

            int sum = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 2)
                    {
                        sum = sum + number[i, j];
                    }
                }
            }

            System.Console.WriteLine(sum);


        }

        public static int[] Reverse(int[] numbers)
        {
            var reverValue = new int[numbers.Length];
            int postion = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                reverValue[postion] = numbers[i];
                postion++;
            }

            return reverValue;
           //return numbers.Reverse().ToArray();
        }

        public static (int[] evenNumber, int[] oddNumber) SplitOddAndEvenPositionNumber(int[] numbers)
        {
            var evenNumber = new List<int>();
            var oddNumber = new List<int>();

            for (int i = 0; i< numbers.Length; i++)
            {
                if (i != 0 && i % 2 == 0 )
                {
                    evenNumber.Add(numbers[i]);
                }
                else
                {
                    oddNumber.Add(numbers[i]);
                }
            }

            return (evenNumber.ToArray(), oddNumber.ToArray());
        }
    }
}
