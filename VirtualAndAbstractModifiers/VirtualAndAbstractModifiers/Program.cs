using System;

namespace VirtualAndAbstractAndSealedModifiers
{ //Ey.
    class Program
    {
        static void Main(string[] args)
        {
            // Using virtual keyword!
            Base baseOb = new Base();
            Derived1 dOb1 = new Derived1();
            Derived2 dOb2 = new Derived2();

            Base baseRef; // a base class reference
            baseRef = baseOb;
            baseRef.Who();  // This time, the method of the base class is executed.
            baseRef.Who(2);
            baseRef.Who();
            Console.WriteLine("");
            baseRef = dOb1;
            baseRef.Who();  // Now, the method of the first derived class is executed.
            baseRef.Who(2);
            baseRef.Who();
            Console.WriteLine("");
            baseRef = dOb2;
            baseRef.Who(); // Now, the method of the second derived class is executed.
            baseRef.Who(2);
            baseRef.Who();

            // Using virtual in practice
            /* Note that the shapes array is defined in the base class. The assigned elements are in the derived classes,
             * hence they can only call on the method present in the base class!*/
            TwoDShape[] shapes = new TwoDShape[5];
            shapes[0] = new Triangle("right", 8.0, 12.0);
            shapes[1] = new Rectangle(10);
            shapes[2] = new Rectangle(10, 4);
            shapes[3] = new Triangle(7.0);
            shapes[4] = new TwoDShape(10, 20, "generic");
            for (int i = 0; i < shapes.Length; i++)
            {
                //shapes[1].IsSquare(). You can see that we do not have access to this method here!
                Console.WriteLine("object is " + shapes[i].name);
                Console.WriteLine("Area is " + shapes[i].Area());
                Console.WriteLine();
            }


            // Using abstract classes.
            AbstractTwoDShape[] abstractshapes = new AbstractTwoDShape[4];
            abstractshapes[0] = new TriangleFromAbstract("right", 8.0, 12.0);
            abstractshapes[1] = new RectangleFromAbstract(10);
            abstractshapes[2] = new RectangleFromAbstract(10, 4);
            abstractshapes[3] = new TriangleFromAbstract(7.0);
            for (int i = 0; i < abstractshapes.Length; i++)
            {
                Console.WriteLine("object is " + abstractshapes[i].name);
                Console.WriteLine("Area is " + abstractshapes[i].Area());   // The same story again, meaning the last definition of Area for objects is grabbed!
                Console.WriteLine();
            }

            // Object is the universal type, hence it can hold any class, though it is rarely used!
            object obj = new object[]{ 1, "1", 101d, abstractshapes[0], shapes[2]};

            // Boxing and Unboxing
            int x = 10;
            Console.WriteLine(BoxAndUnBox.Sqrt(x));    // A boxing is performed here!

            Console.ReadKey();
        }
    }
}
