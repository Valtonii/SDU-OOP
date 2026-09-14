int christmasDays = 360 - 4; // Calculates the amount of days until christmas from newYear
int secDay = 86400; // Seconds in a day 
int secNewYear = christmasDays * secDay + 43200;
double price = 599.95;
double rabat = price - ((price/100)*30);

int secInDays = (secNewYear/secDay); // Calculates the seconds into days
    // Console.WriteLine(secInDays);




bool christmas = secInDays == christmasDays;

if (christmas == false) {
    Console.WriteLine("It's not Christmas, no discount for you");
    } else {
        Console.Write("It's Christmas! Discount for you brother.");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write("It's gonna be: "); 
        Console.WriteLine(rabat);
        Console.WriteLine("");
    }