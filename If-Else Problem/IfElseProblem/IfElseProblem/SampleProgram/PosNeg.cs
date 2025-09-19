namespace ProblemSolving.SampleProgram;

internal class PosNeg
{
    public static string CheckSign(int number)
    {
        if (number > 0)
        {
            return "Postivie";
        }
        else if (number < 0) 
        {
            return "Negative";
        }
        else
        {
            return "Zero";
        }
    }
}
