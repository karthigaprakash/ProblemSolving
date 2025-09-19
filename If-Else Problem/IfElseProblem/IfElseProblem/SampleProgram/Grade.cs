namespace ProblemSolving.SampleProgram;

internal class Grade
{
    public static string Calculator(int number)
    {
        if (number >= 90 && number < 100)
        {
            return "A";
        }
        else if (number >= 75 && number <= 89)
        {
            return "B";
        }
        else if (number >= 50 && number <= 74)
        {
            return "C";
        }
        else
        {
            return "Fail";
        }
    }
}
