using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            foreach (var a in arr)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();

            for (int i= 0; i < arr.Length - 1; i++)
            {
                var minValuePosition = i;

                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minValuePosition])
                        minValuePosition = j;
                }

                var temp = arr[i];
                arr[i] = arr[minValuePosition];
                arr[minValuePosition] = temp;
            }

            foreach (var a in arr)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
        }
    }
}
