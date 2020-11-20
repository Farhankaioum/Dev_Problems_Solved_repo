using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static List<string> SortedListOrder(List<string> input)
    {
        for (int i = 0; i < input.Count(); i++)
        {
            for (int j = 0; j < input.Count() - 1; j++)
            {
                var one = double.Parse(input[j]);
                var two = double.Parse(input[j + 1]);
               
                if (one > two)
                {
                    var t = input[j];
                    input[j] = input[j + 1];
                    input[j + 1] = t;
                }
                
            }
        }
        return input;
    }



    static void Main(string[] args)
    {
        int testcase = int.Parse(Console.ReadLine());
        while (testcase > 0)
        {
            int count = int.Parse(Console.ReadLine());
            var inputs = Console.ReadLine().Split(' ');
            List<string> numberSort = new List<string>();

            if (inputs.Length == count)
            {
                for (int i = 0; i < inputs.Length; i++)
                {
                    numberSort.Add(inputs[i]);
                }

                var result = SortedListOrder(numberSort);
                foreach (var r in result)
                {
                    Console.Write(r);
                    if (Array.IndexOf(result.ToArray(), r) < result.Count() -1)
                        Console.Write(",");
                }
                Console.WriteLine();
            }

            testcase--;
        }
    }
}


