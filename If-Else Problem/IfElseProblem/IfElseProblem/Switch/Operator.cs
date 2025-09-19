namespace ProblemSolving.SampleProgram;

internal class Operator
{
    public static string Calculator(int num1,int num2,string op)
    {
        switch (op)
        {
            case "+": 
                return $"{num1} + {num2} = {num1 + num2}";
            case "-": 
                return $"{num1} - {num2} = {num1 - num2}";
            case "*": 
                return $"{num1} * {num2} = {num1 * num2}";
            case "/": 
                return $"{num1} / {num2} = {num1 / num2}";
            default: 
                return "Invalid operator";
        }
    }
}
