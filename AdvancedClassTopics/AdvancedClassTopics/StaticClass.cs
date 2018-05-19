using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedClassTopics
{
    static class StaticClass    // A class may be static. In such a case, all methods and fields will be forced to be static.                   
    {
        static int a;

        static StaticClass()
        {

        }

        static public void method1()
        {
            Console.WriteLine(5);
        }
    }

    class ClassWithStaticMembers
    {
        static public int a;  
        static public void method1()
        {
            Console.WriteLine(5);
        }
    }

    class StaticConstructor // Used for initializing parts of a class that are static.
    {
        public static int alpha;
        public int beta;

        // A static constructor.
        static StaticConstructor()
        {
            alpha = 99;
            Console.WriteLine("Inside static constructor.");
        }
        // An instance constructor.
        public StaticConstructor()
        {
            beta = 100;
            Console.WriteLine("Inside instance constructor.");
        }
    }
}
