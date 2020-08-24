
/**
Question is, what happens to the methods when they are not overridden if they're assigned to
the base class reference? The answer is, the last override is implemented. Note however with an
actual reference of the derived object, the real last method (which is not overridden) is called.
*/
namespace Inheritance{
    class A{
        public static void Test(){
            A a = new C();
            a.m1(); // Calls the Base method.
            C c = (C)a;
            c.m1(); // Calls the second derived method.


        }

        public virtual void m1(){
            System.Console.WriteLine("Base method");
        }
    }

    class B : A{
        public override void m1(){
            System.Console.WriteLine("Derived method");
        }
    }

    class C : B{
        new public void m1(){
            System.Console.WriteLine("Second Derived method");
        }
    }

    
}