namespace ProblemSolving.Question;

internal class Employee 
{
    public static void Highest(List<(int Id, string Name, string Department, decimal Salary)> employees)
    {
        var result = employees
                            .Select(e => e.Salary)
                            .OrderByDescending(e => e)
                            .Skip(1)
                            .FirstOrDefault();

        Console.WriteLine($"The second highest salary : "+ result);
    }
}
