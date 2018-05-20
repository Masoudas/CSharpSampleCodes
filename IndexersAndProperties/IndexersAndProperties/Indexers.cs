using System;
using System.Collections.Generic;
using System.Text;

namespace IndexersAndProperties
{
    class Indexers
    {
        /* Indexers provide the mechanism by which an object can be indexed like an array */
        /* Here's the point: Suppose you want to create an array of a particular object, like Obj. So long as you have not defined indexers,
         * you cannot say Obj[] obj = new Obj[5]. The part on the right would result in an error. This is the reason why we need indexers.
           Clearly, we cannot have more than one indexer for a class*/

        double[] array;    // This array is defined private!

        public Indexers(int size)
        {
            array = new double[size];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Cosh(i);
            } 
        }

        public double this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                    return (array[index]);
                else
                    return (-1);
            }
            set
            {
                if (index >= 0 && index < array.Length)
                    array[index] = value;   // This value is a predefined thing!
            }
        }

        // Indexers can be overloaded, of course not in such a stupid manner, but anyhow they can be!
        public double this[int index1, int index2]   
        {
            get
            {
                if (index1 >= 0 && index1 < array.Length)
                    return (array[index2]);
                else
                    return (-1);
            }
            set
            {
                if (index1 >= 0 && index1 < array.Length)
                    array[index2] = value;   // This value is a predefined thing!
            }
        }

        public void printStatement()
        {
            Console.WriteLine("La La La something and noodles in strings");
        }

    }

    class IndexerWithNoArray
    {
        public int this[int index]
        {
            // Compute and return power of 2.
            get
            {
                if ((index >= 0) && (index < 16)) return pwr(index);
                else return -1;
            }
            // There is no set accessor.
        }

        int pwr(int p)
        {
            int result = 1;
            for (int i = 0; i < p; i++)
                result *= 2;
            return result;
        }


    }

    class Trial
    {
        // A class with absolutely nothing, but only get and sets!
        public int this[int index]
        {
            set { }    // This is kind of weird, you have to admitted.
        }

        public void action1()
        {
            Console.WriteLine("Action 1 is done");
        }

        public void action2()
        {
            Console.WriteLine("Action 2 is done");
        }

        public void action3()
        {
            Console.WriteLine("Action 3 is done");
        }
    }


    class PropertyClass
    {
        /* Most important point: a property is like a method. Hence, it does not define a storage space in the memory. Hence, I need to define a (private)
           field in the class. Otherwise, the property would be doing some action and allocates no space in the memory! The only exception is of course is the
           auto implemented properties! */
        int field;  // This is the private field that is going to be managed by properties.
                    // The property Myprop makes sure that it would always be positive.

        public int myProp
        {
            get { return (myProp); }
            set
            {
                if (value > 0)
                    field = value;
                else
                    field = 0;
            }
            
        }
    }
}
