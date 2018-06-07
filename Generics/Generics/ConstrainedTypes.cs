using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    /* Constrained types allow you to limit the types assigned to a generic.
       There are five types of constraint:
       1- Base class constraint
       2- Interface constraint
       3- Constructor constraint
       4- Reference type constraint
       5- Value type constraint
    */

    /* Base class constraint: The base class constraint enables you to specify a base class that a type argument must inherit.
       This constraint does two things:
       1- It lets you use the members of the base class specified by the constraint within the generic class (inside of class constraint)
       2- It ensures that only type arguments that support the specified base class are used (usage constraint).
    */
    class BaseConstraintGeneric<T> where T:A
    {
        T obj;
        public BaseConstraintGeneric(T o)
        {
            obj = o;
        }
        public void SayHello()
        {
            // OK to call Hello() because it’s declared
            // by the base class A.
            obj.Hello();
        }
    }

    /* Interface constraint: 
     * 




    // Some extra classes.
    class A
    {
        public void Hello()
        {
            Console.WriteLine("Hello");
        }
    }
    // Class B inherits A.
    class B : A { }
    // Class C does not inherit A.
    class C { }
}
