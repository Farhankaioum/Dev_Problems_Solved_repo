using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleUI
{
    public class Question_7
    {
        public void PrintSomethingFromDict(Dictionary<int, string> valuePairs)
        {
            foreach (var val in valuePairs)
            {
                Console.WriteLine(val.Key + " " + val.Value);
            }
        }
    }
}
