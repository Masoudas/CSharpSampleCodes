/**
As we know, all IO operations are based on stream. A stream is a set of bytes,
that can be read from or written to a device (console, file, ...)

At the lowest level, all C# I/O operates on bytes. This makes sense because many devices
are byte oriented when it comes to I/O operations

Console.Out refers to the standard output stream. By default, this is the
console. When you call Console.WriteLine( ), for example, it automatically sends information
to Console.Out. Console.In refers to standard input, which is, by default, the keyboard.
Console.Error refers to the standard error stream, which is also the console by default.
However, these streams can be redirected to any compatible I/O device. The standard
streams are character streams. Thus, these streams read and write characters.

Notice that Stream defines methods that read and write data. However, not all streams 
will support both of these operations, because it is possible to open read-only or write-only
streams. Also, not all streams will support position requests via Seek( ). To determine the
capabilities of a stream, you will use one or more of Stream’s properties.
Also shown are the Length and Position properties, which contain the length of
the stream and its current position.

*/

using System.IO;

class StreamBasics{
    public static void StreamMethods(){
        Stream stream;

        // stream.Flush();  Flushes the stream to be written.

        // stream.Close(); Closes the stream.

        // int ReadByte( ); Read next byte as int. Returns -1 if end of file.

        // int Read(byte[ ] buffer, int offset, int count);  Attempts to read up to count bytes into buffer starting at
                                                            // buffer[offset], returning the number of bytes successfully
                                                            // read. 

        // long Seek(long offset, SeekOrigin origin); // Sets the current position in the stream to the specified
                                                      // offset from the specified origin. It returns the new position.

        // int Write(byte[ ] buffer, int offset, int count); Writes a subrange of count bytes from the array buffer,
                                                     // beginning at buffer[offset], returning the number of bytes
                                                     // written.
    }

    public static void StreamProperties(){
        Stream stream;

        // stream.Length; Returns the length of the stream (is it the same as file length for example?)
        // stream.Position; Current position of the stream (is it the same as position in file for example?)
    }
}