/**
An enumeration is a set of named integer constants, as opposed to Java, where
they are full-fledged classes. The keyword enum declares an
enumerated type. The general form for an enumeration is
enum name { enumeration list };

A key point to understand about an enumeration is that each of the symbols stands for
an integer value. However, no implicit conversions are defined between an enum type and
the built-in integer types, so an explicit cast must be used. Also, a cast is required when
converting between two enumeration types. Since enumerations represent integer values,

Apparently, it is possible to cycle through an enumeration with a for loop, but  seriously
don't do it!!!

You can specify the value of one or more of the symbols by using an initializer. Do this by 
following the symbol with an equal sign and an integer constant expression

By default, enumerations are based on type int, but you can create an enumeration of any
integral type, except for type char. 

enum Apple : byte { Jonathan, GoldenDel, RedDel, Winesap,
                    Cortland, McIntosh };
*/

class EnumDemo {
  enum Apple { Jonathan, GoldenDel, RedDel, Winesap,
               Cortland, McIntosh };
    static void Main() {
        Apple i; // declare an enum variable
    // Use i to cycle through the enum.
    for(i = Apple.Jonathan; i <= Apple.McIntosh; i++)
      Console.WriteLine(i + " has value of " + (int)i)
    }
}