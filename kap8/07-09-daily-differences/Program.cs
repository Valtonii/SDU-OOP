double monday = 21.5;
double tuesday = 23.7;
double wednesday = 19.6;
double thursday = 22.5;
double friday = 25.3;
double saturday = 21.7;
double sunday = 18.9;

double[] temp = [monday, tuesday, wednesday, thursday, friday, saturday, sunday];

double[] Differences(double[] values)
{
    double[] tempDiff = new double[values.Length - 1];
    for (int i = 0; i < tempDiff.Length; i++)
    {
        tempDiff[i] = values[i + 1] - values[i];
    }
    return tempDiff;
}

double[] result = Differences(temp);

for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}
