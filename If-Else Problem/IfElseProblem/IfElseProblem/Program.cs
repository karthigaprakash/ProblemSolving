namespace ProblemSolving.SampleProgram;

public class Program
{
    public static void Main(string[] args)
    {
        //1.Even or Odd

        //Console.WriteLine("Enter the values:");
        //var result = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"Number is :{EvenOdd.EvenOrOdd(result)}");

        //2. Positive, Negative, or Zero

        //Console.WriteLine("Enter the values:");
        //var result = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"Value is : {PosNeg.CheckSign(result)}");

        //3. Greatest Two Numbers - wrong

        //Console.WriteLine("Enter the value A:");
        //var result1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the value B:");
        //var result2 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"The value is : {Greatest.TwoValue(result1 + result2)}");

        //4. Greatest of Three Numbers - wrong

        //Console.WriteLine("Enter the value A:");
        //var result1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the Value B:");
        //var result2 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the value c:");
        //var result3 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"{Largest.ThreeValue(result1, result2, result3)} The Largest value.");

        //5.. Voting Eligibility

        //Console.WriteLine("Enter your age:");
        //var result = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"You have {Eligibility.Voting(result)} for the vote");

        //6 Grade Calculator

        //Console.WriteLine("Enter the your subject 1 mark:");
        //var result1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the your subject 2 mark:");
        //var result2 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the your subject 3 mark:");
        //var result3 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"Your grade is {Grade.Calculator(result1)}");

        //7  Leap Year Check

        //Console.WriteLine("Enter the Year:");
        //var result = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"The year is {Leap.Check(result)}");

        //8  Simple Calculator

        Console.WriteLine("Enter the value 1:");
        var result1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value 2");
        var result2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the operator (+, -, *, /):");
        var operation = Console.ReadLine();
        Console.WriteLine($"{Simple.Calculation(result1, result2, operation)}");

        //Console.WriteLine("Enter the value 1:");
        //var result1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the value 2");
        //var result2 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the value 3");
        //var result3 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the value 4");
        //var result4 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the value 5");
        //var result5 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the operator (+, -, *, /):");
        //var operation = Console.ReadLine();
        //Console.WriteLine($"{Student.Result(result1, operation)}");

    }
}

