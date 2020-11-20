using System;

namespace Problem_4_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = Console.ReadLine();
            var doomsDay = "ok";

            var numbers = userInput.Split('-');
            bool day = true, month = true, year = true;
            var storeDate = new Dictionary<string, int>();
            var sampleDate = "";

            foreach (var date in numbers)
            {
                if (date.Length > 0)
                {
                    var num = Convert.ToInt32(date);
                    if (day)
                    {
                        if (num <= 31)
                        {
                            day = false;
                            sampleDate += date;
                            sampleDate += "-";
                        }
                        else if (num >= 2013 && num <= 2015)
                        {
                            var date1 = num / 100;
                            sampleDate += date.ToString();
                            day = false;
                            sampleDate += "-";
                        }
                    }
                    else if (month && num <= 12)
                    {
                        sampleDate += date;
                        sampleDate += "-";
                        month = false;
                    }
                    else if (!day && !month && year && num >= 2013 && num <= 2015)
                    {
                        sampleDate += date;
                        if (sampleDate.Length == 10)
                        {
                            if (storeDate.ContainsKey(sampleDate)) storeDate[sampleDate]++;
                            else storeDate[sampleDate] = 1;
                            sampleDate = "";
                            var newdate = num % 100;
                            if (newdate <= 31)
                            {
                                sampleDate += newdate.ToString();
                                sampleDate += "-";
                            }
                            day = true;
                            year = true;
                        }
                    }
                }
            }

            var tmp = 0;
            foreach (var result in storeDate)
            {
                if (result.Value > tmp)
                {
                    tmp = result.Value;
                    doomsDay = result.Key;
                }
            }

            Console.WriteLine(doomsDay);

            Console.WriteLine(sampleDate);
        }
    }
}
