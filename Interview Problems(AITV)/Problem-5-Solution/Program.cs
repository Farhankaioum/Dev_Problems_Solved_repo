using System;
using System.Linq;

namespace Problem_5_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = Convert.ToInt32(Console.ReadLine());
            var listOfLockers = Enumerable.Range(1, userInput).ToList();
            int positionChanger = 2;

            while (listOfLockers.Count != 1)
            {
                var firstValue = listOfLockers[0];

                for (int i = 0; i < listOfLockers.Count; i++)
                {
                    if (listOfLockers.Contains(firstValue))
                    {
                        listOfLockers.Remove(firstValue);
                    }

                    firstValue += positionChanger;
                }
                positionChanger++;
            }

            Console.WriteLine(listOfLockers[0]);
        }
    }
}
