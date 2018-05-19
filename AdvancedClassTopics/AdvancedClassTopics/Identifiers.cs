using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedClassTopics
{
    class RefAndOur
    {
        // This method changes its argument. Notice the use of ref.
        public void Sqr(ref int i)
        {
            i = i * i;
        }

        public int GetParts(double n, out double frac)  // The output parameter is created within the method. 
        {
            int whole;
            whole = (int)n;
            frac = n - whole; // pass fractional part back through frac
            return whole; // return integer portion
        }
    }

    class RefToRef
    {
        public int member;

        public RefToRef(int member)
        {
            this.member = member;
        }

        public void SwapCreate(ref RefToRef first, ref RefToRef second, out RefToRef third)
        {
            RefToRef fourth;
            fourth = first;
            first = second;
            second = fourth;

            third = new RefToRef(10);
        }

    }

    class VariableFunctionIput
    {
        public VariableFunctionIput(char ch, params int[] inputs)  // inputs would be an array that can store as many inputs as we desire. There can be one and only one param type.
                                                                // See use case in main. params must be the last input.
        {
            for (int i = 0; i < inputs.Length; i++)
            {
                Console.WriteLine(inputs[i]);
            }
        }
    }

    class CoversionInOverloading    // Point: There may be conversions when overloading.
    {
        public CoversionInOverloading()
        {
            int i = 10;
            double d = 10e-100;

            byte b = 99;
            long s = 123;// (long)(Math.Pow(10,32));
            float f = 11.5F;

            MyMeth(i); // calls ob.MyMeth(int)
            MyMeth(d); // calls ob.MyMeth(double)
            MyMeth(b); // calls ob.MyMeth(int) -- type conversion
            MyMeth(s); // calls ob.MyMeth(double) -- Very interesting that this goes inside the double method! It makes sense though, becuase int cannot hold on to a long. 
                       // Moreover, C# must send the entire data inside to function and not trim it! So it makes sense that it converts longs to double.
            MyMeth(f); // calls ob.MyMeth(double) -- type conversion
        }

        public void MyMeth(int x)
        {
            Console.WriteLine("Inside MyMeth(int): " + x);
        }
        public void MyMeth(double x)
        {
            Console.WriteLine("Inside MyMeth(double): " + x);
        }


    }

    class ConstructorOverloading
    {
        // Look at this very interesting example. We call a default constucture, which defaults the constructor in a very interesting way.
        // This is vey brilliant. Note that you can't call a constructor inside of a constructor.
        public int x, y;
        public ConstructorOverloading() : this(0, 0)
        {
            Console.WriteLine("Inside XYCoord()");
        }

        public ConstructorOverloading(ConstructorOverloading obj) : this(obj.x, obj.y)
        {
            Console.WriteLine("Inside XYCoord(obj)");
        }

        public ConstructorOverloading(int i, int j = 5)
        {
            Console.WriteLine("Inside XYCoord(int, int)");
            x = i;
            y = j;
        }

    }
}


