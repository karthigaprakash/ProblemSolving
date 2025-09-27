namespace Problem_Solving.ForEachLoop;

internal class Average
{
    public static void CalculateAverage(int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        int average = sum / numbers.Length;
        Console.WriteLine($"Average: {average}");
    }



}
