using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualAndAbstractAndSealedModifiers
{
    // NEVER EVER USE VIRTUAL METHODS WITHIN THE CONSTRUCTOR, ESPECIALLY IN THE CASE OF INHERITANCE. WHY?
    // BECAUSE THE INHERITED METHOD WILL CALL THE VIRTUAL METHOD OF THE CURRENT CLASS FOR THE CONSTRUCTOR OF THE BASE CLASS
    // WHICH MAY CAUSE SEVERAL PROBLEMS!

    /* The biggest difference between virtual and abstract methods: 
     * 1- The virtual method can be used right from the base class, where as abstract methods cannot.
       That being said, refering to the base class is the same for the two cases.*/


    /* Aside from allowing the user to override methods in the derived class, another very important feature of virtual methods is this:
       if a base class contains a virtual method and classes are derived from that base class, then when different types of objects are referred to
       through a base class reference, different versions of the virtual method can be executed.*/

    /* Don't forget that you do not necessarily need virtual methods. You as well use the "new" keyword to declare methods in the 
     * subclass. But don't forget that this may not always be desirable*/

    class Base
    {
        // Create virtual method in the base class.
        // Note: As we can see, the virtual method can have a body of its own in the base class.
        public virtual void Who()
        {
            Console.WriteLine("Who() in Base");
        }

        public void Who(string str) // What happens with polymorphism and virtual methods?
        {
            Console.WriteLine("Who() in Base overloaded!");
            
        }

        /* The key point of calling this overridden method virtual is to allow the base reference to perform the last version in the 
            hierarchy when assigned to the base reference. So ok!*/
        public virtual void Who(int val) // What happens with polymorphism and virtual methods?
        {
            Console.WriteLine("Who() in Base overloaded again, but as virtual!");
        }
    }

    class Derived1 : Base
    {
        // Override Who() in a derived class.
        public override void Who()
        {
            Console.WriteLine("Who() in Derived1");
        }

        public override void Who(int val) // What happens with polymorphism and virtual methods?
        {
            Console.WriteLine("Who() in Derived 1 overloaded and overridden!");
        }
    }

    class Derived2 : Base
    {
        // Override Who() again in another derived class.
        public override void Who()
        {
            Console.WriteLine("Who() in Derived2");
        }

        public override void Who(int val) // What happens with polymorphism and virtual methods?
        {
            Console.WriteLine("Who() in Derived 2 overloaded and overridden!");
        }
    }
}
