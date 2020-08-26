/**
Methods in interface are implicitly abstract, hence no implementation in the interface is allowed.

In an interface, methods are implicitly public, and no explicit access specifier is allowed

In addition to methods, interfaces can specify properties, indexers, and events.

*/

public interface InterfaceTest{
    /** Is this property interpreted as auto? Although the declaration of a property 
    in an interface looks similar to how an autoimplemented property is declared in a class, 
    the two are not the same. The interface declaration does not cause the property to be auto-implemented.
    It only specifies the name and type of the property
    */
    int Prop{
        get;
        set;
    }

    double this[int index]{
        get;
        set;
    }
}