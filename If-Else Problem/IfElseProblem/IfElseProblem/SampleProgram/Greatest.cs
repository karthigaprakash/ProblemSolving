namespace ProblemSolving.SampleProgram;

internal class Greatest
{
    public static string TwoValue(int number)
    {
        //if (number < 10)   
        //{
        //    return "Smaller";
        //}
        //else if(number >= 11 && number <= 99)  
        //{
        //    return "Greater";
        //}
        //else
        //{
        //    return "More"; 
        //}

        return (number < 10) ? "Smaller Number" : 
               (number >= 11 && number <= 99) ? "Greater Number" : "More";
    }
}
