using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedClassTopics
{
    class UnaryBinaryOperatorOverloading
    {
        public int x;
        public int y;
        public int z;

        public UnaryBinaryOperatorOverloading() { x = y = z = 0; }
        public UnaryBinaryOperatorOverloading(int i, int j, int k) { x = i; y = j; z = k; }

        // Overload binary +.
        // Pay attention to the fact the method is static. And that it takes two objects op1 and op2. Had it taken one, it would have been a uniray
        // operator, which is useful for defining -op1, as shown below.
        public static UnaryBinaryOperatorOverloading operator +(UnaryBinaryOperatorOverloading op1, UnaryBinaryOperatorOverloading op2)
        {

            UnaryBinaryOperatorOverloading result = new UnaryBinaryOperatorOverloading();

            /* This adds together the coordinates of the two points
               and returns the result. */
            result.x = op1.x + op2.x; // These are integer additions
            result.y = op1.y + op2.y; // and the + retains its original
            result.z = op1.z + op2.z; // meaning relative to them.
            return result;
        }

        // Overload unary.
        public static UnaryBinaryOperatorOverloading operator -(UnaryBinaryOperatorOverloading op1)
        {

            UnaryBinaryOperatorOverloading result = new UnaryBinaryOperatorOverloading();

            /* Note that the result is a new object, meaning we cannot write op1.x = -op1.x, which is quite important. */
            result.x = -op1.x; // These are integer additions
            result.y = -op1.y; // and the + retains its original
            result.z = -op1.z; // meaning relative to them.
            return result;
        }

        // Overload binary, but with an integer. That way, we can add an integer to the entire object.
        public static UnaryBinaryOperatorOverloading operator +(UnaryBinaryOperatorOverloading op1, int shift)
        {

            UnaryBinaryOperatorOverloading result = new UnaryBinaryOperatorOverloading();

            result.x = op1.x - shift; // These are integer additions
            result.y = op1.y - shift; // and the + retains its original
            result.z = op1.z - shift; // meaning relative to them.
            return result;
        }

        // Another unary operator overloaded, ++;
        public static UnaryBinaryOperatorOverloading operator ++(UnaryBinaryOperatorOverloading op1)
        {

            UnaryBinaryOperatorOverloading result = new UnaryBinaryOperatorOverloading();

            result.x = ++op1.x; // These are integer additions
            result.y = ++op1.y; // and the + retains its original
            result.z = ++op1.z; // meaning relative to them.
            return result;
        }

        /* We can even override the true/false booleans, just remember that both must be overloaded! */

        public static bool operator false(UnaryBinaryOperatorOverloading op1)
        {

            if (op1.x == 0 && op1.y == 0 && op1.z == 0) // These are integer additions
                return (false);
            else    // It is important to return true as well!
                return (true);
        }

        public static bool operator true(UnaryBinaryOperatorOverloading op1)
        {

            if (op1.x != 0 || op1.y == 0 || op1.z == 0) // These are integer additions
                return (true);
            else
                return (false);
        }

        // Interestingly enough, you can override | and & operators as well. Note however to override && and ||, we must 4 things, which
        public static UnaryBinaryOperatorOverloading operator |(UnaryBinaryOperatorOverloading op1, UnaryBinaryOperatorOverloading op2)
        {
            UnaryBinaryOperatorOverloading result = new UnaryBinaryOperatorOverloading();
            result.x = op1.x + op2.x;
            result.y = op1.y + op2.y;
            result.z = op1.z + op2.z;

            return (result);
        }
    }
}
