namespace ProblemSolving.Question;

internal class TopStudents
{
    public static void HighestMark(List<(string Name, int Mark)> students)
    {
        var response = students
                            .Select(e => new
                            {
                                StudentName = e.Name,
                                StudentMark = e.Mark,
                            })
                            .OrderByDescending(e => e.StudentMark)
                            .Take(2)
                            .ToList();

        Console.WriteLine("Top three Students Mark");

        foreach (var stu in response)
        {
            Console.WriteLine($"{stu.StudentName} : {(stu.StudentMark)}");
        }
    }
}
