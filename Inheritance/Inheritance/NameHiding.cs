using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class A
    {
        public int i = 0;
        public int j = 0;
    }
    // Create a derived class.
    class B : A
    {
        int i; // The compiler issues a warning saying this name is overridden. It is overridden and is no problem, but we can remedy the warning by using the new keyword, like "j" below!
        new int j;  // This use of new is different from the use for creating a place inside of the memory!
        public B(int b)
        {
            i = b; // i in B
            Console.WriteLine("i in derived class is: " + i + " and i in the base class is: " + base.i);  // We can access the "i" in the base class.
        }
        public void Show()
        {
            
        }
    }
}
