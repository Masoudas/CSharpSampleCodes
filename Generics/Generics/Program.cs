using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            // Using generics
            Gen<int,int> gen = new Gen<int,int>(5,5); // This is how we adopt a class to take int as an input!
                                                      // It is referred to as a closed constructed type.
                                                      // Thus, Gen<int> is a closed constructed type
                                                      // Gen<T> is called an open constructed type, because no close constructed type has been created yet.
            Gen<IrrelevantClass, int> gen1 = new Gen<IrrelevantClass, int>(new IrrelevantClass(), 10);  // Ok, this is interesting.
            gen.ShowTypes();
            Console.WriteLine();
            gen1.ShowTypes();

            int variable = gen.getOb(); // So this is very important. Basically generics allow this assignment without any casting. Had we used objects, 
                                        // we would have needed casting (specifically, we would have needed unboxing) here.
            Console.WriteLine("One variable is" + variable);


            // References to closed constructed types cannot be assigned to one another.
            //gen = gen1; This is wrong of course!



            /// Constrained generics
            // Base constrained type.
            A a = new A();
            B b = new B();
            C c = new C();

            BaseConstraintGeneric<A> t1 = new BaseConstraintGeneric<A>(a);
            t1.SayHello();
            BaseConstraintGeneric<B> t2 = new BaseConstraintGeneric<B>(b);
            t2.SayHello();
            // The following is invalid because C does not inherit A.
            //    Test<C> t3 = new Test<C>(c); // Error!
            //    t3.SayHello(); // Error!








            Console.ReadKey();
        }
    }

    class IrrelevantClass
    {
        int field; 
    }
}
