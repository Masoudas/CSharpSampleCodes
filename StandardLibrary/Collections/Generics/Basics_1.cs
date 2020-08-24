
/**
 The generic collections are declared in the System.Collections.Generic namespace
 
 ICollection<T> is the basic interface. it has count and IsReadOnly property. It has
 void add(), void clear(), void coptTo(T[] arr, int arrIndex), remove()

 The IList<T> interface defines the behavior of a generic collection that allows elements
to be accessed via a zero-based index. It has several methods. Two of these methods imply the modification of 
a collection. If the collection is read-only or of fixed size, then the Insert( ) and RemoveAt( )
methods will throw a NotSupportedException.

List<T> defines the following indexer: T this[int index] { get; set; }.
This indexer sets or gets the value of the element at the index specified by index.

The IDictionary<TKey, TValue> interface defines the behavior of a generic collection that
maps unique keys to values. That is, it defines a collection that stores key/value pairs.

IDictionary<TKey, TValue> defines the following indexer: TValue this[TKey key] { get; set; }
*/