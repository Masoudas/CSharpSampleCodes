using System;
/**
As we know, static variables and methods are augmented to derived class.
Question is, can they be redefined in C# (not overridden of course, because that's impossible)?
Well, yes.!-- However, things get messy.

For example, if you consider the example below, both Static methods are properly called from their 
class names. However, the call to static below calls the Base method in both classes, why? Because
it was not overridden.
*/
class Base
{
    public static void Main(){
        Base.Static_Method();   // Prints "Base static method"
        Derived.Static_Method(); // Prints "Derived static method"
        Base.Call_To_Static(); // Prints "Base static method"
        Derived.Call_To_Static();   // Again, Prints "Base static method". This is because call occurs inside base class.
    }
    public static void Static_Method(){
        Console.WriteLine("Base static method");
    }   
    
    public static void Call_To_Static(){
        Static_Method();
    }
}

class Derived : Base{
    public static void Static_Method(){
        Console.WriteLine("Derived static method");
    }   
}