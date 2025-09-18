namespace ProblemSolving.SampleProgram
{
    internal class Simple
    {
        public static int Calculation(int num1 , int num2, string operation)
        {
            if(operation == "+")
            {
                return num1 + num2;
            }
            else if(operation == "-")
            {
                return num1 - num2;
            }
            else if (operation == "*")
            {
                return num1 * num2;
            }
            else if (operation =="/")
            {
                return num1 / num2;
            }
            else
            {
                return 0;
            }
        }
    }
}
