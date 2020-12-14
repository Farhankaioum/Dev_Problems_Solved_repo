using Microsoft.SharePoint.Client.Publishing;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeForceProblem
{
    class Program
    {
        public static List<string> words1 = new List<string>();
        static void Main(string[] args)
        {
            var len = 10;
            var text = "nznooeeoer";

             printAllKLength(text.ToCharArray(), 4);
            var allzero = words1.Where(w => w == "zero").Select(w => 1).ToList();
            words1.Clear();

            //printAllKLength(text.ToCharArray(), 3);
            //var allOne = words1.Where(w => w == "one").Select(w => 0).ToList();
            //words1.Clear();
            //allzero.AddRange(allOne);
            //allzero.OrderBy(c => c);

            //foreach (var item in allzero)
            //{
            //    Console.Write(item);
            //}
            //Console.WriteLine();

        }

        static void printAllKLength(char[] set, int k)
        {
            int n = set.Length;
            printAllKLengthRec(set, "", n, k);
        }

        static void printAllKLengthRec(char[] set,
                               String prefix,
                               int n, int k)
        {

            // Base case: k is 0, 
            // print prefix 
            if (k == 0)
            {
                words1.Add(prefix);
                Console.WriteLine(prefix);
                return;
            }

            // One by one add all characters  
            // from set and recursively  
            // call for k equals to k-1 
            for (int i = 0; i < n; ++i)
            {

                // Next character of input added 
                String newPrefix = prefix + set[i];

                // k is decreased, because  
                // we have added a new character 
                printAllKLengthRec(set, newPrefix,
                                        n, k - 1);
            }
        }

    }
}
