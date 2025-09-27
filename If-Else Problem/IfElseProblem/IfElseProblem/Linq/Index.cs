namespace ProblemSolving.Linq;

internal class Index 
{
    public static void 
        Value(string[] arr)
    {
        var indexValuePairs = arr
                    .Select(
                    (value, index) => new { 
                            Index = index,
                            Value = value }
                    );

        Console.WriteLine("Number of Array :");

        foreach (var item in indexValuePairs) 
        { 
            Console.WriteLine($"{item.Value} : {item.Index}"); 
        }
    }
}