using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class TwoDShapa
    {
        /* Here's an important. Private fields are not inherited (See the triangle class below).
         * What we should do is, use the protected modifier. 
           What if we defined a public property that has access to the private field? */
         
        private double Width;   // This field would not be inherited.
        protected double length;    // A protected field is public within the hierarchy, but private on the outside.
        public double Height;

        public double myProp    // So this public property would be inherited. And now, we can have indirect access to the Width.
        {
            get { return(Width); }
            set { Width = value; }
        }
       
        public void ShowDim()
        {
            Console.WriteLine("Width and height are " + Width + " and " + Height);
        }

        protected void Action() // Methods can also be protected.
        {
            Console.WriteLine("This is a protected action.");
        }

        public void Action2()   // What if I define a method that uses a private field. Would it be inherited without a problem?
        {
            Console.WriteLine("This is a public method that uses the private field \"Width\" " + Width);
        }

    }

    class Trianglea: TwoDShapa
    {
        public Trianglea(double myProp, double length)
        {
            // this.width = 0   This would result in an error!
            this.myProp = myProp;    // No problem using a public propery that has access to a private field in the base class.
            this.length = length;
            Action();
            Action2();  // This raises the question of how can we initialize a field which we do not have access to?
                        // We can remedy this of course using properties, just that we must be careful!
        }


    }
}
