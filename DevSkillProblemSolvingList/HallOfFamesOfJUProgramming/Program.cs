using System;

namespace HallOfFamesOfJUProgramming
{

    public class Program
    {
        public static string AddingStringNum(string str1, string str2)
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


        static string StringDivision(string number, int divisor)
        {
            string ans = "";
            
            int idx = 0;
            int temp = (int)(number[idx] - '0');
            while (temp < divisor)
            {
                temp = temp * 10 + (int)(number[idx + 1] - '0');
                idx++;
            }
            ++idx;
            
            while (number.Length > idx)
            {
                ans += (char)(temp / divisor + '0');
                
                temp = (temp % divisor) * 10 + (int)(number[idx] - '0');
                idx++;
            }
            ans += (char)(temp / divisor + '0');
            
            if (ans.Length == 0)
                return "0";
 
            return ans;
        }
        static void Main(string[] args)
        {
            int testcase = int.Parse(Console.ReadLine());
            while (testcase > 0)
            {
                var inputs = Console.ReadLine().Split(' ');
                var first = inputs[0];
                var second = inputs[1];

                var sum = AddingStringNum(first, second);
                var finalSum = StringDivision(sum, 2);

                testcase--;
                Console.WriteLine(finalSum);
            }
        }
    }
}
