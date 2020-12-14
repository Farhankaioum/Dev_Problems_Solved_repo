using System;
using System.Collections.Generic;
using System.Linq;

namespace e_1
{
    class Program
    {


        static void Main(string[] args)
        {
            string[] strArr = {"hellocat", "apple,bat,cat,goodbye,hello,yellow,why"};

            var wordToCompare = strArr[0];

            var stringDictionary = strArr[1];

            var singleStrings = stringDictionary.Split(',').AsEnumerable();

            string answerWords = string.Empty;

           var word = singleStrings.Select((firstWord) =>
            {

                var splitMainWordArray = wordToCompare.Split(firstWord);

                if (splitMainWordArray.Length > 0)
                {
                    splitMainWordArray.Select((word) =>
                    {
                        var joinedWord = firstWord + word;
                        var reversedWord = joinedWord.Reverse().ToString();

                        if(joinedWord == wordToCompare || reversedWord == wordToCompare)
                        {
                            answerWords = "" + firstWord + ", " + word + "";
                            return answerWords;
                        }
                        else
                        {
                            return "NotPossible";
                        }
                    });
                }

                return answerWords;
            });

            Console.WriteLine(word.ToArray()[0]);
        }
    }
}
