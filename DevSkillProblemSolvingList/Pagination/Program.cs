using System;
using System.Collections.Generic;
using System.Linq;

namespace Pagination
{
    public class Program
    {
        static void Main(string[] args)
        {
            int testcase = int.Parse(Console.ReadLine());
            int caseNum = 1;

            while (testcase > 0)
            {

                int totalPage = int.Parse(Console.ReadLine());
                List<int> startingPage = new List<int>();
                bool isInput = false;
                
                while (!isInput)
                {
                    int input = int.Parse(Console.ReadLine());
                    if (input == 0)
                        isInput = true;
                    else
                        startingPage.Add(input);
                }
                Console.WriteLine($"Case {caseNum}:");

                for (int i = 0; i < startingPage.Count(); i++)
                {
                    if (totalPage < 6)
                    {
                        for (int p = 1; p <= totalPage; p++)
                        {
                            Console.Write(p + " ");
                        }
                    }
                    else
                    {

                        int currentPage = startingPage[i];
                        int first = 1;
                        int fourth = 0;
                        int third = 0;
                        int second = 0;
                        int fifth = 0;
                        int sixth = 0;

                        if (currentPage > 3)
                        {
                            fourth = currentPage;
                            third = currentPage - 1;
                            second = currentPage - 2;
                            fifth = currentPage + 1;
                            sixth = currentPage + 2;
                        }
                        else
                        {
                            fourth = 4;
                            third = 3;
                            second = 2;
                            fifth = 5;
                            sixth = 6;
                        }
                        if (currentPage == totalPage || currentPage == (totalPage -1))
                        {
                            sixth = totalPage;
                            fifth = totalPage - 1;
                            fourth = totalPage - 2;
                            third = totalPage - 3;
                            second = totalPage - 4;

                        }
                       
                        Console.Write($"{first} {second} {third} {fourth} {fifth} {sixth}");

                        // For last page
                        if (totalPage > sixth)
                        {
                            Console.Write(" ..... ");
                            List<int> lastPage = new List<int>();
                            int temp = totalPage;
                            lastPage.Add(temp);

                            for (int a = 0; a < 4; a++)
                            {
                                temp = temp - 1;
                                if (temp > sixth)
                                {
                                    lastPage.Add(temp);
                                }
                            }

                            for (int b = lastPage.Count() - 1; b >= 0; b--)
                            {
                                Console.Write(lastPage[b] + " ");
                            }

                        }
                    }

                    Console.WriteLine();

                }

                testcase--;
                caseNum++;
            }
        }
    }
}
