using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    // At its core, the term generics means parameterized types.
    class Gen<T,V>    // So "T" is the generic object that is used in this example!
    {
        T obj;
        V obj1;
        T[] obj2; // You can define as many generics as you desire even in the form of an array!

        public Gen(T obj, V obj1)
        {
            this.obj = obj;
            this.obj1 = obj1;
        }

        public T getOb()
        {
            return(obj);
        }

        // Show type of T.
        public void ShowTypes()
        {
            Console.WriteLine("Type of T is " + typeof(T));
            Console.WriteLine("Type of U is " + typeof(V));
        }
    }
}
