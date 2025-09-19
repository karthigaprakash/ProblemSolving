namespace ProblemSolving.SampleProgram;

internal class Menu
{
    public static string Operation(int num1, int num2, string op)
    {

        switch (op)
        {
            case "1":
                return $"{num1} + {num2} = {num1 + num2}";
            case "2":
                return $"{num1} - {num2} = {num1 - num2}";
            case "3":
                return $"{num1} * {num2} = {num1 * num2}";
            case "4":
                return $"{num1} / {num2} = {num1 / num2}";
            default:
                return "Invalid operator";
        }
    }
}
