class Program
{
    static void Main(string[] args)
    {
        var result = SmallestMultiple(20);
        Console.WriteLine($"Smallest Multiple: {result}");
    }

    public static long SmallestMultiple(int max)
    {
        long num = 1;
        while(true)
        {
            for (var i = 1; i <= max; i++)
            {
                if (num % i != 0)
                {
                    num += 1;
                    i = 1;
                }

            }
            break;

        }
        return num;
    }
}