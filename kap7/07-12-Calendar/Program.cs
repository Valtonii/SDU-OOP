int[] monthArr = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
int[] monthLeapArr = [31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];

for (int year = 2000; year <= 2020; year++)
{
    int[] pointer = monthArr;

    if (year % 4 == 0)
    {
        pointer = monthLeapArr;
    }
    Console.WriteLine();
    Console.WriteLine("The year is: " +year);
    for (int eachMonth = 0; eachMonth < pointer.Length; eachMonth++)
    {
        Console.WriteLine(pointer[eachMonth]);


    }
    Console.WriteLine("In year " + year + " February is " + pointer[1] + " days long");
}
// 7.12 Calendar - answers
// 1. Type of monthArr and monthLeapArr: int[]
//    (each element is a number of days, so an array of int)
// 2. Type of pointer: int[]
//    (it has to be able to refer to either of the two arrays)
// 3. How much data is copied in "pointer = monthLeapArr;":
//    - only ONE reference, not the 12 ints
//    - pointer and monthLeapArr now refer to the SAME array
//    - proof: pointer[1] = 99; -> monthLeapArr[1] is also 99
//    - analogy: two notes with the same house address,
//      paint the door via one, the other sees it too
