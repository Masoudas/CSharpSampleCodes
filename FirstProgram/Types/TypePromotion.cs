class TypePromotion
{
    public static void rules(){
        short short_1 = 10;
        ulong u_long = 10ul;

        // ulong u_long_sum = u_long + short_1; This results in an error, because one type is signed.

        uint uint_1 = 10;
        sbyte sbyte_1 = 20;

        // One of the only weird(ish) promotions
        long long_promotion = uint_1 + sbyte_1;

        char ch1 = 'X';
        ch1 = (char)(ch1 + 1);  // Note that promotion occurs even in the case of integers.
    }
    
}