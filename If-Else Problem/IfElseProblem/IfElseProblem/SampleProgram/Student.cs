namespace ProblemSolving.SampleProgram;

internal class Student
{
    public static string GetResult(double percentage)
    {
        if (percentage >= 60)
        {
            if (percentage >= 90)
                return "First Division - Excellent";
            else if (percentage >= 75)
                return "First Division - Good";
            else
                return "First Division - Average";
        }
        else if (percentage >= 45)
        {
            if (percentage >= 75)
                return "Second Division - Good";
            else
                return "Second Division - Average";
        }
        else if (percentage >= 33)
        {
            return "Third Division";
        }
        else
        {
            return "Fail";
        }
    }

}
