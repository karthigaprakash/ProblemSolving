namespace ProblemSolving.Linq;

internal class Upper 
{
    public static void Conversion(List<string> words)
    {
        var upperword = words
                    .Select(w => w.ToUpper());
        Console.WriteLine("UpperCase");
        foreach (var letter in upperword)
        {
            Console.WriteLine(letter);
        }
    }
}