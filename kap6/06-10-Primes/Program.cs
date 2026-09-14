int largest = 0;

for (int n = 2; n < 1000000; n++) {
    bool isPrime = true;

    for (int d = 3; d < n; d++) {
        if (n % d == 0) {
            isPrime = false;
            break;
        }

    }
    if (isPrime)  {
        largest = n;
    }
}
Console.WriteLine(largest);

/* Line 3, the outer loop. for (int n = 2; n < 20; n++) opens it.
Three slots separated by semicolons. The first, int n = 2, runs once and creates n.
The second, n < 20, is checked before every round; true means run the body,
false means the loop is over. The third, n++, runs after every round and adds one.
So the order per round is: check, run body, update. The update is last, which is why the
body sees n as 2 on the first round rather than 3. n is the number currently being tested.

Line 6, the switch. bool isPrime = true; sits inside the outer loop, so it is created fresh
for every new n. Number 12 inherits nothing from number 11. It starts at true, meaning assume
prime until proven otherwise. Starting at false would not work, because no single check can
prove a number is prime; only checking every divisor and finding none can.

Line 8, the inner loop. for (int d = 2; d < n; d++) opens it. d is the divisor being tested.
It is a separate variable from n with no relationship to it, and it is created fresh each time
the inner loop starts, so for every new n it goes back to 2. It starts at 2 rather than 1
because every number divides by 1, so testing that tells you nothing. It stops before n
because every number divides by itself, so testing that tells you nothing either. What remains
is exactly the divisors strictly between 1 and n, which are the only ones that matter.

Lines 8 to 10, the test. if (n % d == 0) { isPrime = false; }. The expression n % d is the
remainder of dividing n by d. Ten remainder five is 0, so 5 divides 10 evenly. Ten remainder
three is 1, so it does not. Comparing that remainder to 0 turns it into a bool. If it is true
you have found a divisor, so n is not prime, so the switch flips. Nothing anywhere in the
program sets it back to true, so once false it stays false for this n. One divisor is enough.

Lines 16 to 18, the verdict. if (isPrime) { Console.WriteLine(n); } sits after the inner loop
but still inside the outer one. By this point every divisor has been checked, so the switch is
final. If nothing flipped it, no divisor exists, so n is prime and gets printed.

Trace for n = 4. isPrime starts true. d = 2, and 2 < 4 is true, so the body runs: 4 remainder 2
is 0, so isPrime becomes false. d becomes 3, and 3 < 4 is true: 4 remainder 3 is 1, so nothing
happens. d becomes 4, and 4 < 4 is false, so the inner loop ends. isPrime is false, so 4 is not
printed. OBS: i added break; to stop it looking for the next d values when it found isPrime to
be false earlier, for example 4 remainder 2 is 0 and isPrime becomes false. Now it doesn't
look at 4 remainder 3 and so on since it already got its answer.

Trace for n = 5. isPrime starts true. d = 2, and 2 < 5 is true: 5 remainder 2 is 1, nothing
happens. d becomes 3: 5 remainder 3 is 2, nothing happens. d becomes 4: 5 remainder 4 is 1,
nothing happens. d becomes 5, and 5 < 5 is false, so the inner loop ends. isPrime is still true,
so 5 is printed.

Both loops ended the same way. What differed is whether the if inside ever fired.

int largest = 0; at the very top. Before the outer loop. It is an int because it holds a number
, not a true or false. It starts at 0 because that is lower than any prime, so the first prime
you find will replace it. Nothing else about the choice matters here; you just need a starting
value, and 0 is the obvious one.

largest = n; replaces Console.WriteLine(n). Same position, inside if (isPrime), inside the
outer loop. Every time you find a prime, you overwrite largest with it. Because the outer loop
counts upward, each prime you find is bigger than the last, so overwriting always means
overwriting with something larger.

Console.WriteLine(largest); after the closing brace of the outer loop. Outside everything.
It runs once, when all the counting is done, and prints whatever was written last.
*/
