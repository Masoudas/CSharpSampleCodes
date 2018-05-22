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



            Console.ReadLine();
        }
    }
}
