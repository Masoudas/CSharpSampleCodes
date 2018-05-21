using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Triange triange = new Triange();
            triange.Height = 10;
            triange.Width = 5;
            triange.Style = "Perpendicular";
            triange.ShowDim();
            triange.ShowStyle();
            Console.WriteLine("Triangle area is " + triange.Area());

            Console.ReadLine();
        }
    }
}
