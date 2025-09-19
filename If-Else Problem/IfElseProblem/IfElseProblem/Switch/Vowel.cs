namespace ProblemSolving.SampleProgram;

internal class Vowel
{
    public static string Consonant(string letter)
    {
        switch (letter)
        {
            case "a":
            case "e":
            case "i":
            case "o":
            case "u":
                return "It is a Vowel";
            default:
                return "It is a Consonant";
        }
    }
}
