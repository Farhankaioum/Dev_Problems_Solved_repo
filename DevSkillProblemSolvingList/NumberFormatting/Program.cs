using System;

namespace NumberFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int testcases = int.Parse(Console.ReadLine());
            if (testcases >= 1 && testcases <= 50)
            {
                for (int i = 0; i < testcases; i++)
                {
                    var input = Console.ReadLine();
                    if (input.StartsWith("88"))
                    {
                        var res = input.Substring(2, 3);
                        switch (res)
                        {
                            case "011":
                                Console.WriteLine(input + " " + "Citycell");
                                break;
                            case "015":
                                Console.WriteLine(input + " " + "Teletalk");
                                break;
                            case "016":
                                Console.WriteLine(input + " " + "Airtel");
                                break;
                            case "017":
                                Console.WriteLine(input + " " + "Grameenphone");
                                break;
                            case "018":
                                Console.WriteLine(input + " " + "Robi");
                                break;
                            case "019":
                                Console.WriteLine(input + " " + "Banglalink");
                                break;
                        }
                    }
                    else
                    {
                        var res = input.Substring(0, 3);
                        switch (res)
                        {
                            case "011":
                                Console.WriteLine("88" + input + " " + "Citycell");
                                break;
                            case "015":
                                Console.WriteLine("88" + input + " " + "Teletalk");
                                break;
                            case "016":
                                Console.WriteLine("88" + input + " " + "Airtel");
                                break;
                            case "017":
                                Console.WriteLine("88" + input + " " + "Grameenphone");
                                break;
                            case "018":
                                Console.WriteLine("88" + input + " " + "Robi");
                                break;
                            case "019":
                                Console.WriteLine("88" + input + " " + "Banglalink");
                                break;
                        }
                    }
                }
            }
        }
    }
}
