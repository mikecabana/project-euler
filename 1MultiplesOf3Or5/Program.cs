class Program
{
    static void Main(string[] args)
    {
        Start(1000);
    }

    public static void Start(int n)
    {
        int sum = 0;
        for (var i = 1; i < n; i++)
        {
            if (i % 3 == 0 || i % 5 == 0) {
                // Console.WriteLine(i);
                sum+= i;
            }

        }
        Console.WriteLine($"Sum: {sum}");
    }
}