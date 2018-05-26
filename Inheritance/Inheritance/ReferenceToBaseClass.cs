using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class AnotherTwoDShape
    {
        // This is one scenario where reference to the base class becomes handy! See the AnotherTriangle class.
        double pri_width;
        double pri_height;

        // Constructor for TwoDShape.
        public AnotherTwoDShape(double w, double h)
        {
            Width = w;
            Height = h;
        }

        // Construct a copy of a TwoDShape object.
        public AnotherTwoDShape(AnotherTwoDShape ob)
        {
            Width = ob.Width;
            Height = ob.Height;
        }

        // Properties for Width and Height.
        public double Width
        {
            get { return pri_width; }
            set { pri_width = value < 0 ? -value : value; }
        }

        public double Height
        {
            get { return pri_height; }
            set { pri_height = value < 0 ? -value : value; }
        }

    }

    class AnotherTriangle : AnotherTwoDShape
    {
        // The constrocturs in this class take AnotherTriangle as input as well. They can refer their base part to the base class, which takes
        // care of creating them.

        string Style;

        // Constructor for Triangle.
        public AnotherTriangle(string s, double w, double h) : base(w, h)
        {
            Style = s;
        }

        // Construct a copy of a Triangle object.
        public AnotherTriangle(AnotherTriangle ob) : base(ob) // Only the part related to the base class is sent up!
        {
            Style = ob.Style;
        }
        // Return area of triangle.
        public double Area()
        {
            return Width * Height / 2;
        }

    }
}
