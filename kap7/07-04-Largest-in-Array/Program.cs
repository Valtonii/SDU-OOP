int[] taskExample = [-7,3,-2,10,-15,0,-4];
int largest = taskExample[0];
int largestIndex = 0;

for (int i = 0; i < taskExample.Length; i++)
{
    if (largest < taskExample[i])
    {
        largest = taskExample[i];
        largestIndex = i;
    }
}
Console.WriteLine(largest); // Everything to do with this variable was to output the int value that the array contained.
Console.WriteLine(largestIndex); // Everything to do with this variable was to output the index number
