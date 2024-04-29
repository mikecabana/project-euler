class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Calculating...");
        // var p = LargestPrimeFactor(13195);
        var p = LargestPrimeFactor(600851475143);
        Console.WriteLine($"{p}");
    }

    public static long LargestPrimeFactor(long n)
    {
        long lastPrimeFactor = 0;

        for (long i = 2; i < n; i++)
        {
            if (IsPrime(i) && n % i == 0)
            {
                lastPrimeFactor = i;
                Console.WriteLine(i + " is a prime factor of " + n);
            }
        }

        return lastPrimeFactor;
        // var primeFactors = new List<int>();

        // var prime = NextPrime(0);
        // while (prime <= n) {
        //             Console.WriteLine($"{prime}");

        //     if (n % prime == 0) {
        //         primeFactors.Add(prime);
        //     }
        //     prime = NextPrime(prime);
        // }

        // return primeFactors.Last();
    }

    public static int NextPrime(int n)
    {
        if (n == 0)
        {
            n = 1;
        }
        var nextNum = n += 1;
        for (var i = 2; i <= nextNum; i++)
        {
            if (nextNum != i && nextNum % i == 0)
            {
                return NextPrime(nextNum);
            }
        }
        return nextNum;
    }

    public static IList<int> NPrimes(int n)
    {
        var primes = new List<int>();
        for (var i = 2; i <= n + 2; i++)
        {
            i = NextPrime(i);
            primes.Add(i);
            Console.WriteLine($"{i}");
        }
        return primes;
    }

    public static bool IsPrime(long n)
    {
        if (n < 4) return n > 1;
        if (n % 2 == 0 || n % 3 == 0) return false;

        long limit = (long)Math.Sqrt(n);
        for (long i = 5; i <= limit; i += 2)
        {
            if (n % i == 0) return false;
        }

        return true;
    }
}