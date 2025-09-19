namespace ProblemSolving.SampleProgram;

internal class Electricity
{
    public static string Bill(int num)
    {
        switch (num)
        {
            case 1:
                return "Domestic";
            case 2:
                return "Commercial";
            case 3:
                return "Industrial";
            default: 
                return "Invalid type";
        }
    }
}
