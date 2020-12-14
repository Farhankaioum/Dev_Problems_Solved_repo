using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            Array.Sort(arr);
            var value = 1;
            int foundValue = 0;

            int start = 0, length = arr.Length - 1;

            while (start <= length)
            {
                int mid = start + length / 2;

                if (arr[mid] == value)
                {
                    foundValue = arr[mid];
                    break;
                }

                if (arr[mid] < value) // ignore left side values
                    start = mid + 1;

                else
                    length = mid - 1;
            }

            Console.WriteLine(foundValue == value ? "Value found" : "Not present in this array!");
        }
    }
}
