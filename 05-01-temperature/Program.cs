// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/* Which types are suitable for representing a temperature?

Temperatures carry fractions (36.6 degrees), so integer types are out:
they only hold whole numbers and would discard the decimals.

That leaves the floating point types, float and double. Neither has a
signed/unsigned distinction, so that question doesn't arise; both handle
negative temperatures.

Range is not the deciding factor. float reaches roughly 10^38, which is
far beyond any temperature. Precision isn't either: temperatures carry
one or two decimals in practice, and float's 23 mantissa bits are more
than enough.

What actually decides it:
- float uses half the memory. Only matters when storing very many
  readings, e.g. sensor data.
- double is C#'s default for a decimal literal. Writing 36.6 gives a
  double. Choosing float means writing 36.6F everywhere, and mixed
  arithmetic promotes back to double anyway.

Conclusion: double for ordinary use, float for large datasets where
memory matters.
*/
