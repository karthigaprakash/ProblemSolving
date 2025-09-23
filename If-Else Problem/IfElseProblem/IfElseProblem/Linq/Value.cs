namespace ProblemSolving.Linq;

internal class Value
{
    public static void Greater()
    {
        var numbers = Console.ReadLine()
                         .Split(' ')
                         .Select(int.Parse)
                         .ToArray();
        var sum = numbers.Where(x => x >= 10)
                       .Sum();
        Console.WriteLine("Numbers greater than " + 10 + ": " + string.Join(", ", sum));
    }
}
    