namespace ProblemSolving.Linq;

internal class Average 
{
    public static void Word()
    {
        var words = Console.ReadLine();
        var average = words
                    .Average(w => w);
        Console.WriteLine("Average word length : " + average);
    }
}