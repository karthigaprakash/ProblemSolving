namespace ProblemSolving.SampleProgram;

internal class EvenOdd
{
    public static string EvenOrOdd(int number)
    {
        //if (number % 2 == 0)
        //{
        //    return "Even";
        //}
        //else
        //{
        //    return "Odd";
        //}

        return (number % 2 == 0) ? "Even Number" : "Odd Number";
    }
}
