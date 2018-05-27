using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualAndAbstractAndSealedModifiers
{
    // So object is the basis class of all classes in C#.
    // Every object, even value types can be turned into classes (loosely speaking) using the object class.
    class BoxAndUnBox
    {

        public static int Sqrt(object o)    // If an integer is given to this funcion, it will box it as an object.
        {
            Console.WriteLine("Even 10 is an string: " + 10.ToString());
            return (int)o * (int)o; // This is called unboxing, which means extracting the integer hidden in the object!
        }

    }
}
