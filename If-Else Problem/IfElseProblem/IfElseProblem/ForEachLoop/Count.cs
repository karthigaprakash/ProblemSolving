namespace Problem_Solving.ForEachLoop;

internal class Count
{
    public static void CountWords(string sentence)
    {
        int count = 0;
        foreach (var word in sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries))
            count++;

        Console.WriteLine($"Number of words: {count}");
    }
}
