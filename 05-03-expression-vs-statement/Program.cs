// See https://aka.ms/new-console-template for more information

byte test = 255;
Console.WriteLine(test);

test++;
Console.WriteLine(test);
/*
What you found:

The integer types: sbyte, byte, short, ushort, int, uint, long, ulong, plus nint/nuint which Aslak said to avoid.
You picked byte, max 255.
byte b = 256; gave CS0031, a type error from the type checker. Not overflow. The compiler evaluated the constant, compared it to byte's range, and refused before running anything.
To hit real overflow you needed a value the compiler can't compute ahead of time. Setting a byte to 255 and incrementing with ++ did it: you got 255 then 0. The counter wrapped.

The point: the compiler only protects you when it can determine the value statically. Runtime overflow is silent.
*/
