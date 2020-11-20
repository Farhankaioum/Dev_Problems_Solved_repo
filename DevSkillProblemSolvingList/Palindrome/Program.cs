using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindrome
{
   public class Test
    {
        //public static bool PalindromeCheck(string input)
        //{
        //    char[] ch = input.ToCharArray();
        //    string newInput = string.Empty;
        //    for (int i = ch.Length - 1; i >= 0; i--)
        //    {
        //        newInput += ch[i];
        //    }
            
        //    return input.ToUpper().Equals(newInput.ToUpper());
        //}
        static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());
            List<string> listofstring = new List<string>();
            for (int i = 0; i<count; i++)
            {
                string input = Console.ReadLine();
                if (input.Length < 1000)
                {
                    listofstring.Add(input);
                }
            }
           
            foreach (var list in listofstring)
            {
                var anoI = list.Reverse();
                foreach (var an in anoI)
                {
                    Console.Write(an);
                }
                Console.WriteLine();
            }

            //int testcase = Convert.ToInt32(Console.ReadLine());
            //List<string> listOfInput = new List<string>();
           
            //    for (int i = 0; i < testcase; i++)
            //    {
            //        string input = Console.ReadLine();
            //        if (input.Length <= 100)
            //        {
            //            bool result = input.All(c => char.IsLetterOrDigit(c));
            //            if (result)
            //            {
            //                listOfInput.Add(input);
            //            }
            //        }
                   
                
            //}
            //for (int i = 0; i < listOfInput.Count(); i++)
            //{
            //    var result = PalindromeCheck(listOfInput[i]);
            //    if (result)
            //    {
            //        Console.WriteLine("Yes");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No");
            //    }
            //}
        }
    }
}
