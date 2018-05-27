using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualAndAbstractAndSealedModifiers
{
    class TwoDShape
    {
        double pri_width;
        double pri_height;
        // A default constructor.
        public TwoDShape()
        {
            Width = Height = 0.0;
            name = "null";
        }
        // Parameterized constructor.
        public TwoDShape(double w, double h, string n)
        {
            Width = w;
            Height = h;
            name = n;
        }
        // Construct object with equal width and height.
        public TwoDShape(double x, string n)
        {
            Width = Height = x;
            name = n;
        }
        // Construct a copy of a TwoDShape object.
        public TwoDShape(TwoDShape ob)
        {
            Width = ob.Width;
            Height = ob.Height;
            name = ob.name;
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

        public string name { get; set; }
        public void ShowDim()
        {
            Console.WriteLine("Width and height are " +
                               Width + " and " + Height);

        }

        public virtual double Area()
        {
            Console.WriteLine("Area() must be overridden");
            return 0.0;
        }
    }

    // A derived class of TwoDShape for triangles.
    class Triangle : TwoDShape
    {
        string Style;
        // A default constructor.
        public Triangle()
        {
            Style = "null";
        }
        // Constructor for Triangle.
        public Triangle(string s, double w, double h) :
          base(w, h, "triangle")
        {
            Style = s;
        }
        // Construct an isosceles triangle.
        public Triangle(double x) : base(x, "triangle")
        {
            Style = "isosceles";
        }
        // Construct a copy of a Triangle object.
        public Triangle(Triangle ob) : base(ob)
        {
            Style = ob.Style;
        }
        // Override Area() for Triangle.
        public override double Area()
        {
            return Width * Height / 2;
        }
        // Display a triangle's style.
        public void ShowStyle()
        {
            Console.WriteLine("Triangle is " + Style);
        }
    }

    // A derived class of TwoDShape for rectangles.
    class Rectangle : TwoDShape
    {
        // Constructor for Rectangle.
        public Rectangle(double w, double h) : base(w, h, "rectangle") { }

        // Construct a square.
        public Rectangle(double x) : base(x, "rectangle") { }
        // Construct a copy of a Rectangle object.

        public Rectangle(Rectangle ob) : base(ob) { }
        // Return true if the rectangle is square.

        public bool IsSquare()
        {
            if (Width == Height) return true;
            return false;
        }

        // Override Area() for Rectangle.
        public override double Area()
        {
            return Width * Height;
        }
    }
}
