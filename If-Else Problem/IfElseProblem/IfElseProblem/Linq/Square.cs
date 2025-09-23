namespace ProblemSolving.Linq;

internal class Square
{
   public static void Numbers()
    {
        var num = Console.ReadLine()
                      .Split(' ')
                      .Select(int.Parse)
                      .ToArray();
        var squares = num
                        .Select(x => x * x);
        Console.WriteLine("Squares: " + string.Join(", ", squares));
    }
}
