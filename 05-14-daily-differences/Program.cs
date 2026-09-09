
double monday = 21.5;
double tuesday = 23.7;
double wednesday = 19.6;
double thursday = 22.5;
double friday = 25.3;
double saturday = 21.7;
double sunday = 18.9;

Console.WriteLine("");
Console.WriteLine(tuesday - monday);
Console.WriteLine(wednesday - tuesday);
Console.WriteLine(thursday - wednesday);
Console.WriteLine(friday - thursday);
Console.WriteLine(saturday - friday);
Console.WriteLine(sunday - saturday);
Console.WriteLine("");

/*
21.5 is exact because 0.5 is a power of two, 23.7 isn't because 0.7 can't be written
as a finite sum of binary fractions, the stored values are therefore approximations,
and subtracting approximations gives an approximate difference. double shows 16
digits because it has 52 mantissa bits.

double did exactly what it's specified to do. The result is off by 0.0000000000000007.
If these are temperature readings, the thermometer isn't accurate to fifteen decimal
places, so the error is way smaller than the measurement error you already have.
Nothing is wrong. So the honest answer to the exercise is that the result
isn't wrong, it's imprecise in the way binary floating point is always imprecise,
and for temperatures that's fine.

Fix?:
Console.WriteLine(Math.Round(tuesday - monday, 1));
Rounds to one decimal for display. The stored value is still approximate. You've changed what you show, not what's there.

Or:
Use a decimal type, built for money for example. Its base 10 underneath, so its exact. Slower and smaller range though.

Or store integers instead by working in tenths of a degree, fx 215 instead of 21.5. then divide by 10 for display.
*/
