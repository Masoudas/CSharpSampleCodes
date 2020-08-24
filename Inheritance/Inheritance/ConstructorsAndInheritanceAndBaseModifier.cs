using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class TwoDShapeb    // This is the base class.
    {
        double pri_width;
        double pri_height;
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

        public void ShowDim()
        {
            Console.WriteLine("Width and height are " + Width + " and " + Height);
        }
    }

    /**
    Because the base class has only a default constructor, it's implicitly called in each constructor here!
    */
    class Triangle : TwoDShapeb
    {
        // The constructor of this class constructs every single of the sub-class and super class.
        string Style;
        
        // Constructor.
        public Triangle(string s, double w, double h)   
        {
            Width = w;  // init the base class
            Height = h; // init the base class
            Style = s;  // init the derived class
        }

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

    /* ---------------------------------------------------------------------------------------- */

    class TwoDShapec
    {

        public  double Width;
        public double Height;
       

        public TwoDShapec()
        {
            Width = 10;
            Height = 20;
            Console.WriteLine("Inside the base class constructor!");
        }
    }

    class Trianglec : TwoDShapec
    {
        // Here's the thing. The constructor of the base class is always going to be called, regardless of whether or not you want it!
        // Although it is worth pointing out that the parameters that are initialized inside the sub-class are ok!
        string Style;

        // Constructor.
        public Trianglec(string s, double w, double h)
        {
            Width = w;  // init the base class
            Height = h; // init the base class
            Style = s;  // init the derived class
            Console.WriteLine(Style + " " + Width + " " + Height);
        }

    }

    class Triangled : TwoDShapec
    {
        string Style;

        // Constructor.
        public Triangled(string s):base()   // This initialization is simply redundant, given that the base class constructor is naturally going to be called!
        {
            Style = s;  // init the derived class
            Console.WriteLine(Style + " " + Width + " " + Height);
        }

    }
}



