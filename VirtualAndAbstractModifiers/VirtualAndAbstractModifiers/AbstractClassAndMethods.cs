using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualAndAbstractModifiers
{
    /* A class that contains one or more abstract methods must also be declared as abstract by
       preceding its class declaration with the abstract specifier. Since an abstract class does not
       define a complete implementation, there can be no objects of an abstract class. */

    /* Don't forget that when calling a class abstract, methods and fields in the class that are not abstract will be directly inherited!*/

    /* Here's the wonderful thing about abstract classes. There cannot be an instance of such classes. However, a reference of their type can be defined.
       Hence, when TwoDShape is defined as the base abstract class, you cannot have an new operator to create an instance of it, but you can define
       a reference of its type.*/
    abstract class AbstractTwoDShape
    {
        double pri_width;
        double pri_height;
        // A default constructor.
        public AbstractTwoDShape()
        {
            Width = Height = 0.0;
            name = "null";
        }
        // Parameterized constructor.
        public AbstractTwoDShape(double w, double h, string n)
        {
            Width = w;
            Height = h;
            name = n;
        }
        // Construct object with equal width and height.
        public AbstractTwoDShape(double x, string n)
        {
            Width = Height = x;
            name = n;
        }
        // Construct a copy of a TwoDShape object.
        public AbstractTwoDShape(AbstractTwoDShape ob)
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
     
        // Now, Area() is abstract.
        public abstract double Area();

        public virtual void Action()    // It is no problem naming a method virtual in an abstract class.
        {

        }
    }

    // A derived class of TwoDShape for triangles.
    class TriangleFromAbstract : AbstractTwoDShape
    {
        string Style;
        // A default constructor.
        public TriangleFromAbstract()
        {
            Style = "null";
        }
        // Constructor for Triangle.
        public TriangleFromAbstract(string s, double w, double h) :
          base(w, h, "triangle")
        {
            Style = s;
        }
        // Construct an isosceles triangle.
        public TriangleFromAbstract(double x) : base(x, "triangle")
        {
            Style = "isosceles";
        }
        // Construct a copy of a Triangle object.
        public TriangleFromAbstract(TriangleFromAbstract ob) : base(ob)
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
    class RectangleFromAbstract : AbstractTwoDShape
    {
        // Constructor for Rectangle.
        public RectangleFromAbstract(double w, double h) : base(w, h, "rectangle") { }
        
        // Construct a square.
        public RectangleFromAbstract(double x) :  base(x, "rectangle") { }
        
        // Construct a copy of a Rectangle object.
        public RectangleFromAbstract(RectangleFromAbstract ob) : base(ob) { }
        
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