namespace ProblemSolving.SampleProgram;

internal class Currency
{
    public static string Converter(int option, double inr)
    {
        switch (option)
        {
            case 1:
                return $"USD:{inr / 88}";
            case 2:
                return $"EUR:{inr / 103.53}";
            case 3:
                return $"GBP: {inr / 118.73}";
            default:
                return "Invalid option";
        }
    }
}
