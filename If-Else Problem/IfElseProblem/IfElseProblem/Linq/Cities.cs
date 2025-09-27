namespace ProblemSolving.Linq;

internal class Cities 
{
    public static void Count(List<string> Cities)
    {
        var city = Cities
                      .GroupBy(x => x)
                      .Select(y => new
                      {
                          City = y.Key,
                          Count = y.Count()
                      })
                      .ToList();

        Console.WriteLine("City count");

        foreach (var y in city)
            Console.WriteLine($"{y.City} : {y.Count}");
    }
}