const double pi = 3.14159;

for (int radius = 1; radius <= 5; radius += 2) {
    double area = pi * radius * radius;
    Console.WriteLine("The area of this circle is {0:0.00}", area);
    Console.WriteLine();
}
