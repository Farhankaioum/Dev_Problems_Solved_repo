using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonString
{
    class Program
    {
        public static string SortStringValue(string value)
        {

            char[] ch = value.ToArray();
            Array.Sort(ch);
            string another = "";
            for (int i = 0; i < ch.Length; i++)
            {
                another += ch[i];
            }
            return another;
        }
        static void Main(string[] args)
        {

            int count = Convert.ToInt32(Console.ReadLine());
            List<string> listOfString = new List<string>();

            List<Dictionary<char, int>> charCount = new List<Dictionary<char, int>>();

            if (count > 0 && count <=30)
            {
                for (int i = 0; i < count; i++)
                {
                    string input = Console.ReadLine();
                    if (input.All(char.IsLetter) && input.All(char.IsLower))
                    {
                        if (input.Length <= 100)
                        {
                            listOfString.Add(input);
                        }

                    }
                }
            }
           
            foreach (var list in listOfString)
            {
                Dictionary<char, int> pairs = new Dictionary<char, int>();
                for (int i = 97; i <= 122; i++)
                {
                    if (list.Contains((char)i))
                    {
                        var chcount = list.Count(c => c == (char)i);
                        if (chcount > 0)
                        {
                            var ch = (char)(i);

                            pairs.Add(ch, chcount);

                        }

                    }
                }
                charCount.Add(pairs);
            }

            int cas = 1;
            foreach (var dict in charCount)
            {
                Console.WriteLine($"Case {cas}:");
                foreach (var d in dict)
                {
                    Console.WriteLine(d.Key + " " + d.Value);
                }
                cas++;
            }




        }
    }
}
