double discriminant (double a, double b, double c)
{
    double d = (b * b) - 4 * a * c;

    return d;
}

double[] roots (double a, double b, double c)
{
    double result = discriminant(a, b, c);
    double[] roots;

    if (result > 0)
    {
        roots = new double[2];
        double x1 = (-b + Math.Sqrt(result)) / (2 * a);
        double x2 = (-b - Math.Sqrt(result)) / (2 * a);
        roots[0] = x1;
        roots[1] = x2;
    }
    else if (result == 0)
    {
        roots = new double[1];
        roots[0] = -b / (2 * a);

    }
    else
    {
        roots = new double[0];
    }

    return roots;
}
double[] rootsResult = roots(1, -4, 1);
for (int i = 0; i < rootsResult.Length; i++)
{
    Console.WriteLine(rootsResult[i]);
}
