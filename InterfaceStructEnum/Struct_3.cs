/**
Structures are value types, though they inherit ValueType (which inherits object). They act like passing
a class in C++ without pointer. An actual copy of the structure is always passed.

Structures cannot inherit other structures or classes or be used as a base for other structures
or classes. (All structures do, however, implicitly inherit System.ValueType, which inherits
object.) However, a structure can implement one or more interfaces. These are specified after
the structure name using a comma-separated list. Like classes, structure members include
methods, fields, indexers, properties, operator methods, and events. Structures can also define
constructors, but not destructors. 

However, you cannot define a default (parameterless) constructor for a structure. The reason for this is that a default constructor is automatically
defined for all structures, and this default constructor can’t be changed. The default constructor
initializes the fields of a structure to their default value. 

Since structures do not support inheritance, structure members cannot be specified as abstract, virtual, or protected.
A structure object can be created using new in the same way as a class object, but it is
not required. When new is used, the specified constructor is called. When new is not used,
the object is still created, but it is not initialized. Thus, you will need to perform any
initialization manually.

In the following example, pay attention to how structs are constructed

Because structs are reference types, when you assign one struct variable to another, 
you are making a copy of the object on the right.
*/

using System;
// Define a structure.
struct Book {
  public string Author;
  public string Title;
  public int Copyright;
  public Book(string a, string t, int c) {
    Author = a;
    Title = t;
    Copyright = c;
  }
}

// Demonstrate Book structure.
class StructDemo {
  static void Main() {
    Book book1 = new Book("Herb Schildt",
                          "C# 4.0: The Complete Reference",
                          2010); // explicit constructor
    Book book2 = new Book(); // default constructor
    Book book3; // no constructor
    Console.WriteLine(book1.Title + " by " + book1.Author +
                      ", (c) " + book1.Copyright);
    Console.WriteLine();

    if(book2.Title == null)
      Console.WriteLine("book2.Title is null.");
    // Now, give book2 some info.
    book2.Title = "Brave New World";
    book2.Author = "Aldous Huxley";
    book2.Copyright = 1932;
    Console.Write("book2 now contains: ");
    Console.WriteLine(book2.Title + " by " + book2.Author +
                      ", (c) " + book2.Copyright);
    Console.WriteLine();
// Console.WriteLine(book3.Title); // error, must initialize first
    book3.Title = "Red Storm Rising";
    Console.WriteLine(book3.Title); // now OK
  }
}


// Copy a struct.
// Define a structure.
struct MyStruct {
  public int x;
}
// Demonstrate structure assignment.
class StructAssignment {
    static void Main() {
    MyStruct a;
    MyStruct b;
    a.x = 10;
    b.x = 20;

    Console.WriteLine("a.x {0}, b.x {1}", a.x, b.x);
    a = b;
    b.x = 30;
    Console.WriteLine("a.x {0}, b.x {1}", a.x, b.x);
  }
}