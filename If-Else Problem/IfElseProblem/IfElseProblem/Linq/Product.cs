namespace ProblemSolving.Linq;

internal class Product
{
    public static void Value()
    {
        var num = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToArray();
        var product = num
                        .Aggregate((a, b) => a * b);
        Console.WriteLine("Product: " + product);
    }
}