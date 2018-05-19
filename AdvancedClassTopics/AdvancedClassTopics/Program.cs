using System;

namespace AdvancedClassTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            RefAndOur access = new RefAndOur();

            int i = 5;
            access.Sqr(ref i);  // Very good that you have to actually give the ref here. i has to be initialized, or else we get an error.
            Console.WriteLine(i);

            double frac;
            i = access.GetParts(12.25, out frac);   // This is interesting and potentially very useful, you must declare a variable being out.
                                                    // Contrary to the above, frac does not need to be initialized.
            Console.WriteLine(i + " and " + frac);

            // See for yourself!
            RefToRef first = new RefToRef(1);
            RefToRef second = new RefToRef(2);
            RefToRef third;
            first.SwapCreate(ref first, ref second, out third);
            Console.WriteLine(first.member + " " + second.member + " " + third.member);


            // Variable input
            VariableFunctionIput variable1 = new VariableFunctionIput('a', 1, 2, 3);
            VariableFunctionIput variable2 = new VariableFunctionIput('a');
            VariableFunctionIput variable3 = new VariableFunctionIput('a', 1);


            // Conversion due to overload is important
            CoversionInOverloading coversionInOverloading = new CoversionInOverloading();


            // Constructor overloading.
            ConstructorOverloading constructorOverloading = new ConstructorOverloading();
            ConstructorOverloading constructorOverloading1 = new ConstructorOverloading(1,1);
            ConstructorOverloading constructorOverloading2 = new ConstructorOverloading(constructorOverloading1);
            ConstructorOverloading constructorOverloading3 = new ConstructorOverloading(1);

            // How static classes work.
            StaticClass.method1();  // Can be accessed from a static class.
            ClassWithStaticMembers.method1();

            // Instantiating a class with a static constructor
            StaticConstructor ob = new StaticConstructor(); // The good thing is that the static constructor cannot be called separately from the dynamic one.
            StaticConstructor ob1 = new StaticConstructor(); // The static constructor is also only called once, which is very good!
            Console.WriteLine("Cons.alpha: " + StaticConstructor.alpha);
            Console.WriteLine("ob.beta: " + ob.beta);


            // Instantiating classes with overloaded operator.
            UnaryBinaryOperatorOverloading unaryBinary = new UnaryBinaryOperatorOverloading(1, 2, 3);

            unaryBinary = - unaryBinary;   // Overloaded operator.
            Console.WriteLine(unaryBinary.x + " " + unaryBinary.y + " " + unaryBinary.z);

            unaryBinary += 5;   // Overloaded operator.
            Console.WriteLine(unaryBinary.x + " " + unaryBinary.y + " " + unaryBinary.z);

            unaryBinary = unaryBinary + unaryBinary; // Overloaded operator.
            Console.WriteLine(unaryBinary.x + " " + unaryBinary.y + " " + unaryBinary.z);

            unaryBinary++; // Overloaded operator.
            Console.WriteLine(unaryBinary.x + " " + unaryBinary.y + " " + unaryBinary.z);

            if (unaryBinary)
                Console.WriteLine("This object is non-zero, hence it is a true!");

            unaryBinary = unaryBinary | unaryBinary;    // Overloaded and!
            Console.WriteLine(unaryBinary.x + " " + unaryBinary.y + " " + unaryBinary.z);


            Console.ReadLine();
        }
    }


   
}
