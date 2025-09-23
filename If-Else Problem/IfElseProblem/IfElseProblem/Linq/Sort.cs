namespace ProblemSolving.Linq;

internal class Sort
{
    public static void Alphabetically()
    {
        var words = Console.ReadLine()
                       .Split(' ');
        var sorted = words
                        .OrderBy(s => s);
        Console.WriteLine("Sorted Words: " + string.Join(" ",sorted));
    }
}
