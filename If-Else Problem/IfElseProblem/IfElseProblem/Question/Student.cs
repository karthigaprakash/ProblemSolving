namespace ProblemSolving.Question;

internal class Student 
{
    public static void StudentAnalye(List<(string Name, int Marks)> students)
    {
        var result = new
        {
            PassFail = students
                            .Select(s => new 
                            { 
                                s.Name, 
                                Result = s.Marks >= 35 ? "Pass" : "Fail" 
                            })
                            .ToList(),

            AllPassed = students.All(s => s.Marks >= 35),

            HighestMarks = students.Max(s => s.Marks),
            LowestMarks = students.Min(s => s.Marks),
            TotalMarks = students.Sum(s => s.Marks),
            AverageMarks = students.Average(s => s.Marks),

            HighScorers = students
                                .Where(s => s.Marks > 50)
                                .Select(s => s.Name)
                                .ToList()
        };

        Console.WriteLine("Pass/Fail Result:");
        result.PassFail.ForEach(s => Console.WriteLine($"{s.Name} : {s.Result}"));

        Console.WriteLine($"\nAll students passed: {result.AllPassed}");
        Console.WriteLine($"Highest Marks: {result.HighestMarks}");
        Console.WriteLine($"Lowest Marks: {result.LowestMarks}");
        Console.WriteLine($"Total Marks: {result.TotalMarks}");
        Console.WriteLine($"Average Marks: {result.AverageMarks}");

        Console.WriteLine("\nStudents scoring more than 50:");
        result.HighScorers.ForEach(Console.WriteLine);
    }
}
