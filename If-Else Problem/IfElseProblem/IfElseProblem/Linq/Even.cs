namespace ProblemSolving.Linq;

internal class Even
{
    public static void FilterEvenNumbers()
    {
        var num = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();
        var evens = num.Where(n => n % 2 == 0);
        Console.WriteLine("Even Numbers: " + string.Join(", ", evens));
    }
}
