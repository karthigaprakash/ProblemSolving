namespace Problem_Solving.Loop;

internal class Power  
{
    public static int PowerNumber(int x, int y)
    {
        int result =1 ;
        for (int i = 0; i < y; i++) result *= x;
        return result;
    }
}

