namespace ProblemSolving.Question;

internal class Number
{
    public static string FizzBuzz(int number)
    {
        if (number % 3 == 0 && number % 5 == 0)
        {
            return "FizzBuzz";
        }
        else if (number % 3 == 0)
        {
            return "Fizz";
        }
        else if (number % 5 == 0)
        {
            return "Buzz";
        }
        else
        {
            return number.ToString();
        }
    }
}





//Console.WriteLine("Enter the number: ");
//var n = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < n; i++)
//{
//    Console.WriteLine("Enter the Number:");
//    var number = Console.ReadLine();
//}
