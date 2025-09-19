namespace ProblemSolving.SampleProgram;

internal class Grades   
{
    public static string GradeSystem(string grade)
    {
        switch (grade)
        {
            case "A": 
                return "Excellent";
            case "B": 
                return "Good";
            case "C": 
                return "Average";
            case "D": 
                return "Below Average";
            case "F": 
                return "Fail";
            default: 
                return "Invalid grade";
        }
    }
}
