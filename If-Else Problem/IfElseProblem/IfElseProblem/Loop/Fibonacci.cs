namespace Problem_Solving.Loop;

internal class Fibonacci  
{
    public static void Series(int n)
    {
        int a = 0, b = 1;

        for (int i = 1; i <= n; i++)
        {
            Console.Write(a + " ");

            int next = a + b;
            a = b;
            b = next;
        }
    }
}

