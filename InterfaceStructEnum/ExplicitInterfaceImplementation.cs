/**
We can explicitly name the interface being implemented. this would allow us
to:

- Only make the method visible to the interface reference, and not the class reference.
- Implement methods that have the same name in two difference interfaces
*/

interface I1{
    int sameMethod();
}

interface I2{
    int sameMethod();
}

class Imp : I1, I2{
    int I1.sameMethod(){
        return 0;
    }

    int I2.sameMethod(){
        return 0;
    }

    public static void Assignment(){
        Imp imp1 = new Imp();

        // imp1.sameMethod(); This is impossible.
        I1 i1 = imp1;
        i1.sameMethod();    // Now it's possible.
    }
}