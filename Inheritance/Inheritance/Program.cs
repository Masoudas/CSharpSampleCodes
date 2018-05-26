using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic inheritance example.
            Console.WriteLine("Hello World!");
            Triange triange = new Triange();
            triange.Height = 10;
            triange.Width = 5;
            triange.Style = "Perpendicular";
            triange.ShowDim();
            triange.ShowStyle();
            Console.WriteLine("Triangle area is " + triange.Area());

            // Using protected in class hierarchy.
            Trianglea trianglea = new Trianglea(5, 10);


            // Constructor and base
            Trianglec trianglec = new Trianglec("Perpendicular!", 2, 3);    // The base class constructor is naturally going to be called.
            Triangled triangled = new Triangled("Perpendicular");   // Again, The base class constructor is naturally going to be called. So no need to use base!

            // Name hiding.
            B b = new B(10);

            // Reference to the base class.
            TwoDShapeb twoDShapeb = new TwoDShapeb();
            Triangle triangle1 = new Triangle("A", 1, 1);
            twoDShapeb = triangle1;    // The reference of the base class is assigned the reference of the derived class. We would then have access only to the base class parameters of the derived class.
            Console.WriteLine(twoDShapeb.Height + " " + twoDShapeb.Width);


            // Refernece to base class in constructors
            AnotherTriangle t1 = new AnotherTriangle("right", 8.0, 12.0);
            // Make a copy of t1.
            AnotherTriangle t2 = new AnotherTriangle(t1);
            Console.WriteLine("Info for t1: ");
            Console.WriteLine("Area is " + t1.Area());
            Console.WriteLine();
            Console.WriteLine("Info for t2: ");
            Console.WriteLine("Area is " + t2.Area());





            Console.ReadLine();
        }
    }
}
