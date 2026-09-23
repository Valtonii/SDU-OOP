const double pi = 3.14159;
double[] radiuses = [1,3,5];
Console.WriteLine();

for (int i = 0; i < radiuses.Length; i++)
{
    double circleArea = pi * radiuses[i] * radiuses[i];
    Console.WriteLine("The area of the circle with radius = {0} is: {1:0.00}", radiuses[i], circleArea);
}
Console.WriteLine();
