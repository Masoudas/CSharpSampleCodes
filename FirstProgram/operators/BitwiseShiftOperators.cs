/**
The shift operators better be used with unsigned types.

With signed types, whatever the sign bit is, when shifting to right, it is copied in the original place.
For example, 0b10000001 is a negative number. One right shift causes it to be 0b11000000.
A left shift however works the same as integers. Hence a left shift in the previous results in 0b00000010.
*/