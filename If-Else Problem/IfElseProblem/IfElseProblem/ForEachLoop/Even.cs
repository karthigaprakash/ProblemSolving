namespace Problem_Solving.ForEachLoop;

internal class Even
{
    public static int CountEven(int[] arr)
    {
        int count = 0;
        foreach (int n in arr)
            count += (n % 2 == 0) ? 1 : 0;
        return count;
    }
}
