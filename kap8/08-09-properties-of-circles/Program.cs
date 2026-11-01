const double pi = 3.14159;
double[] radiuses = [1,3,5];
Console.WriteLine();

double CircleArea (double pi, double radius)
{
    double area = pi * radius * radius;
    return area;
}

double CircleCircumference (double pi, double radius)
{
    double circumference = 2 * pi * radius;

    return circumference;
}

for (int i = 0; i < radiuses.Length; i++)
{
    double areaResult = CircleArea(pi, radiuses[i]);
    double circumferenceResult = CircleCircumference(pi, radiuses[i]);
    Console.WriteLine("Area of circle with radius {0} is: {1:0.00}", radiuses[i], areaResult);
    Console.WriteLine("And the circumference of that circle is: {0:0.00}", circumferenceResult);
    Console.WriteLine();
}
Console.WriteLine();
