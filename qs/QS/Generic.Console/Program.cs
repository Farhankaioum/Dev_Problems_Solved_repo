using System;

namespace Generic.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Example-1
            //var example1 = new Example1<int>();
            //example1.Id = 10;
            //System.Console.WriteLine(example1.Id);

            //// Example-2
            //var example2 = new Example2<User, int>();
            //example2.Add(
            //    new User { 
            //    Id = 1,
            //    Name = "Mahmudul"
            //});
            //example2.Add(
            //   new User
            //   {
            //       Id = 2,
            //       Name = "Hasan"
            //   });
            //example2.Add(
            //   new User
            //   {
            //       Id = 3,
            //       Name = "Hridoy"
            //   });

            //foreach (var item in example2.Entities)
            //{
            //    System.Console.WriteLine(item.Id + ": " + item.Name);
            //}

            // Example-3
            // var example3 = new Example3<User>();
            //var test = new Test();
            //test.Tt();

            var methodGeneric = new MethodGeneric();
            methodGeneric.Print<int>(10);
        }
    }
}
