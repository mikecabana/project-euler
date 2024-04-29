using System.Text.Json;

class Program
{
    public static List<int> nums = [2];

    static void Main(string[] args)
    {
        Start(1, 2);

        Console.WriteLine(JsonSerializer.Serialize(nums));

        var sum = nums.Aggregate(0, (acc, x) => acc + x);
        Console.WriteLine($"Sum: {sum}");
    }

    public static void Start(int a, int b, int max = 4000000)
    {
        int nextFib = a + b;
        if (a == 1 && b == 2)
        {
            Console.WriteLine($"Num: {a}");
            Console.WriteLine($"Num: {b} even");
            Start(b, nextFib, max);
        }
        else if (nextFib < max)
        {
            if (nextFib % 2 == 0)
            {
                nums.Add(nextFib);
                Console.WriteLine($"Num: {nextFib} even");
            }
            else
            {
                Console.WriteLine($"Num: {nextFib}");
            }
            Start(b, nextFib, max);
        }

        return;
    }
}