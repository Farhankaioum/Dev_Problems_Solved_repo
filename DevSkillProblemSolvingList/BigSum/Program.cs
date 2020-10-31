using System;
using System.Collections.Generic;
using System.Linq;

namespace BigSum
{
   public class Test
    {
        
        public static List<int> RemoveLeadingZeroFromList(List<int> nums)
        {
            List<int> newList = new List<int>();
            int b = -1;
            foreach (var n in nums)
            {
                if (n != 0)
                {
                    b = Array.IndexOf(nums.ToArray(), n);
                    break;
                }
            }

            if (b == -1)
            {
                return new List<int>();
            }
            int count = Math.Abs(nums.Count() - b);
            for (int i = 0; i < count; i++)
            {
                newList.Add(nums[i + b]);
            }
            return newList;

        }

        public static List<int> ReverseList(List<int> numbers)
        {
            List<int> newList = new List<int>();
            for(int i = numbers.Count()-1; i >=0; i--)
            {
                newList.Add(numbers[i]);
                
            }
            
            return newList;
            
        }

        public static List<int> SumTwoList(List<int> one, List<int> two)
        {
            if (one.Count() < two.Count())
            {
                List<int> temp = one;
                one = two;
                two = temp;
            }

            List<int> sumArr = new List<int>();
            int forHand = 0;
            int j = two.Count() - 1;
            for (int i = one.Count()-1 ; i >= 0; i--, j--)
            {
                int  twoValue =0;

                twoValue = j >= 0 ? two[j] : 0;
                
                
                var sum = (one[i] + twoValue + forHand).ToString();
                
                if (sum.Length <= 1)
                {
                    sumArr.Add(int.Parse(sum));
                    forHand = 0;
                }
                else
                {
                    if (i == 0)
                    {
                        sumArr.Add(int.Parse(sum));
                       
                    }
                    else
                    {
                        string hand = sum[0].ToString();
                        string addVal = sum[1].ToString();

                        forHand = int.Parse(hand);
                        sumArr.Add(int.Parse(addVal));
                    }
                  

                }
                
            }
             sumArr.Reverse();
            return sumArr;
        }

        //main method
        static void Main(string[] args)
        {


            //9999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999999 };


            //var reverse1Num1 = ReverseList(num1);
            //var reverse1Num2 = ReverseList(num2);

            //Console.WriteLine(reverse1Num1.Count());
            //Console.WriteLine(reverse1Num2.Count());

            //var sum = SumTwoList(reverse1Num1, reverse1Num2);
            //Console.WriteLine(sum.Count());

            //var re = ReverseList(sum);
            //Console.WriteLine(re.Count());


            //var removeL = RemoveLeadingZeroFromList(re);
            //Console.WriteLine(removeL.Count());

            //foreach (var s in removeL)
            //{
            //    Console.Write(s);
            //}
            //Console.WriteLine();






            //List<List<int>> inputArr1 = new List<List<int>>();
            //List<List<int>> inputArr2 = new List<List<int>>();

            //List<List<int>> reverseInputArr1 = new List<List<int>>();
            //List<List<int>> reverseInputArr2 = new List<List<int>>();

            //List<List<int>> numSum = new List<List<int>>();
            //List<List<int>> reverseSum = new List<List<int>>();

            //string line;
            //while ((line = Console.ReadLine()) != null)
            //{
            //    string[] inputs = line.Split(',');

            //    string firstchar = inputs[0].ToString();
            //    string secondchar = inputs[1].ToString();


            //    List<string> firstCharStrArr = new List<string>();
            //    List<string> secondCharStrArr = new List<string>();

            //    for (int i = 0; i < firstchar.Length; i++)
            //    {
            //        firstCharStrArr.Add(firstchar[i].ToString());
            //    }
            //    for (int i = 0; i < secondchar.Length; i++)
            //    {
            //        secondCharStrArr.Add(secondchar[i].ToString());
            //    }

            //    List<int> arrFirstInput = new List<int>();
            //    List<int> arrSecondInput = new List<int>();

            //    for (int i = 0; i < firstCharStrArr.Count(); i++)
            //    {
            //        arrFirstInput.Add(Convert.ToInt32(firstCharStrArr[i]));
            //    }
            //    inputArr1.Add(arrFirstInput);

            //    for (int i = 0; i < secondCharStrArr.Count(); i++)
            //    {
            //        arrSecondInput.Add(Convert.ToInt32(secondCharStrArr[i]));
            //    }
            //    inputArr2.Add(arrSecondInput);
            //}

            //// for reverse input array
            //foreach (var inputs1 in inputArr1)
            //{
            //    var reverse = ReverseList(inputs1);
            //    reverseInputArr1.Add(reverse);
            //}

            //foreach (var inputs1 in inputArr2)
            //{
            //    var reverse = ReverseList(inputs1);
            //    reverseInputArr2.Add(reverse);
            //}

            //// for sum reverse input's array
            //for (int i = 0; i < reverseInputArr1.Count(); i++)
            //{
            //    var sums = SumTwoList(reverseInputArr1[i], reverseInputArr2[i]);
            //    numSum.Add(sums);
            //}

            ////for reverse final sum
            //for (int i = 0; i < numSum.Count(); i++)
            //{
            //    var sumReverse = ReverseList(numSum[i]);
            //    var removeLeadingZero = RemoveLeadingZeroFromList(sumReverse);
            //    reverseSum.Add(removeLeadingZero);
            //}

            //foreach (var num in reverseSum)
            //{
            //    foreach (var n in num)
            //    {
            //        Console.Write(n);
            //    }
            //    Console.WriteLine();
            //}


        }
    }
}
