int month = 10;

switch (month) {
    case 10:
        Console.WriteLine("Autumn holiday");
        break;
    case 12:
        Console.WriteLine("Christmas holiday");
        break;
    case 4:
        Console.WriteLine("Spring holiday");
        break;
    case 7:
        // Console.WriteLine("Summer holiday");
        // break;
        // DETTE KAN FAKTISK FJERNES OG CASE VILLE STADIGE VIRKE, det er kaldet "fall-through"
    case 8:
        Console.WriteLine("Summer holiday");
        break;
    default:
        Console.WriteLine("Hard work");
        break;
}
