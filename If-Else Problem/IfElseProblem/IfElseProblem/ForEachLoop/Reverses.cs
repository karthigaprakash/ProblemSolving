namespace Problem_Solving.ForEachLoop;

internal class Reverses
{
    public static void Words(string sentence)
    {
        foreach (string word in sentence.Split(' '))
        {
            char[] rev = new char[word.Length];
            int i = 0;
            foreach (char c in word)
                rev[word.Length - 1 - i++] = c;
            Console.WriteLine(new string(rev));
        }
    }
}
