using System;

namespace QS.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //var circle = new Circle();
            //circle.Radius = 2;

            //var geometry = new Geometry();
            //var value = geometry.CalculateArea(circle);
            //System.Console.WriteLine(value);

            var number = new JolyNumber();
            number.Increment();
            System.Console.WriteLine(number.Number);
        }
    }
}
