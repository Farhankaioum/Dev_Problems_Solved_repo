using System;

namespace BubbleSort
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

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j  = 0; j < arr.Length - i - 1; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        var swap = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = swap;
                    }
                }
            }

            foreach (var a in arr)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
        }
    }
}
