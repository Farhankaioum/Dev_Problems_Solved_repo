using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    static void Main(string[] args)
    {


        //// ** Not Accepted ** //

        List<List<string>> originalsNum = new List<List<string>>();
        List<List<string>> reportsNum = new List<List<string>>();

        List<List<string>> filterSuccessList = new List<List<string>>();
        List<List<string>> filterFailedList = new List<List<string>>();


        List<string> successFilter = new List<string>();
        List<string> failedFilter = new List<string>();

        int testCase;
        int.TryParse(Console.ReadLine(), out testCase);

        if (testCase <= 10)
        {
            for (int i = 0; i < testCase; i++)
            {
                int howMuchInput;
                int.TryParse(Console.ReadLine(), out howMuchInput);

                if (howMuchInput <= 100)
                {
                    List<string> orgNum = new List<string>();
                    List<string> repNum = new List<string>();

                    for (int b = 0; b < howMuchInput; b++)
                    {
                        string input = Console.ReadLine();
                        if (input.All(char.IsDigit) && !input.Any(char.IsWhiteSpace) && !input.Contains("_"))
                        {
                            orgNum.Add(input);
                        }

                    }
                    originalsNum.Add(orgNum);

                    for (int b = 0; b < howMuchInput; b++)
                    {
                        repNum.Add(Console.ReadLine());
                    }
                    reportsNum.Add(repNum);

                }
                if (i < testCase -1)
                {
                    Console.ReadLine();
                }
              
            }
        }

        int count = 0;
        string msg = string.Empty;
        string reportValueInput = string.Empty;
        string originalValueInput = string.Empty;

        for (int i = 0; i < originalsNum.Count(); i++)
        {
            for (int j = 0; j < reportsNum[i].Count(); j++)
            {
                count = 0;

                string[] reportInputs = reportsNum[i][j].Split(',');
                string reportInput1 = reportInputs[0];
                string reportInput2 = reportInputs[1];

                string reportFirst = reportInput1.Substring(0, 3);
                string reportLast = reportInput1.Substring(7);


                for (int k = 0; k < originalsNum[i].Count(); k++)
                {
                    string firstdigit = originalsNum[i][k].Substring(0, 3);
                    string lastdigit = originalsNum[i][k].Substring(7);

                    //check number is equal or not
                    if (reportFirst == firstdigit && reportLast == lastdigit)
                    {
                        count++;
                        reportValueInput = reportInput1;
                        originalValueInput = originalsNum[i][k];

                        msg = reportInput2;

                    }
                }

                if (count > 1)
                {
                    if (msg.ToUpper() == "SUCCESS")
                    {
                        successFilter.Add(reportValueInput + " : " + "Confused");
                    }
                    else
                    {
                        failedFilter.Add(reportValueInput + " : " + "Confused");
                    }

                }
                else
                {
                    if (msg.ToUpper() == "SUCCESS")
                    {
                        successFilter.Add(reportValueInput + " : " + originalValueInput);
                    }
                    else
                    {
                        failedFilter.Add(reportValueInput + " : " + originalValueInput);
                    }
                }
            }
            filterSuccessList.Add(successFilter);
            filterFailedList.Add(failedFilter);

            successFilter = new List<string>();
            failedFilter = new List<string>();

        }

        int case1 = 1;
        for (int i = 0; i < filterSuccessList.Count(); i++)
        {
            Console.WriteLine("Case: " + case1);
            Console.WriteLine("Success list");
            for (int j = 0; j < filterSuccessList[i].Count(); j++)
            {
                Console.WriteLine(filterSuccessList[i][j]);
            }
            Console.WriteLine("Failed list");
            for (int k = 0; k < filterFailedList[i].Count(); k++)
            {
                Console.WriteLine(filterFailedList[i][k]);
            }
            case1++;
        }

    }
}

