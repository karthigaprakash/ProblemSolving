namespace ProblemSolving.Linq;

internal class Perform
{
    public class Student
    {
        public int Id;
        public string? Name;
        public int DeptId;
    }

    public class Department
    {
        public int DeptId;
        public string? DeptName;
    }

    public static void StuDep(string? studentName, int deptId, string? deptName)
    {
        var students = new List<Student>
            {
                new Student {Name = studentName, DeptId = deptId }
            };

        var departments = new List<Department>
            {
                new Department { DeptId = deptId, DeptName = deptName }
            };

        var result = students
                           .Join(departments,
                               s => s.DeptId,
                               d => d.DeptId,
                               (s, d) => new
                               {
                                   StudentName = s.Name,
                                   DepartmentName = d.DeptName
                               });

        Console.WriteLine("Student and Department Details:");

        foreach (var item in result)
        {
            Console.WriteLine($"{item.StudentName} : {item.DepartmentName}");
        }
    }
}