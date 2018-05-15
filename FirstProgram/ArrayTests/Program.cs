using System;
using ArrayTests;

namespace MainModule
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstExample firstExample = new FirstExample(5);
            NDArray nDArray = new NDArray();
            JaggedArrays jaggedArrays = new JaggedArrays();
            DifferentArrays differentArrays = new DifferentArrays();

            int[] array = { 1, 2, 3 };
            ImplicitTypeArrays implicitType = new ImplicitTypeArrays(3,array);

            Console.ReadKey();
        }
    }
}
