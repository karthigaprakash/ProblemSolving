namespace ProblemSolving.Linq
{
    internal class List
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

        public static void StuDep(string? studentName, int deptId , string deptName)
        {
            var students = new List<Student>
            {
                new Student {Name = studentName}
            };

            var departments = new List<Department>
            {
                new Department { DeptId = deptId, DeptName = deptName }
            };

            var left = from s in students
                           join d in departments
                           on s.DeptId equals d.DeptId into sd
                           from d in sd.DefaultIfEmpty()
                       select new 
                           { 
                               s.Name,
                               d = d?.DeptName ?? "No Department"
                           };

            Console.WriteLine("Student and Department Details (No Department)");

            foreach (var s in left)
                Console.WriteLine($"{s.Name} - {s.d}");

        }
    }
}
