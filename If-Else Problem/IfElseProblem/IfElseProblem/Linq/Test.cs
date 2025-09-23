namespace ProblemSolving.Linq;

internal class Test
{
    public static void Letters()
    {
        var words = Console.ReadLine();
        var letter = words
                    .Select(s => s);
        foreach (var s in letter) 
        { 
            Console.WriteLine(s);
        }
    }
}