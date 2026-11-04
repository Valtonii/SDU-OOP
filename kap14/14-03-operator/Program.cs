class OperatorTest
{
    public static int Operator(int a, int b, bool c)
    {
        return a + b;
    }

    public static int Operator(int a, int b, char c)
    {
        return a - b;
    }

    public static void Main(string[] args)
    {
        for (int a = 0; a < 5; a++)
        {
            for (int b = 0; b < 5; b++)
            {
                Console.WriteLine(a + " (?1?) " + b + " = " + Operator(a, b, true));
                Console.WriteLine(a + " (?2?) " + b + " = " + Operator(a, b, false));
                Console.WriteLine(a + " (?3?) " + b + " = " + Operator(a, b, 'a'));
                Console.WriteLine(a + " (?4?) " + b + " = " + Operator(a, b, 'b'));
                Console.WriteLine(a + " (?5?) " + b + " = " + Operator(a, b, '.'));
            }
        }
    }
}

/* 14.3 Operator - answers

1. (?1?) and (?2?) are +.  (?3?), (?4?) and (?5?) are -.

2. The third argument decides. true/false are bool, so those calls match
      Operator(int, int, bool), which returns a + b.
      'a', 'b' and '.' are char, so those match Operator(int, int, char),
       which returns a - b.

3. The important part is the TYPE of the third parameter, not its value.
       Neither method body ever reads c. The rule exploited: a method's
       signature is its name plus its parameter types, so two methods can
       share a name as long as some parameter type differs. Supplying a value
       of a given type is therefore a way of naming which version you want.
       This is decided at COMPILE TIME.

4. No. The parameter lies about its purpose: it looks like data and is
       actually a selector, and nothing in the call site says which operator
       you get. A plain bool flag (if plus ... else ...) compiles to equally
       fast code and can at least be read. Best of all would be two methods
       with honest names, Add and Subtract. Most people would call this a
       misuse of the type system.
*/
