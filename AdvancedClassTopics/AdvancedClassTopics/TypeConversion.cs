using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedClassTopics
{
    class ExplicitTypeConversion
    {
        /* Ok Wow! C# provides the possiblity two convert types in the explicit manner that one desires.
           For example, here we convert the 4D points to the 3D points we have already defined.
           If the conversion operator specifies implicit, then the conversion is invoked automatically,
           such as when an object is used in an expression with the target type. When the conversion
           operator specifies explicit, the conversion is invoked when a cast is used. You cannot define
           both an implicit and explicit conversion operator for the same target and source types*/

        public int x;
        public int y;
        public int z;
        public int w;

        public ExplicitTypeConversion() { x = y = z = 0; w = 0; }
        public ExplicitTypeConversion(int i, int j, int k, int l) { x = i; y = j; z = k; w = l; }

        public static explicit operator UnaryBinaryOperatorOverloading(ExplicitTypeConversion op1)
        {
            UnaryBinaryOperatorOverloading result = new UnaryBinaryOperatorOverloading();
            result.x = op1.x;
            result.y = op1.y;
            result.z = op1.z;
            return result;
        }
    }

    class ImplicitTypeConversion
    {
        public int x;
        public int y;
        public int z;
        public int w;

        public ImplicitTypeConversion() { x = y = z = 0; w = 0; }
        public ImplicitTypeConversion(int i, int j, int k, int l) { x = i; y = j; z = k; w = l; }

        public static implicit operator UnaryBinaryOperatorOverloading(ImplicitTypeConversion op1)
        {
            UnaryBinaryOperatorOverloading result = new UnaryBinaryOperatorOverloading();
            result.x = op1.x;
            result.y = op1.y;
            result.z = op1.z;
            return result;
        }
    }
}
