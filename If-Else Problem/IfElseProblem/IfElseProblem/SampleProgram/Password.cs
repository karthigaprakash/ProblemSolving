namespace ProblemSolving.SampleProgram;

internal class Password
{
    public static string Checker(string password)
    {
        if (password.Length < 6)
        {
            return "Password Strength: Weak";
        }
        else
        {
            if (password.Any(char.IsDigit) && password.Any(char.IsLetter))
            {
                if (password.Any(c => !char.IsLetterOrDigit(c)))
                {
                    return "Strong";
                }
                else
                {
                    return "Medium";
                }
            }
            else
            {
                return "weak";
            }
        }
    }
}