int ada_lovelace = 36; // https://en.wikipedia.org/wiki/Ada_Lovelace
int dennis_ritchie = 70; // https://en.wikipedia.org/wiki/Dennis_Ritchie
int grace_hopper = 85; // https://en.wikipedia.org/wiki/Grace_Hopper
int hedy_lamarr = 85; // https://en.wikipedia.org/wiki/Hedy_Lamarr
int edsger_dijkstra = 72; // https://en.wikipedia.org/wiki/Edsger_W._Dijkstra
int douglas_engelbart = 88; // https://en.wikipedia.org/wiki/Douglas_Engelbart

float male_avg = (float)(dennis_ritchie + edsger_dijkstra + douglas_engelbart) / 3;
float female_avg = (float)(ada_lovelace + grace_hopper + hedy_lamarr) / 3;
float avg = (male_avg + female_avg) / 2;
float diff = male_avg - female_avg;

Console.Write("Average lifespan of a male computer scientist: ");
Console.WriteLine(male_avg);
Console.Write("Average lifespan of a female computer scientist: ");
Console.WriteLine(female_avg);
Console.Write("Average lifespan of a computer scientist: ");
Console.WriteLine(avg);
Console.Write("Males live this much longer than females: ");
Console.WriteLine(diff);

/*
After declaring the integers needed (whole numbers only which is the standard for age), the averages
for each gender are calculated where (float) is written first to explicitly cast it and make sure that the value,
which could include decimals, includes the decimals. The cast has to be finished before the number gets divided
by 3, so a parenthesis around the int values are necessary and the division is outside of the parenthesis.

Since that the float number is now calculated, it gets divided by 3 (an integer type) and a certain rule
applies here. An arithmetic operation on two different types yield a value of the most expressive type.
E.g., 1.0/2 ---> 0.5

The float avg doesn't need that since the inputs maleavg + female_avg already are floats and same goes
for float diff. diff is just male_avg - female_avg declared as a float

WriteLine prints your text and then moves down. Write prints your text and leaves the cursor sitting right where
it stopped, so the next thing printed continues on the same line. So Line means "and then start a new line
afterwards". Write for the label, WriteLine for the value, four times, so each line comes out as "label: number"

NOTICE: The avg calculation only works here that way because both gender groups consist of 3 people.
Averaging averages goes wrong when the groups differ in size and these don't. This notice exists as a general
warning when it comes to averaging averages.

72.666664 versus 72.6666667. That's the visible consequence of choosing float over double, but remember that
float has memory advantage in return, since its fills less bytes. Float has 23 mantissa bits, which buys
roughly seven significant digits
*/
