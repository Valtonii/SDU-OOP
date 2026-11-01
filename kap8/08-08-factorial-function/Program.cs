static int factorial (int n)
{
    if (n <= 1)
    {
        return 1;
    }
    else
    {
        return n * factorial(n - 1);
    }
}

for (int n=0;n<10;n++){
    Console.WriteLine(n + ": " + factorial(n));
}
