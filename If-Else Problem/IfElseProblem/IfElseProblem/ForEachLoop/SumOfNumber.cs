namespace Problem_Solving.ForEachLoop;

internal class SumOfNumber
{
    public static int GetSum(int[] arr)
    {
        int sum = 0;
        foreach (int n in arr) sum += n;
        return sum;
    }
}
