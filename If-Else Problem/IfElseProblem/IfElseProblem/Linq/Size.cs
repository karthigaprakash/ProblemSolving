using static ProblemSolving.Linq.Size;

namespace ProblemSolving.Linq
{
    internal class Size
    {
        public class Employees
        {
            public int Id;
            public string? Name;
            public int DepartmentId;
        }

        public static void Employee(List<Employees> employees)
        {
            var response = employees
                            .GroupBy(x => x.DepartmentId)
                            .OrderByDescending(y => y.Count());

            Console.WriteLine("The Values");

            foreach (var group in response)
            {
                Console.WriteLine($"Department ID: {group.Key}, Employee Count: {group.Count()}");
                foreach (var employee in group)
                {
                    Console.WriteLine($" Name: {employee.Name}");
                }
            }
        }
    }
}
