namespace ProblemSolving.SampleProgram;

internal class Leap
{
    public static string Check(int num)
    {
        if ((num % 4 == 0 && num % 100 !=0) || (num % 400 == 0))
        {
            return "Leap";
        }
        else
        {
            return "Not-Leap";
        }
    }
}
