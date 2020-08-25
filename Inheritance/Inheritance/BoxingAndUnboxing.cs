/**
When an object reference refers to a value type, a process known as boxing occurs. By object reference
we actually mean the object class here!

Unboxing is the process of retrieving a value from a boxed object. This action is performed
using an explicit cast from the object reference to its corresponding value type. 
*/

using System;

class BoxingAndUnboxing{
    public static void exampleWithObject(){
        object obj = 4;

        object obj_double = 4d;

        double dfromObj = (double)obj_double;
    }

    public static void callingMethodsOnLiterals(){
        System.Console.WriteLine(10.ToString());
    }

    public static void ClassEquivalentOfValueType(){
        Double d1 = 10d;

        Int16 sbyte_1 = -10;

        // For example, we can write this conditional?
        if (10 is Int32){
            System.Console.Write("True");
        }
    }
}