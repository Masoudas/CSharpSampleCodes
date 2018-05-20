using System;

namespace IndexersAndProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            // First example
            Indexers indexers1 = new Indexers(2);
            Console.WriteLine(indexers1[1]);

            Indexers indexers2 = new Indexers(6);
            Console.WriteLine(indexers2[5]);

            // Now that we have indexers, we can define an array of a particular object.
            Indexers[] indexed = new Indexers[2];   // So long as an indexer has not been defined, you cannot create this array!
            indexed[0] = indexers1;
            indexed[1] = indexers2;
            indexed[1].printStatement();    // We can easily access the content of that element.

            foreach (Indexers index in indexed)
            {
                Console.WriteLine(index[1]);
            }

            // A second example, an indexer with no actuall array. every index returns the power of two of that index.
            IndexerWithNoArray[] indexerWithNo = new IndexerWithNoArray[15];
            for (int i = 0; i < indexerWithNo.Length; i++)
            {
                indexerWithNo[i] = new IndexerWithNoArray();
                Console.WriteLine(indexerWithNo[i][i]); // This is actually how we call the indexer from within an array.
            }
            
            

            // Third, creating a session from a number of trials.
            Trial[] session = new Trial[5];
            for (int i = 0; i < session.Length; i++)
            {
                session[i] = new Trial();
                session[i].action1();
            }
            


            Console.ReadKey();
        }
    }
}
