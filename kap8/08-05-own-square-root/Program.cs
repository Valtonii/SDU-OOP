double sqrt (double x)
{
    double squareFind = 0;

    for (double place = 10; place >= 0.000000001; place = place / 10) {
            while((squareFind + place)*(squareFind+place)<=x) {

                squareFind = squareFind + place;
            }
    }
    return squareFind;
}

double result = sqrt(25);
Console.WriteLine(result);

/*
Two different variables. place never becomes 3.

place is the size of the step you’re taking: 10, then 1, then 0.1.
squareFind is the answer you’re building: 0 → 1 → 2 → 3.

The thing to see: the inner loop runs ten times for every single value of place. place sits still while that happens.

With x = 9:

Outer pass 1, place = 10. Inner loop runs ten times. Every time it asks “is (squareFind + 10)² ≤ 9?”

The first is 10² = 100, no. squareFind stays 0 through all ten.

Outer pass 2, place = 1. Inner loop runs ten times again:

pass	test	result	squareFind
1	(0+1)² = 1 ≤ 9	yes	0 → 1
2	(1+1)² = 4 ≤ 9	yes	1 → 2
3	(2+1)² = 9 ≤ 9	yes	2 → 3
4	(3+1)² = 16 ≤ 9	no	stays 3
5-10	same	no	   stays 3

Outer pass 3, place = 0.1. Ten more times. (3 + 0.1)² = 9.61, over 9.

Fails every time. Stays 3.

So squareFind reaches 3 by adding place to itself three times, all during the single pass where place was 1.
*/
