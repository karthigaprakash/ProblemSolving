namespace ProblemSolving.Question;

internal class Formula
{
    public static void GetThreeNumber(int number1, int number2, int number3)
    {
        Console.Write("Result (x+y).z is {3} and x.y + y.z is {4}",
            number1, number2, number3,
            (
            (number1 + number2) * number3),
            (number1 * number2 + number2 * number3)
            );
    }
}
