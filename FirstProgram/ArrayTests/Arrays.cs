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

            for (int i = 0; i < array2.Length; i++) // One thing, don't forget that i is updated AFTER each iteration of the loop.
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

            // Reverse array
            
        }

        void ChangeArray(int[] array)
        {
            array[1] = 10;
        }
    }

    class NDArray
    {
        int[,] array = new int[4, 5];
        int[,,] array3d = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } }; //[3rd:dim 0,row:dim 1,column:dim 2]!
        int[,,,] array4d = new int[5, 2, 2, 3] ; //[4rd:dim 0, 3rd:dim 1,row:dim 2,column:dim 4]!

        public NDArray()
        {
            for (int i = 0; i < array3d.GetLength(0); i++)  //3rd dimension
            {
                for (int j = 0; j < array3d.GetLength(1); j++)  // Row dimension
                {
                    Console.WriteLine(array3d[i, j, 0]+"\t"+ array3d[i, j, 1]+"\t" + array3d[i, j, 2]);

                }

            }

            Console.WriteLine(array4d.GetLength(3));    // Will show 3!
            Console.WriteLine(array4d.GetLength(0));    // Will show 5!
        }
    }

    class JaggedArrays
    {
        int[][] jaggedarray = new int[2][];     // So this is a jagged array. Can only hold integers. Number of rows may be different.
        
        public JaggedArrays()
        {
            jaggedarray[0] = new int[3] { 0, 1, 2 };
            jaggedarray[1] = new int[4] { 3, 4, 5, 6 };

            Console.WriteLine(jaggedarray[0][2] + jaggedarray[1][3]);
            Console.WriteLine(jaggedarray.GetLength(0));    // This length return 2;

            int[] subarray = jaggedarray[0];
            Console.WriteLine(subarray[2]);

            // Still refereing to the same object.
            subarray[2] = 10;
            Console.WriteLine(jaggedarray[0][2]);

            // Make a new copy.
            int[] subarray2 = new int[3];
            jaggedarray[0].CopyTo(subarray2, 0);    // Note that jaggedarray[0] is still an object here!
            subarray2[2] = 20;
            Console.WriteLine(jaggedarray[0][2]);

        }
    }

    class DifferentArrays
    {
        Array myArray = Array.CreateInstance( typeof(String), 9 );  // Array is a linked list indeed. See https://msdn.microsoft.com/en-us/library/system.array(v=vs.110).aspx
        object[] array = new object[3] { "Jack", 2, 3 };    // So, if anyone is ever interested in something this stupid, here it is!
        
        public DifferentArrays()
        {
            myArray.SetValue("The", 0);
            myArray.SetValue("quick", 1);
            myArray.SetValue("brown", 2);
            myArray.SetValue("fox", 3);
            myArray.SetValue("jumps", 4);
            myArray.SetValue("over", 5);
            myArray.SetValue("the", 6);
            myArray.SetValue("lazy", 7);
            myArray.SetValue("dog", 8);

            Array.Reverse(myArray);

            // Displays the values of the Array with some self written functions.
            Console.WriteLine("array initially contains the following values:");
            PrintIndexAndValues(array);
            Console.WriteLine();

            Console.WriteLine("myarray contains the following values:");
            PrintIndexAndValues(myArray);
            Console.WriteLine();

            //Sort then print
            Array.Sort(myArray);
            Console.WriteLine("Sorted array:");
            PrintIndexAndValues(myArray);

        }

        public void PrintIndexAndValues(Array myArray)  
        {
            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
                Console.WriteLine("\t[{0}]:\t{1}", i, myArray.GetValue(i));
        }

        public void PrintIndexAndValues(object[] myArray)
        {
            for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
                Console.WriteLine("\t[{0}]:\t{1}", i, myArray.GetValue(i));
        }
    }

    class ImplicitTypeArrays
    {
       public ImplicitTypeArrays(int len,int[] array)
       {
            var implicitArray = array;  // Implicit type is useful in LINQ stuff.
            var jagged = new[] {
                new[] { 1, 2, 3, 4 },
                new[] { 9, 8, 7 },
                new[] { 11, 12, 13, 14, 15 }
            };
        }
    }

    
}
