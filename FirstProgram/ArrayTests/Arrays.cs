using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayTests
{
    class FirstExample
    {
        int[] array = new int[10];  //int[] denotes the type of the variable (an array of integers). The int[10] of course instantiates an object with this type.
                                    // Note that array is the reference to this object. We still pass it as reference around.
        double[] array2;

        int[] array3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        public FirstExample(int length)
        {
            array2 = new double[length];

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = Math.Sinh(i);
            }

            foreach (double item in array2)
            {
                Console.WriteLine(item);
            }

            // Test to see arrays are passed by reference.
            int[] array4 = { 1, 2 };
            ChangeArray(array4);
            Console.WriteLine(array4[1]);
        }

        void ChangeArray(int[] array)
        {
            array[1] = 10;
        }
    }
}
