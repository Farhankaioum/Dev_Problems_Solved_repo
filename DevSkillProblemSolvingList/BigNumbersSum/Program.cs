using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
    public static string AddingBigSum(string str1, string str2)
    {
        if (str1.Length > str2.Length)
        {
            string temp = str1;
            str1 = str2;
            str2 = temp;
        }

        string strSum = "";

        int n1L = str1.Length, n2L = str2.Length;

        char[] ch = str1.ToCharArray();
        Array.Reverse(ch);
        str1 = new string(ch);

        char[] ch1 = str2.ToCharArray();
        Array.Reverse(ch1);
        str2 = new string(ch1);

        int carry = 0;
        for (int i = 0; i < n1L; i++)
        {
            int sum = ((int)(str1[i] - '0') + (int)(str2[i] - '0') + carry);
            strSum += (char)(sum % 10 + '0');

            carry = sum / 10;
        }

        for (int i = n1L; i < n2L; i++)
        {
            int sum = ((int)(str2[i] - '0') + carry);
            strSum += (char)(sum % 10 + '0');
            carry = sum / 10;
        }
        if (carry > 0)
        {
            strSum += (char)(carry + '0');
        }

        char[] ch2 = strSum.ToCharArray();
        Array.Reverse(ch2);
        strSum = new string(ch2);

        return strSum;
    }

    public static string ReverseStringNum(string str)
    {
        char[] ch = str.ToCharArray();
        Array.Reverse(ch);
        str = new string(ch);
        return str;
    }

    public static string RemoveLeadingZero(string str)
    {

        int b = 0;
        for (int i = 0; i<str.Length; i++)
        {
            if (!str[i].Equals('0'))
            {
                b = i;
                break;
            }
        }

        
       
        int count = Math.Abs(str.Length - b);
        char[] ch = new char[count];
        for (int i = 0; i<count ; i++)
        {
            ch[i] = str[i + b];
        }
        str = new string(ch);

        if (str[0].Equals('0'))
        {
            str = string.Empty;
            return str;
        }
        return str;
    }

    static void Main(string[] args)
    {

        List<List<string>> inputList = new List<List<string>>();
        List<List<string>> inputListReversed = new List<List<string>>();

        List<string> sumList = new List<string>();
        List<string> finalList = new List<string>();

        string line = "";
        while ((line = Console.ReadLine()) != null)
        {
            string[] inputs = line.Split(',');
            inputList.Add(new List<string> { inputs[0], inputs[1] });
        }

        foreach (var nums in inputList)
        {
            List<string> tempList = new List<string>();
            foreach (var n in nums)
            {
                var temp = Test.ReverseStringNum(n);
                tempList.Add(temp);
            }
            inputListReversed.Add(tempList);
        }

        foreach (var nums in inputListReversed)
        {
            for (int i = 0; i < nums.Count() - 1; i++)
            {
                var temp = Test.AddingBigSum(nums[i], nums[i + 1]);
                sumList.Add(temp);
            }
        }

        foreach (var num in sumList)
        {
            var reverse = Test.ReverseStringNum(num);
            var removeLeadingZero = Test.RemoveLeadingZero(reverse);
            finalList.Add(removeLeadingZero);
        }

        foreach (var num in finalList)
        {
            Console.WriteLine(num);
        }

    }
}

