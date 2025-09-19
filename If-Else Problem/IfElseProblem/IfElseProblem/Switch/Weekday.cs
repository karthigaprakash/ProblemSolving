namespace ProblemSolving.SampleProgram;

internal class Weekday
{
    public static string WeekdayOrWeekend(string day)
    {
        switch (day)
        {
            case "monday":
            case "tuesday":
            case "wednesday":
            case "thursday":
            case "friday":
                return "Weekday";
            case "saturday":
            case "sunday":
                return "Weekend";
            default: return "Invalid day";
        }
    }
}
