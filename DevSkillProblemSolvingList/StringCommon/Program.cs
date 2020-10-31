using System;

namespace StringCommon
{
    public class Program
    {
        public static int MaxLenCount(string str1, string str2)
        {
            int[,] num = new int[str1.Length, str2.Length];
            int maxlen = 0;

            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] != str2[j])
                        num[i, j] = 0;
                    else
                    {
                        if ((i == 0) || (j == 0))
                            num[i, j] = 1;
                        else
                            num[i, j] = 1 + num[i - 1, j - 1];

                        if (num[i, j] > maxlen)
                        {
                            maxlen = num[i, j];
                        }
                    }
                }
            }
            return maxlen;
        }
        static void Main(string[] args)
        {
            int testcount = int.Parse(Console.ReadLine());
            int casecount = 1;
            while (testcount > 0)
            {
                var inputs = Console.ReadLine().Split(' ');
                int result = MaxLenCount(inputs[0], inputs[1]);
                Console.WriteLine("Case " + casecount + ": " + result);

                testcount--;
                casecount++;
            }
        }
    }
}
