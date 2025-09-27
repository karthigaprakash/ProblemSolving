namespace ProblemSolving.Linq;

internal class Average 
{
    public static void Word()
    {
        var words = Console.ReadLine()
                    .Split(' ');
        var average = words
                    .Average(w => w.Length);
        Console.WriteLine("Average word length : " + average);
    }
}