int february = 2;
Console.WriteLine(february);

february +=(int)0.5;
Console.WriteLine(february);

february +=(int)0.5;
Console.WriteLine(february);

/*
printed:
2
2
2

The cast runs first, on the literal alone. (int)0.5 evaluates to 0. So the line is really february += 0.
*/
