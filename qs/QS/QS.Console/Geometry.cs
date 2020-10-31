using System.Security.Cryptography;

namespace QS.Console
{
    public class Geometry
    {
        public double CalculateArea(Shape shape)
        {
            if (shape is Circle)
            {
                Circle circle = (Circle)shape;

                return 3.1416 * (circle.Radius * circle.Radius);

            } else if (shape is Rectangle)
            {
                Rectangle rectangle = (Rectangle)shape;

                return rectangle.Height * rectangle.Width;
            }
            else if (shape is Traingle)
            {
                Traingle traingle = (Traingle)shape;

                return (traingle.Side1 * traingle.Side2) / 2;
            }

            return 0;
        }

        public void CalculatePerimeter(Shape shape)
        {

        }


    }
}
