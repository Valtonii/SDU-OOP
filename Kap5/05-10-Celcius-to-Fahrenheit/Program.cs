double celsius = 37.5;
double fahrenheit = 32 + (double) 9/5 * celsius;

Console.WriteLine("");
Console.Write("The temperature is: ");
Console.Write(fahrenheit);
Console.WriteLine(" fahrenheit!");
Console.WriteLine("");

// It would have been enough to write 9.0/5 instead of (double),
// since the type is already declared as a double to start with
// My version worked because:
// "That means the cast applies to 9 alone, not to 9/5.
// You get (double)9 / 5, which is double / int"
