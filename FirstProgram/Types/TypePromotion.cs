class TypePromotion
{
    public static void rules(){
        short short_1 = 10;
        ulong u_long = 10ul;

        // ulong u_long_sum = u_long + short_1; This results in an error, because one type is signed.

    }
    
}