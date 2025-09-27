namespace ProblemSolving.Linq;

internal class Word 
{
    public static void Letter(List<string> names)
    {
        var first = names
                        .GroupBy(n => n[0]);
        foreach (var g in first)
        {
            Console.WriteLine($"Starts with {g.Key}: {string.Join(", ", g)}");
        }
    }
}