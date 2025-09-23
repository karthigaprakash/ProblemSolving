namespace ProblemSolving.Linq;

internal class DecimalVal 
{
    public static void MaxMin()
    {
        var num = Console.ReadLine()
                            .Split(' ')
                            .Select(decimal.Parse)
                            .ToArray();
        var max = num.Max();
        var min = num.Min();
        Console.WriteLine("Maximum: " + max + ", Minimum: " + min);
    }
}
    