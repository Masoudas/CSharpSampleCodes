/**

Question is, what happens if a value type (like int, etc) is not initialized?
What about reference types?

So, there's a distinction here between classes and local variables for example. If a

LOCAL VARIABLE CASE:
Value types?
They are left uninitialized. The compiler throws an error if faces such a situation.

Reference types?
If compiler faces an uninitialized reference types, it throws an error (it does not set
references to null).


REFERENCE TYPES:
value types?
They are initialized to their default values.

reference types?
They are initialized to null.


----------------------------------------------------------------------------------------
What are the initial values of different types? 
(see https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/default-values)

For reference types, the initial value is null.

For integer types (excluding char), zero.
For floating-point types, it is set to zero.
For bool type, it's false.
For char type, it's '\0' (U 0000)

For enum, (E)0 is the initial value.

For structures, the initial value is set by defining all value types to their
initial values and all reference types to null.


*/

