/**
The query really means querry. Hence, we write querries to perform actions. This is
kind of different from the Stream library of Java.
*/

// We need to include Linq library to write querries.
using System.Linq;

class SimpleExample{
    // The "from n" part of the phrase is like querrying a row in a data base.
    public static void simpleQuerry(){
        int[] arr = {1,2,3,4,5};

        var querry = from n in arr
                     where n > 1
                     select n;
        
        foreach(int i in querry) System.Console.WriteLine("i");
    }

    // A querry can be reused, because it does not do anything in and of itself.
    public static void ReusingQuerry(){
        int[] arr = {1,2,3,4,5};

        var querry = from n in arr
                     where n > 1
                     select n;
        
        foreach(int i in querry) System.Console.WriteLine("i");

        // Reusing the querry with the same array.
        arr[0] = 0;
        foreach(int i in querry) System.Console.WriteLine("i");

    }
}