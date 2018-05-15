using System;
using System.Collections.Generic;
using System.Text;

namespace StringTests
{
    class StringDefinition
    {
        string first = "I wrote this in the Donald Trump era";
        string str1;
        string[] strarray = new string[2];

        public StringDefinition()
        {
            char[] charray = { 'A', ' ', 's', 't', 'r', 'i', 'n', 'g', '.' };// Second way of defining arrays.
            str1 = new string(charray);

            Console.WriteLine(first);

            first = first + " all by myself";
            Console.WriteLine(first);

            strarray[0] = first;
            strarray[1] = first + ", alone";
            Console.WriteLine(strarray[0]);
            Console.WriteLine(strarray[1]);
        }
        

    }
}
