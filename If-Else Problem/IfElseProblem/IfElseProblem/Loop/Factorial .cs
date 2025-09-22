namespace Problem_Solving.Loop;

internal class Factorial
{
    public static int FactorialLoop(int n)
    {
        int fact = 1;

        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }

        return fact;

        //return (n <= 1) ? 1 : n * FactorialLoop(n - 1);
    }
}

