using System;
using System.Collections.Generic;
using System.Text;

namespace Solution_7
{
    public class Program
    {
        public static List<string> combinatedWord = new List<string>();
        public static string input = "hellocat";

        static void printTheArray(int[] arr, int n)
        {
            var word = new StringBuilder();

            for (var i = 0; i < n; i++)
            {
                word.Append(input[i]);
            }

            combinatedWord.Add(word.ToString());
        }
        static void generateAllBinaryStrings(int n, int[] arr, int i)
        {
            if (i == n)
            {
                printTheArray(arr, n);
                return;
            }

            arr[i] = 0;
            generateAllBinaryStrings(n, arr, i + 1);
            arr[i] = 1;
            generateAllBinaryStrings(n, arr, i + 1);
        }


        public static void Main(string[] args)
        {
            
            var n = 8;
            var arr = new int[n];
            generateAllBinaryStrings(n, arr, 0);

            foreach (var item in combinatedWord)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey(true);
        }
    }
}
