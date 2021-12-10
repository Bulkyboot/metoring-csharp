using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetoringCsharp.Challenge.Rectangle
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area(double width, double height)
        {
            return width * height;
        }

        public double Perimeter(double width, double height)
        {
            return width + width + height + height;
        }

        public double Diagonal(double width, double height)
        {
            double result = (width * width) + (height * height);

            return result = Math.Sqrt(result);
        }
    }
}
