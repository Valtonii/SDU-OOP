// See https://aka.ms/new-console-template for more information

/*
Exercise 5.7: Expression vs Statement

   An expression evaluates to a value. A statement does not.

   x evaluates to the value 5, so it is an expression.
   int x = 5; evaluates to nothing, it only carries out an
   instruction, so it is a statement.

   Expressions:  42, "Hello", 2 + 3, x
   Statements:   int x = 5;   Console.WriteLine("Hi");

   Note that Console.WriteLine("Hi"); CONTAINS the expression "Hi".
   The inner part has a value. The whole line does not.

   The test: can it go on the right of an = ?
   string b = "Hi";                    compiles
   string c = Console.WriteLine("Hi"); does not, no value to store
*/
int x = 5;

Console.WriteLine(x);        // x is an expression, prints 5
Console.WriteLine(x + 1);    // arithmetic on x proves it is a value
Console.WriteLine(2 + 3);    // expression, prints 5
Console.WriteLine("Hello");  // "Hello" is an expression

string b = "Hi";             // works, "Hi" is an expression
Console.WriteLine(b);

// Uncomment to see the type checker reject it:
// string c = Console.WriteLine("Hi");
// error CS0029: Cannot implicitly convert type 'void' to 'string'
