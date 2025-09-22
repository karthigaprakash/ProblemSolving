namespace Problem_Solving.ForEachLoop;

internal class Max
{
    public static int MaxArray(int[] arr)
    {
        int max = arr[0];
        foreach (int n in arr) 
            if (n > max) max = n;
        return max;
    }
}
