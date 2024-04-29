using System;

class Program
{
    static void Main(string[] args)
    {
        var result = LargestPalindromeProduct(3);
        Console.WriteLine($"Largest Palindrome Product: {result}");
    }

    public static int LargestPalindromeProduct(int numberOfDigits)
    {
        var str1 = "9";
        var str2 = "9";

        for (var i = 1; i < numberOfDigits; i++)
        {
            str1 += "9";
            str2 += "9";
        }

        var num1 = Int32.Parse(str1);
        var num2 = Int32.Parse(str2);

        var palindromes = new List<int>();

        for (var left = num1; left > 0; left--)
        {
            for (var right = num2; right > 0; right--)
            {
                var n = left * right;
                var nRev = Reverse(n.ToString());
                // Console.WriteLine($"{left} * {right} = {n}");

                if (n.ToString() == nRev)
                {
                    palindromes.Add(n);
                }
            }
        }

        return palindromes.OrderDescending().First();

    }

    public static string Reverse(string input)
    {
        char[] a = input.ToCharArray();
        Array.Reverse(a);
        return new string(a);
    }
}