
namespace ProblemSolving.Linq;

internal class Student 
{
    public static void 
        PassFail(List<(string Name , int Mark)> students)
    {
        var response = students
                            .Select( 
                                s => new {
                                    StudentName = s.Name,
                                    Pass = s.Mark >= 50
                                })
                            .ToList();
        Console.WriteLine("The number of students result is pass and fail");
        foreach (var stu in response) 
        {
            Console.WriteLine($"{stu.StudentName} : {(stu.Pass ? "Pass" : "Fail")}");
        }
    }
}