namespace ProblemSolving.SampleProgram;

internal class Traffic
{
    public static string TrafficLight(string color)
    {
        switch (color)
        {
            case "red":
                return "Stop";
            case "yellow":
                return "Get Ready";
            case "green":
                return "Go";
            default:
                return "Invalid color";
        }
    }
}
