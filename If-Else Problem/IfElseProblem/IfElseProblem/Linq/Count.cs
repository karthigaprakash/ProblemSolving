namespace ProblemSolving.Linq;

internal class Count
{
    public static void Words()
    {
        var words = Console.ReadLine()
                            .Split(' ');
        var count = words.Count(w => "aeiouAEIOU".Contains(w[0]));
        Console.WriteLine("Words starting with vowel: " + count);
    }
}