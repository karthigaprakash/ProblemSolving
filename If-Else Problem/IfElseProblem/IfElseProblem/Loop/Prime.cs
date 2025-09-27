namespace Problem_Solving.Loop;

internal class Prime
{
    public static void ShowPrimes(int n)
    {
        Console.WriteLine($"Prime numbers between 2 and {n}:");

        for (int i = 2; i <= n; i++)
        {
            bool isPrime = true;

            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                Console.Write(i + " ");
        }
    }
}

