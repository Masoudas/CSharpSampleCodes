using System;
using System.Collections.Generic;
using System.Text;

namespace IndexersAndProperties
{
    class Indexers
    {
        /* Indexers provide the mechanism by which an object can be indexed like an array 
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


   
}
