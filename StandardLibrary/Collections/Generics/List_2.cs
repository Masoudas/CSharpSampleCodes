/**
The List<T> class implements a generic dynamic array and is conceptually similar to the
non-generic ArrayList class. List<T> implements the ICollection, ICollection<T>, IList,
IList<T>, IEnumerable, and IEnumerable<T> interfaces. 

AddRange(IEnumerable<T> collection) adds the collection to the  end of list.

BinarySearch(T item) looks for item. The list has to be sorted.

public void Sort(IComparer<T> comparer) Sorts the collection using the specified comparison object. If 
comparer is null, the default comparer for each object is used.

public void Sort(Comparison<T> comparison) Sorts the collection using the specified comparison delegate. 

As we know, a list can be traveresed in only one direction.
*/

using System;
using System.Collections.Generic;

class GenListDemo {
  static void Example1() {
      List<char> list = new List<char>();
      list.Add('a');
      list.Add('b');

      Console.WriteLine("Number of elements: " +
                       lst.Count);

      // Display the list using array indexing.
      Console.Write("Current contents: ");
      for(int i=0; i < lst.Count; i++)
        Console.Write(lst[i] + " ");
      Console.WriteLine("\n");

      list.Remove('a'); // Now the first element would be 'b'
      lst[0] = 'X';
  }
}