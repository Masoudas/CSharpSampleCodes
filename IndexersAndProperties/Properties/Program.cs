using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // First example of properties
            PropertyClass propertyClass = new PropertyClass(10);
            Console.WriteLine(propertyClass.myProp);    // Accessing the property.

            Console.ReadKey();
        }
    }
}
