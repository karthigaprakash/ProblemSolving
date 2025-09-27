namespace Problem_Solving.Loop;

internal class Reverse 
{
    public static string Letter(string s)
    {
        string result = "";
        for (int i = s.Length - 1; i >= 0; i--)
        {
            result += s[i];
        }
        return result;
    }
}

