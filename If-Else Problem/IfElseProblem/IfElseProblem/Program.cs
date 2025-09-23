using ProblemSolving.Linq;
using System.Diagnostics.Metrics;

namespace ProblemSolving.Linq;

public class Program
{
    public static void Main(string[] args)
    {

        //If else 
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

        //Console.WriteLine("Enter the value 1:");
        //var result1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the value 2");
        //var result2 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the operator (+, -, *, /):");
        //var operation = Console.ReadLine();
        //Console.WriteLine($"{Simple.Calculation(result1, result2, operation)}");

        //9.  Password Strength

        //Console.WriteLine("Enter your password");
        //var password = Console.ReadLine();
        //Console.WriteLine($"{Password.Checker(password)}");


        //10 Student Result

        //for (int i = 1; i <= 5; i++)
        //{
        //    Console.Write($"Enter marks for subject {i}: ");
        //    var result = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine($"{Student.GetResult(result)}");
        //}

        //Switch
        //1. Day of the Week

        //Console.Write("Enter number (1-7) for day: ");
        //int day = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"{DayOfWeekProgram.Day(day)}");


        //2. Calculator Take two numbers

        //Console.Write("Enter first number: ");
        //var result1 = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Enter second number: ");
        //var result2 = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Enter operator (+, -, *, /): ");
        //var op = Console.ReadLine();
        //Console.WriteLine($"{Operator.Calculator(result1, result2, op)}");

        //3. Month Days Input a month number

        //Console.Write("Enter month number (1-12): ");
        //var month = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"{Month.MonthDays(month)}");

        //4. Grade System

        //Console.Write("Enter grade letter (A-F): ");
        //var grade = Console.ReadLine();
        //Console.WriteLine($"{Grades.GradeSystem(grade)}");

        //5. Traffic Light Input

        //Console.Write("Enter traffic light color (Red, Yellow, Green):");
        //var color = Console.ReadLine().ToLower();
        //Console.WriteLine($"{Traffic.TrafficLight(color)}");

        //6.Simple Menu Program

        //Console.WriteLine("The Menu 1.Add 2. Subtract 3. Multiply  4. Divide");
        //Console.Write("Choose the option: ");
        //var op = Console.ReadLine();
        //Console.Write("Enter first number: ");
        //var result1 = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Enter second number: ");
        //var result2 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"{Menu.Operation(result1, result2, op)}");

        //7. Weekday or Weekend

        //Console.Write("Enter day name: ");
        //var day = Console.ReadLine().ToLower();
        //Console.WriteLine($"{Weekday.WeekdayOrWeekend(day)}");

        //8. Electricity Bill

        //Console.Write("Enter electricity bill number: ");
        //var bill = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"{Electricity.Bill(bill)}");

        //9. Vowel or Consonant

        //Console.Write("Enter a character: ");
        //var letter = Console.ReadLine();
        //Console.WriteLine($"{Vowel.Consonant(letter)}");

        //10. Currency Converter

        //Console.WriteLine("Currency Menu: 1. INR to USD 2. INR to EUR 3. INR to GBP");
        //Console.Write("Choose option: ");
        //var option = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Enter amount in INR: ");
        //var inr = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine($"{Currency.Converter(option, inr)}");

        //Linq

        //1.Filter Even Numbers 

        //Console.WriteLine("Enter integers separated by space (Filter Even Numbers):");
        //Even.FilterEvenNumbers();

        //2.Sort Strings Alphabetically 

        //Console.WriteLine("Enter words separated by space (Sort Alphabetically):");
        //Sort.Alphabetically();

        //3.Numbers Greater Than N 

        //Console.WriteLine("Enter integers separated by space (Numbers Greater Than N):");
        //Number.Greater();

        //4.Square of Numbers 

        //Console.WriteLine("Enter integers separated by space (Square of Numbers):");
        //Square.Numbers();

        //5.Distinct Elements 

        //Console.WriteLine("Enter integers separated by space (Distinct Elements)");
        //Distinct.Elements();

        //6.Count Words Starting With Vowel 

        //Console.WriteLine("Enter words separated by space (Count Words Starting With Vowel )");
        //Count.Words();

        //7. Sum of Values Greater Than 10

        //Console.WriteLine("Enter integers separated by space (Numbers Greater Than 10):");
        //Value.Greater();

        //8.Average Word Length 

        // One kind of mistake in the program (Length)
        //Console.WriteLine("Enter word separated by space(Average Word Length)");
        //Average.Word();

        //9.Maximum and Minimum 

        //Console.WriteLine("Enter integers separeted by space (Maximum and Minimum)");
        //DecimalVal.MaxMin();

        //10.Product of Numbers 

        //Console.WriteLine("Enter integers separeted by space (Product of Numbers)");
        //Product.Value();

        //11.Select First Letters 
        // One kind of mistake in the program (Not apply the index value 0 )

        Console.WriteLine("Enter word separated by space (Select First Letters)");
        Test.Letters();
    }
}

