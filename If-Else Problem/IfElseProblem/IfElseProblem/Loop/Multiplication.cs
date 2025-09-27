namespace Problem_Solving.Loop;

internal class Multiplication
{
    public static void Table(int n)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(n + " x " + i + " = " + (n * i));
        }
    }
}

