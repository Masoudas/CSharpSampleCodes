using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class TwoDShape
    {
        // For now, we neglect constructors.
        public double Width;
        public double Height;
        public void ShowDim()
        {
            Console.WriteLine("Width and height are " + Width + " and " + Height);
        }

    }

    class Triange: TwoDShape
    {
        public string Style; // style of triangle
                             // Return area of triangle.
        public double Area()
        {
            return Width * Height / 2;
        }

        // Display a triangle's style.
        public void ShowStyle()
        {
            Console.WriteLine("Triangle is " + Style);
        }
    }
}
