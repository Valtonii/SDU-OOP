int christmasDays = 11 * 30 + 25; // Calculates the amount of days until christmas from newYear
int secDay = 86400; // Seconds in a day
int secNewYear = christmasDays * secDay + 21816000;
double price = 599.95;
double discountedPrice = price - ((price/100)*30);

int secInDays = (secNewYear/secDay); // Calculates the seconds into days
    // Console.WriteLine(secInDays);




bool christmas = secInDays == christmasDays;

if (!christmas) { //christmas == false AND !christmas is the same thing
    Console.WriteLine();
    Console.WriteLine("It's not Christmas, no discount for you");
    Console.WriteLine();
    } else {
        Console.WriteLine();
        Console.Write("It's Christmas! Discount for you brother.");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("It's gonna be: ");
        Console.WriteLine(discountedPrice);
        Console.WriteLine();
    }
    /*
    Testværdier for secNewYear:

    252 * secDay      -> gav: "not Christmas"
    354 * secDay      -> gav: "not Christmas"
    355 * secDay      -> gav: "It's Christmas!"
    356 * secDay      -> gav: "not Christmas"
    355 * secDay + 43200 -> gav: "It's Christmas!"

    */
