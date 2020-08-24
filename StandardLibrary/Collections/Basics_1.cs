/**
The .NET Framework supports five general types of collections: 
non-generic, specializedbit-based, generic, and concurrent. 

The non-generic collections implement several fundamental collections. Non-generics are in
System.Collections 

The specialized collections operate on a specific type of data or operate in a unique
way. For example, there are specialized collections for strings. There are also specialized 
collections that use a singly linked list. The specialized collections are declared in 
System.Collections.Specialized.

The generic collections provide generic implementations of several standard data
structures, such as linked lists, stacks, queues, and dictionaries. Because these collections
are generic, they are type-safe. This means that only items that are type-compatible with the
type of the collection can be stored in a generic collection, thus eliminating accidental type
mismatches. Generic collections are declared in System.Collections.Generic.

Fundamental to all collections is the concept of an enumerator, which is supported
by the non-generic interfaces IEnumerator and IEnumerable, and the generic interfaces
IEnumerator<T> and IEnumerable<T>. An enumerator provides a standardized way of
accessing the elements within a collection, one at a time. Thus, it enumerates the contents of a
collection. Because each collection must implement either a generic or non-generic form of
IEnumerable, the elements of any collection class can be accessed through the methods
defined by IEnumerator or IEnumerator<T>. Therefore, with only small changes, the code
that cycles through one type of collection can be used to cycle through another. As a point of
interest, the foreach loop uses the enumerator to cycle through the contents of a collection.

*/