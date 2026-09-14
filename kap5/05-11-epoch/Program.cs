int secondsSinceFeb2007 = 617779115; // Calculates seconds since my birthday, feb. 12 2007

const int secondsPerDay = 60 * 60 * 24; // 86400
const int secondsPerYear = secondsPerDay * 365; // 31536000

int yearsSinceFeb2007 = secondsSinceFeb2007 / secondsPerYear; // Regner år siden feb. 12 2007
int daysIntoYear = (secondsSinceFeb2007 % secondsPerYear) / secondsPerDay;

/* 
Modulo, the % operator, calculates ONLY the rest of that equation. Then i divide with 
secondsPerDay to get the number of days left over.
*/

Console.WriteLine(2007 + yearsSinceFeb2007);
Console.WriteLine(daysIntoYear);

/* 
The exercise told us to assume that a year is 365 days, when stuff like leap years exist,
so this is not viable code.
*/
