namespace ProblemSolving.Question;

internal class Swapping 
{
    public static void GetTwoNumber(int x , int y)
    {
        int swap = x;
        x = y;
        y = swap;

        Console.WriteLine($"After swap number : a = {x}, b = {y}");
    }
}
    