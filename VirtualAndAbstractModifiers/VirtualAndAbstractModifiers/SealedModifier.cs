using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualAndAbstractAndSealedModifiers
{
    // The sealed modifier prevents a class from being inherited.
    sealed class SealedClass
    {
        public int val;
        public void action() { }
    }

    /* Creating the following class is impossible!
    class InheringSealed : SealedClass
    {

    }
    */

    // The sealed modifier can also be used to prevent a virtual method from being overwritten!
    class VirtualMethodClass
    {
        public virtual void action1() { }
    }

    class SealVirtualMethod : VirtualMethodClass
    {
        public sealed override void action1() { }
    }

    class NoAccessToSealedMEthod: SealVirtualMethod
    {
        // The following line results in an error, because the method is sealed.
       // public override void action1() { }
    }
}
