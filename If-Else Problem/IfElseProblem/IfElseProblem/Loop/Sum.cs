namespace Problem_Solving.Loop;

internal class Sum
{
    public static int Calculate(int n)
    {
        int sum = 0;

        for (; n != 0; n /= 10)
        {
            sum += n % 10;
        }
        return sum;
    }
}

