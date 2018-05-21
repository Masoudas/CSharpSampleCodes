using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# is good, but I am confused!");
            SecondExample secondExample = new SecondExample();

            CircleArea circleArea = new CircleArea(Math.PI);
            ForCounter forCounter = new ForCounter();

            // A demonstration of passing by reference. circleArea is sent to the factory, where its radius is changed. Now coming out of the factory, this object keeps the changed value.
            CircleAreaFactory circle = new CircleAreaFactory(circleArea, 12);
            circleArea.ComputeArea();

            if (!false)
                Console.WriteLine("Don't forget that the logical not is exclaimation mark!");

            byte andedvar = (~0x00) & (0x0F) | (0x08);   // So don't forget that this is the bitwise and
            Console.WriteLine(andedvar);

            Console.ReadKey();
        }
    }

    public class SecondExample
    {
        int x = 123121212;
        decimal y = 10.58034343480933800M;    // The M must be put at the end to indicate that this literal is a decimal, because decimals are by default doubles!
        long z;
        short w;

        public SecondExample()
        {
            // x = (int)z;  // Smaller to larger always requires type casting.
            z = x;  // The smaller value can always be assigned to the larger one
            w = (short) x;  // Type casting has occured. The least significant bits are exactly copied, result may be confusing.
            Console.WriteLine("x is " + x + " and y is "+ y);
            Console.WriteLine("x is {0} and y is {1}", x, y);
            Console.WriteLine(w);   // w would be the lowest bits of x.

            z = 1222222222;
            //x = z * x;    This does not work, because long times int is promoted to int, hence, cannot be stored in an int.
            z = x * z;
            y = y * z;  // z is promoted to long.
            // w = w * w;  Cannot happen because the result of every operation is at least int, even for the char type.
            z = w * w; // Implicit type conversion from int to long!
            w--;    // w is first promoted to int, then returned back to byte.
        }

    }

    public class CircleArea
    {
        public double radius;
        public  CircleArea(double radius)
        {
            this.radius = radius;
            ComputeArea();
        }

        public void ComputeArea()
        {
            Console.WriteLine("Area is " + (decimal)(Math.Pow(radius, 2) * Math.PI) + " for radius " + radius);
        }
    }

    public class ForCounter
    {
        public ForCounter()
        {
            for (int counter = 0; counter < 5; counter++)
            {
                if (0!=1 | false)   // Just don't forget the not sign!
                {
                    Console.WriteLine("{0}\t{1}\t{2}", counter, counter * counter, counter * counter * counter);
                }
            }
        }
    }

    public class CircleAreaFactory  // A factory class
    {
        public CircleAreaFactory(CircleArea circleArea, double radius)
        {
            circleArea.radius = radius;
            circleArea.ComputeArea();
        }

    }
}

