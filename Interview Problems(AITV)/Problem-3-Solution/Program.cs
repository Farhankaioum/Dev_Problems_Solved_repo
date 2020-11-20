using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_3_Solution
{
    class Program
    {
        public static bool FileNameInLowerCase()
        {
            return true;
        }
        static void Main(string[] args)
        {
            string  pattern = $"^[a-z.]+$";

            using (var sr = new StreamReader(Console.OpenStandardInput(), Console.InputEncoding))
            {
                var inputs = sr.ReadToEnd();
                var splitInput = inputs.Split("\r\n").Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

                if (splitInput.Count <= 50)
                {
                    foreach (var input in splitInput)
                    {
                        var fileName = input.Split(' ');

                        var equalFileName = fileName.All(i => i.Length == fileName[0].Length);
                        var matchingWord = new StringBuilder();

                        if (equalFileName && (fileName.Length >= 1 && fileName.Length <= 50) && fileName.All(f => Regex.IsMatch(f, pattern)))
                        {
                            for (int i = 0; i < fileName.Length - 1; i++)
                            {
                                matchingWord.Clear();
                                var charArray1 = fileName[i].ToCharArray();
                                var charArray2 = fileName[i + 1].ToCharArray();

                                for (int j = 0; j< charArray1.Length; j++)
                                {
                                    if (charArray1[j].Equals(charArray2[j]))
                                    {
                                        matchingWord.Append(charArray1[j]);
                                    }
                                    else
                                    {
                                        matchingWord.Append('?');
                                    }
                                }
                            }

                            Console.WriteLine(matchingWord.ToString());
                            matchingWord.Clear();
                        }

                       
                    }
                }

              
            }

        }
    }
}
