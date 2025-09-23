namespace ProblemSolving.Linq;

internal class First
{
    public static void Letters()
    {
        var words = Console.ReadLine();
        var letter = words
                    .Select(s => s);
        foreach (var a in letter)
        {
            Console.WriteLine(a);
        }
    }
}