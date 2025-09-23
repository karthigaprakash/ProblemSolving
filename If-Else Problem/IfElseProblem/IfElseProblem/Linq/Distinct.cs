namespace ProblemSolving.Linq;

internal class Distinct
{
    public static void Elements()
    {
        var num = Console.ReadLine()
                          .Split(' ')
                          .Select(int.Parse)
                          .ToArray();
        var distinct = num
                          .Distinct();
        Console.WriteLine("Unique Elements: " + string.Join(", ", distinct));
    }
}
