namespace ProblemSolving.Question;

internal class Compare 
{
    public static string GetThreeNumbers(int num1, int num2, int num3)
    {
        return (num1 == num2 && num2 == num3) ? "Three Numbers are Same" :
               (num1 == num2 && num2 != num3) ? "Two Numbers are Same" : 
               (num1 != num2 && num2 == num3) ? "Two Numbers are Same" : "Not Same";
    }
}
