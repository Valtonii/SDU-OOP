for (double celcius = -5; celcius <= 40; celcius += 0.5) {
    double fahrenheit = 32 + (double) 9/5 * celcius;
    Console.WriteLine("{0:0.0} and {1:0.0}", celcius, fahrenheit);
}

/*
With {0:0.0} and {1:0.0}, you display rounded numbers but the system still holds all of those
decimals.

Where the error actually comes from isn't the multiplication. It's this:
celcius += 0.5

That runs 90 times. celcius accumulates a tiny error each round,
and the errors compound. That's numerical instability,
the thing section 5.5 mentioned.

FIX: for (int i = 0; i <= 90; i++) {
    double celcius = -5 + i * 0.5;
    ...
}
i is an int, so it's exact. Each celcius is computed in one multiplication from
an exact integer rather than built up by 90 additions. One rounding instead of ninety.

FIX 2: use decimal celcius = -5;
BUT THE COST: slower, smaller range, and it doesn't play nicely with Math functions.
Built for money, which is why I told you never to use floats for currency.

FIX 3: work in integers

Store tenths of a degree as int: -50, -45, -40. All arithmetic exact.
Divide by 10 only when displaying.
No floats anywhere, so no float problems anywhere.
*/
