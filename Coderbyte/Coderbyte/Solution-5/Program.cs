using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution_5
{
    class Program
    {
        public static List<int> arrangedList = new List<int>();
        static void printArr(int[] a, int n)
        {
            string strNumber = string.Empty;

            for (int i = 0; i < n; i++)
            {
                strNumber = strNumber + a[i];
            }

            arrangedList.Add(Convert.ToInt32(strNumber));
        }

        static void heapPermutation(int[] a, int size, int n)
        {
            if (size == 1)
                printArr(a, n);

            for (int i = 0; i < size; i++)
            {
                heapPermutation(a, size - 1, n);
                if (size % 2 == 1)
                {
                    int temp = a[0];
                    a[0] = a[size - 1];
                    a[size - 1] = temp;
                }

                else
                {
                    int temp = a[i];
                    a[i] = a[size - 1];
                    a[size - 1] = temp;
                }
            }
        }
        public static void Main(string[] args)
        {
            int num =100;
            var listOfSeperatedNum = new List<int>();
            var listOfArrangedNum = new List<int>();

            while (num > 0)
            {
                listOfSeperatedNum.Add(num % 10);
                num = num / 10;
            }

            listOfSeperatedNum.Reverse();

            if(listOfSeperatedNum.Count() > 0)
            {
                var newArray = listOfSeperatedNum;
                var digit = newArray[0];
                newArray.RemoveAt(0);

                heapPermutation(newArray.ToArray(), newArray.Count(), newArray.Count());

                foreach (var item in arrangedList)
                {
                    string strNum = item.ToString() + digit.ToString();
                    listOfArrangedNum.Add(Convert.ToInt32(strNum));
                }

                int flag = 0;

                for (int i = 0; i < listOfArrangedNum.Count(); i++)
                {
                    if(listOfArrangedNum[i] < 2)
                    {
                        flag = 1;
                        break;
                    }

                    else
                    {
                        int number = listOfArrangedNum[i] / 2;
                        for (int j = 2; j <= number; j++)
                        {
                            if (listOfArrangedNum[i] % j == 0)
                            {
                                flag = 1;
                                break;
                            }
                        }
                    }

                   

                    if (flag == 1)
                    {
                        break;
                    }
                }

                if (flag == 1)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(1);
                }
            }

            else
            {
                Console.WriteLine(0);
            }

            

            
        }
    }
}
