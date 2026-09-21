int[] taskExample = [-7,3,-2,10,-15,0,-4];
int largestNeg = taskExample[0];

foreach (int number in taskExample) {
    if (number<largestNeg) {
        largestNeg = number;
        Console.WriteLine("Largest negative value: " + largestNeg);
    }   
}
/* 
I chose to understand this task by having to print out the largest negative value (im assuming that would be -15 in my array).
*/