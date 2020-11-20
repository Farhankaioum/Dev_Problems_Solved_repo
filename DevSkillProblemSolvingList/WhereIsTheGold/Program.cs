using System;
using System.Collections.Generic;
using System.Linq;

namespace WhereIsTheGold
{
    class Program
    {
        static void Main(string[] args)
        {
            int cascount = 1;
            int testcases = int.Parse(Console.ReadLine());
            if (testcases >= 1 && testcases <= 20)
            {
                for (int a = 0; a<testcases; a++)
                {

                    var inputs = Console.ReadLine().Split(' ');

                    int rows = int.Parse(inputs[0]);
                    int columns = int.Parse(inputs[1]);


                    if ((rows >= 3 && rows <= 100) && (columns >= 3 && columns <= 100))
                    {
                        string[,] goldMatrix = new string[rows, columns];
                        for (int i = 0; i < rows; i++)
                        {
                            var mInput = Console.ReadLine();
                            var ch = mInput.ToCharArray();
                            for (int j = 0; j < columns; j++)
                            {
                                goldMatrix[i, j] = ch[j].ToString();
                            }

                        }
                        List<string> position = new List<string>();

                        for (int i = 0; i < goldMatrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < goldMatrix.GetLength(1); j++)
                            {
                                if (goldMatrix[i, j] == "$")
                                {
                                    var e1 = i + 1;
                                    var e2 = j + 1;
                                    position.Add(e1 + "," + e2);
                                }
                            }

                        }
                        Console.WriteLine("Case " + cascount + ":");
                        if (position.Count() > 0)
                        {
                            foreach (var po in position)
                            {

                                Console.WriteLine(po);
                            }
                            cascount++;
                        }
                        else
                        {
                            Console.WriteLine("No Gold Found");
                            cascount++;
                        }
                    }

                }
               

            }
        }
    }
}
