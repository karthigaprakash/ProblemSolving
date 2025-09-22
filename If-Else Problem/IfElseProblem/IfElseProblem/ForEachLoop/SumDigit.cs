namespace Problem_Solving.ForEachLoop;

internal class SumDigit
{
    public static int SumOfDigits(string str)
    {
        int sum = 0;

        foreach (char c in str)
        {
            if (char.IsDigit(c))
            {
                sum += c - '0';
            }
        }

        return sum;
    }
}
