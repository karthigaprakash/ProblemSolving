namespace Problem_Solving.ForEachLoop;

internal class Name
{
    public static void DisplayNamesByLetter(List<string> names, char letter)
    {
        Console.WriteLine($"\nNames starting with '{letter}':");

        foreach (string name in names)
        {
            if (name.StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(name);
            }
        }
    }
}
