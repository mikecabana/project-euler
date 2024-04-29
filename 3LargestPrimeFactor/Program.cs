class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Calculating...");
        // var p = LargestPrimeFactor(13195);
        var p = LargestPrimeFactor(600851475143);
        Console.WriteLine($"{p}");
    }

    public static long LargestPrimeFactor(long number)
    {
        long largestPrime = 1;

        // Remove all factors of 2
        while (number % 2 == 0)
        {
            largestPrime = 2;
            number /= 2;
        }

        // After removing factors of 2, we only need to check odd numbers
        for (long i = 3; i <= Math.Sqrt(number); i += 2)
        {
            while (number % i == 0)
            {
                largestPrime = i;
                number /= i;
            }
        }

        // If the remaining number is a prime greater than 2
        if (number > 2)
            largestPrime = number;

        return largestPrime;
    }

    // the following methods are for reference and for fun

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