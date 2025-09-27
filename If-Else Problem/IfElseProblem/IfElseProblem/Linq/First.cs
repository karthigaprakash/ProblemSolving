namespace ProblemSolving.Linq;

internal class First
{
    public static void Letters(List<string> words)
    {
        var word = Console.ReadLine()
                            .Split(',')
                            .Select(w => w.Trim())
                            .ToList();

        var firstLetters = word
                            .Select(e => e[0]);
        Console.WriteLine("First Letters is ");
        foreach (var letter in firstLetters)
        {
            Console.WriteLine(letter);
        }
    }
}