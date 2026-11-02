bool[] sieve = new bool[1000001];   // true = still prime
double iRoot = Math.Sqrt(sieve.Length-1);

for (int i = 0; i < sieve.Length; i++)
{
    sieve[i] = true;
}

sieve[0] = false;
sieve[1] = false;


for (int i = 2; i <= iRoot; i++)
{
    if (sieve[i]){
        for (int n = i + i; n < sieve.Length; n += i) {
            sieve[n] = false;
        }
    }
}

for (int i = sieve.Length-1; i>=0;i--){
    if(sieve[i]){
        Console.WriteLine("The biggest prime number is: " + i);
        break;
    }
}
