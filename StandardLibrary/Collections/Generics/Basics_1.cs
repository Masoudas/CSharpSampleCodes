
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

IEnumerable<T> declares the GetEnumerator( ) method as shown here:
IEnumerator<T> GetEnumerator( ). It returns an enumerator of type T for the collection. 
Thus, it returns a type-safe enumerator. IEnumerator<T> has the same two methods as does 
the non-generic IEnumerator: MoveNext( ) and Reset( ). 
It also declares a generic version of the Current property, as shown here:
T Current { get; } It returns a T reference to the next object. Thus, the generic version of Current is type-safe

The IComparer<T> interface is the generic version of IComparer described earlier. The
main difference between the two is that IComparer<T> is type-safe, declaring the generic
version of Compare( ) shown here:
int Compare(T x, T y)
This method compares x with y and returns greater than zero if x is greater than y, zero if
the two objects are the same, and less than zero if x is less that y.

The IEqualityComparer<T> interface is the equivalent of its non-generic relative 
IEqualityComparer. It defines these two methods:
bool Equals(T x, T y)
int GetHashCode(T obj)
Equals( ) must return true if x and y are equal. GetHashCode( ) must return the hash code
for obj. If two objects compare as equal, then their hash codes must also be the same.

The KeyValuePair<TKey, TValue> Structure: 
System.Collections.Generic defines a structure called KeyValuePair<TKey, TValue>,
which is used to store a key and its value. It is used by the generic collection classes that
store key/value pairs, such as Dictionary<TKey, TValue>. This structure defines the
following two properties:
    public TKey Key { get; };
    public TValue Value { get; };
These properties hold the key or value associated with an entry. You can construct a
KeyValuePair<TKey, TValue> object by using the following constructor:
    public KeyValuePair(TKey key, TValue value)

*/