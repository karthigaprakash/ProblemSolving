namespace ProblemSolving.Linq;

internal class Pair 
{
    public static void Word(string[] arr)
    {
        var words = arr
            .Select(x => new 
            {
                Word = x, 
                Length = x.Length 
            });

        Console.WriteLine("Word length");

        foreach(var x in words)
        {
            Console.WriteLine($"{x.Word}: {x.Length}");
        }
    }
}