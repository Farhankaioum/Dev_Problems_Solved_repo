using System;
using System.Collections.Generic;
using System.Text;

namespace QS.Console
{
    public class Shape
    {

    }

    public class Circle : Shape
    {
        public int Radius { get; set; }
    }

    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class Traingle : Shape
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }
    }
}
