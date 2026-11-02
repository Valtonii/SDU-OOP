string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
int[] monthArr = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
string[][] calendar = new string[12][];

int dayCounter = 0;

for (int month = 0; month < calendar.Length; month++)
{
    calendar[month] = new string[monthArr[month]];

    for (int day = 0; day < monthArr[month]; day++)
    {
        calendar[month][day] = days[dayCounter % days.Length];
        dayCounter++;
    }
}
string[] monthNames = { "January", "February", "March", "April", "May", "June",
                        "July", "August", "September", "October", "November", "December" };

for (int month = 0; month < calendar.Length; month++)
{
    Console.WriteLine(monthNames[month]);

    for (int day = 0; day < calendar[month].Length; day++)
    {
        Console.WriteLine("  " + (day + 1) + ". " + calendar[month][day]);
    }

    Console.WriteLine();
}
