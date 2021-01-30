using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace JsonRND
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var firstname = Console.ReadLine();
            var lastName = Console.ReadLine();

            var listOfData = new List<Student>();
            var data = System.IO.File.ReadAllText(@"I:\2_ProblemSolved\qs\QS\JsonRND\Data\" + "student.json");
            listOfData = new JavaScriptSerializer().Deserialize<List<Student>>(data);

            var std1 = new Student
            {
                FirstName = firstname,
                LastName = lastName
            };

            listOfData.Add(std1);

           

            var jsonData = new JavaScriptSerializer().Serialize(listOfData);
            System.IO.File.WriteAllText(@"I:\2_ProblemSolved\qs\QS\JsonRND\Data\" + "student.json", jsonData);
        }
    }
}
