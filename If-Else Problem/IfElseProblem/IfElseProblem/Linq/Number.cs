namespace ProblemSolving.Linq;

internal class Number
{
    public static void Greater()
    {
        var numbers = Console.ReadLine()
                         .Split(' ')
                         .Select(int.Parse)
                         .ToArray();
        Console.WriteLine("Enter the value of N:");
        var n = Convert.ToInt32(Console.ReadLine());
        var greater = numbers.Where(x => x > n);
        Console.WriteLine("Numbers greater than " + n + ": " + string.Join(", ", greater));
    }
}
