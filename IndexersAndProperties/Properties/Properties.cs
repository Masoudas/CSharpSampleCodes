using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    class PropertyClass
    {
        /* Most important point: a property is like a method. Hence, it does not define a storage space in the memory. Hence, I need to define a (private)
           field in the class. Otherwise, the property would be doing some action and allocates no space in the memory! The only exception is of course is the
           auto implemented properties!
           A property should not alter the state of the underlying variable when the get accessor is called. Although this rule is not enforced by the compiler,
           violating it is semantically wrong. A get operation should be nonintrusive.
        */
        int field;  // This is the private field that is going to be managed by properties.
                    // The property Myprop makes sure that it would always be positive.

        public PropertyClass(int value)
        {
            field = value;
            autoProp = 10;
            Console.WriteLine("Auto-implemented propery of the class has value " + autoProp);

            myProp = -10; // Will assign zero! Only accessible within the class.
            Console.WriteLine(myProp);    // Accessing the property.
        }

        public int myProp
        {
            get { return (field); }
            private set         // Note: The set or get accessors may be defined as private within a property!
            {
                if (value > 0)
                    field = value;
                else
                    field = 0;
            }
        }

        /* As pointed out earlier, auto-implemented properties have the property that the complier allocates a space to them.*/
        public int autoProp { get; private set; } // This is it! The get and set must have no body! 
    }

    
}
