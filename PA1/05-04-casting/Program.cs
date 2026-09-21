/*
SUMMARY:
int to long is implicit, every int fits
long to int needs an explicit cast, not every long fits
float to double implicit, double to float explicit, and that one loses precision rather than overflowing
the compiler's requirement does not depend on the value, but the result does

*/


/*
I messed around alot for the experimental part so all of this code is bs at this point
long l = 3000000000;
int i = (int)l;
Console.WriteLine(i);
*/

/*

long l = i; compiled with no cast. Why? because you can convert a long into an int with no issue, long is "bigger"
i = l; refused. Why? The opposite reason of the first explanation above.

*/

float f = 1;
double d = f;
f = (float)d;
Console.WriteLine(d);
/*
double d = f;      // worked, no cast
f = (float)d;      // needed the cast

The direction that works freely is float into double. So a float can be a double, but not every double can be a float.

Same shape as int and long: the smaller type goes into the bigger one for free. float to double is also safe.
But going down, double to float, you don't just risk overflow like with long to int. You lose precision.
*/
