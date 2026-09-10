Console.WriteLine("Hello, World!");

int i = 42;
long l = 56;
float f = 3.14159F;
double d = 3.14159 * 10;
Console.WriteLine("i = {0} \nl = {1,4} \nf = {2} \nd = {3,6:0.0000}", i, l, f, d);
Console.WriteLine("{1} then {0}", i, l);

/*

{0} {1} {2} {3} — which value from the list, counting from zero
\n — newline, an escape sequence, same backslash mechanism as \"
{1,4} — value 1 (l), padded to 4 characters wide, right-aligned.
That's the spaces before 56. {3,6:0.00} — value 3 (d), 6 characters
wide, formatted to two decimals. That's why 31.4159 printed as 31.42.
{0} and {2} have no comma or colon, so no padding, default formatting

Padding to a fixed width lines numbers up in columns. Format specifiers
stop you printing 31.415900000000001 when two decimals will do. Both matter
the moment you print more than one row of anything.

*/
