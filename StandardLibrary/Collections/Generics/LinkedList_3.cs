/**
A linked list as we know has nodes, hence immersion and removal is very easy, and
we can traverse forward and backward.

The LinkedList<T> class implements a generic doubly linked list. It implements
ICollection, ICollection<T>, IEnumerable, IEnumerable<T>, ISerializable, and
IDeserializationCallback. (The last two interfaces support the serialization of the list.)

Like most linked list implementations, LinkedList<T> encapsulates the values stored in
the list in nodes that contain links to the previous and next element in the list. These nodes
are objects of type LinkedListNode<T>. LinkedListNode<T> provides the four properties shown here:

public LinkedListNode<T> Next { get; }
public LinkedListNode<T> Previous { get; }
public LinkedList<T> List { get; }
public T Value { get; set; }

Next and Previous obtain a reference to the next or previous node in the list, respectively.
You can use these properties to traverse the list in either direction. A null reference is
returned if no next or previous node exists. You can obtain a reference to the list itself via
List. You can get or set the value within a node by using Value.


*/

class GenLinkedListDemo {
  static void Main() {
    // Create a linked list.
    LinkedList<char> ll = new LinkedList<char>();
    Console.WriteLine("Initial number of elements: " +
                       ll.Count);
    Console.WriteLine();
    Console.WriteLine("Adding 5 elements.");
    // Add elements to the linked list
    ll.AddFirst('A');
    ll.AddFirst('B');
    ll.AddFirst('C');
    ll.AddFirst('D');
    ll.AddFirst('E');
    Console.WriteLine("Number of elements: " +
                       ll.Count);
    // Display the linked list by manually walking
    // through the list.
    LinkedListNode<char> node;
    for(node = ll.First; node != null; node = node.Next)
      Console.Write(node.Value + " ");
    Console.WriteLine("\n");

        //Display the linked list by use of a foreach loop.
    Console.Write("Display contents with foreach loop: ");
    foreach(char ch in ll)
      Console.Write(ch + " ");
    Console.WriteLine("\n");
    // Display the list backward by manually walking
    // from last to first.
    Console.Write("Follow links backwards: ");
      for(node = ll.Last; node != null; node = node.Previous)
      Console.Write(node.Value + " ");
  }
}