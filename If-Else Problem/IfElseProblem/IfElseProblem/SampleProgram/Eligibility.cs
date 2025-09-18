namespace ProblemSolving.SampleProgram
{
    internal class Eligibility
    {
        public static string Voting(int number)
        {

            if (number >= 18)
            {
                return "eligible";
            }
            else
            {
                return "non-Eligible";
            }
        }
    }
}
