namespace Problem_Solving.ForEachLoop;

internal class Square
{
    public static void PrintSquares(List<int> numbers)
    {
        foreach (int num in numbers)
        {
            int square = num * num;
            Console.WriteLine($"{num} squared = {square}");
        }
    }
}
