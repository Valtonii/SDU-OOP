int month = 2;

switch (month)
{
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        Console.WriteLine("31 days");
        break;
    case 4:
    case 6:
    case 9:
    case 11:
        Console.WriteLine("30 days");
        break;
    case 2:
        Console.WriteLine("28 days");
        break;
    default:
        Console.WriteLine("Invalid month");
        break;
}
