int iterationer = 10;
int[] array = { 1, 2, 3, 4, 5 };

// increment

for (int i = 0; i < iterationer; i++)
{
    try {
        array[i]++;
        }
        catch (IndexOutOfRangeException){
            Console.WriteLine("noob");
}


}
// print
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

/*
Exceptions are for conditions you cannot reasonably prevent: a dropped connection, a missing file, bad user input.
An index you control yourself is preventable with a correct bound.
Catching it here doesn’t fix the defect, it silences the symptom.
*/
