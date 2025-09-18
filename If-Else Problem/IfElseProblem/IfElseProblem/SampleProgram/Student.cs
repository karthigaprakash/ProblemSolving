namespace ProblemSolving.SampleProgram
{
    internal class Student
    {
        public static int Result(int num1 ,string operation)
        {
            if(operation == "+")
            {
                return num1 ;
            }
            else if(operation == "-")
            {
                return num1;
            }
            else if (operation == "*")
            {
                return num1 ;
            }
            else if (operation =="/")
            {
                return num1;
            }
            else
            {
                return 0;
            }
        }
    }
}
