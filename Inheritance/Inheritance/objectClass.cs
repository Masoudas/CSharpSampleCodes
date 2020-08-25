/**
C# defines one special class called object that is an implicit base class of all other classes and
for all other types (including the value types).

A few of these methods warrant some additional explanation. By default, the Equals(object)
method determines if the invoking object refers to the same object as the one referred to by 
the argument. (That is, it determines if the two references are the same.)

The GetHashCode( ) method returns a hash code associated with the invoking object. A
hash code is needed by any algorithm that employs hashing as a means of accessing stored
objects. It is important to understand that the default implementation of GetHashCode( )
will not be adequate for all uses.

As mentioned in Chapter 9, if you overload the = = operator, then you will usually need
to override Equals(object) and GetHashCode( ) because most of the time you will want
the = = operator and the Equals(object) methods to function the same. When Equals( )
is overridden, you often need to override GetHashCode( ), so that the two methods are
compatible.

*/