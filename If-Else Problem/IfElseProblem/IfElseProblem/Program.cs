using Problem_Solving.ForEachLoop;
using Problem_Solving.Loop;
using ProblemSolving.Linq;
using ProblemSolving.Question;
using ProblemSolving.SampleProgram;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using static ProblemSolving.Linq.Size;

namespace ProblemSolving.Linq;

public class Program
{
    private static List<string>? letter;
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

        //3. Greatest Two Numbers

        //Console.WriteLine("Enter the value A:");
        //var result1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the value B:");
        //var result2 = Convert.ToInt32(Console.ReadLine());
        ////Console.WriteLine($"The value is : {Greatest.TwoValue(result1 + result2)}");
        //Console.WriteLine($"{Greatest.TwoValue(result1 , result2)}");

        //4. Greatest of Three Numbers

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

        //Loop
        //1.Sum of First N Numbers

        /*Console.Write("Enter a number: ");
        var n = Convert.ToInt32(Console.ReadLine());
        var result = Integer.CalculateSum(n);
        Console.WriteLine("Sum of numbers from 1 to " + n + " is: " + result);
        */

        //2.Factorial of a Number

        /*Console.Write("Enter a number: ");
       var n = Convert.ToInt32(Console.ReadLine());
       var result = Factorial.FactorialLoop(n);
       Console.WriteLine(n + "! = " + result);
       */

        //3. Multiplication Table

        /*Console.Write("Enter a number: ");
        var n = Convert.ToInt32(Console.ReadLine());
        Multiplication.Table(n);
        */

        //4. Count Even and Odd Numbers

        /*Console.Write("Enter a number: ");
        var n = Convert.ToInt32(Console.ReadLine());
        var result = EO.Checker(n); 
        Console.WriteLine("The number is " + result);
        */

        //5. Reverse a String

        /*Console.Write("Enter a string: ");
        var str = Console.ReadLine();
        Console.WriteLine($"{Reverse.Letter(str)}");
        */

        //6. Prime Numbers up to N

       //Console.Write("Enter n: ");
       //var n = Convert.ToInt32(Console.ReadLine());
       //Prime.ShowPrimes(n);

        //7.Fibonacci Series(First N Terms)

        /*
        Console.Write("Enter the number of Fibonacci terms: ");
        var n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"First {n} Fibonacci numbers:");
        Fibonacci.Series(n);
        */

        //8. Sum of Digits

        /*
       Console.Write("Enter an integer: ");
       var num = Convert.ToInt32(Console.ReadLine());
       var result = Sum.Calculate(num);
       Console.WriteLine("Sum of digits: " + result);
       */

        //9. Pattern Printing

       //Console.Write("Enter number of rows: ");
       //var n = Convert.ToInt32(Console.ReadLine());
       //Pattern.RightTriangle(n);
       

        //10. Power of a Number

        /*Console.Write("Enter x: ");
         var x = Convert.ToInt32(Console.ReadLine());
         Console.Write("Enter y: ");
         var y = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine($"{x}^{y} = {Power.PowerNumber(x, y)}");
         */

        //ForEachLoop

        //1. Sum of Numbers


        /*Console.Write("Enter numbers: ");
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Console.WriteLine("Sum = " + SumOfNumber.GetSum(nums));
        */

        //2. Maximum Element

        /*Console.Write("Enter numbers separated by space: ");
        var input = Console.ReadLine().Split(' ');
        var nums = Array.ConvertAll(input, int.Parse);
        var result = Max.MaxArray(nums);
        Console.WriteLine("Maximum element is: " + result);
        */

        //3. Count Even Numbers

        /*Console.Write("Enter numbers separated by space: ");
        var nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Console.WriteLine("Count of even numbers: " + Even.CountEven(nums));
        */

        //4. Print Characters

        /*
        Console.Write("Enter a string: ");
        var input = Console.ReadLine();
        Print.PrintChars(input);
        */

        //5. Reverse Each Word

        /*Console.Write("Enter a sentence: ");
       var sentence = Console.ReadLine();
       Reverses.Words(sentence);
       */

        //6. Sum of Digits in a String

        //Console.WriteLine("Enter a string containing letters and digits:");
        //var input = Console.ReadLine();
        //var sum = SumDigit.SumOfDigits(input);
        //Console.WriteLine("The sum of digits in the string is: " + sum);


        //7. Names Starting with a Specific Letter

        //8. Square of Numbers

        /*List<int> numbers = new List<int>() { 2, 4, 6, 8, 10 };
       Console.WriteLine("Squares of numbers:");
       Square.PrintSquares(numbers);
       */

        //9. Count Words in a Sentence

        /*
        Console.Write("Enter a sentence: ");
        var sentence = Console.ReadLine();
        Count.CountWords(sentence);
        */

        //10. Average of Array Elements

        //Console.Write("How many numbers do you want to enter? ");
        //var count = Convert.ToInt32(Console.ReadLine());

        //var numbers = new int[count];
        //for (int i = 0; i < count; i++)
        //{
        //    Console.Write($"Enter number {i + 1}: ");
        //    numbers[i] = Convert.ToInt32(Console.ReadLine());
        //}
        //Problem_Solving.ForEachLoop.Average.CalculateAverage(numbers);

        //Linq

        //1.Filter Even Numbers 

        //Console.WriteLine("Filter Even Numbers:");
        //Even.FilterEvenNumbers();

        //2.Sort Strings Alphabetically 

        //Console.WriteLine("Sort Alphabetically:");
        //Sort.Alphabetically();

        //3.Numbers Greater Than N 

        //Console.WriteLine("Numbers Greater Than N:");
        //Number.Greater();

        //4.Square of Numbers 

        //Console.WriteLine("Square of Numbers:");
        //Square.Numbers();

        //5.Distinct Elements 

        //Console.WriteLine("Distinct Elements");
        //Distinct.Elements();

        //6.Count Words Starting With Vowel 

        //Console.WriteLine("Count Words Starting With Vowel");
        //Count.Words();

        //7. Sum of Values Greater Than 10

        //Console.WriteLine("Numbers Greater Than 10:");
        //Value.Greater();

        //8.Average Word Length 

        //Console.WriteLine("Average Word Length");
        //Average.Word();

        //9.Maximum and Minimum 

        //Console.WriteLine("Maximum and Minimum");
        //DecimalVal.MaxMin();

        //10.Product of Numbers 

        //Console.WriteLine("Enter the Numbers");
        //Product.Value();

        //11.Select First Letters(word with , use it) 

        //Console.WriteLine("Enter the words");
        //First.Letters(letter);

        //12. Anonymous Objects for Pass/Fail

        //var students = new List<(string Name, int Mark)>();
        //Console.WriteLine("Enter the number of list of students : ");
        //var n = Convert.ToInt32(Console.ReadLine());

        //for (int i = 0; i < n; i++)
        //{
        //    Console.WriteLine("Enter the Name:");
        //    var name = Console.ReadLine();
        //    Console.WriteLine("Enter the Mark");
        //    var mark = Convert.ToInt32(Console.ReadLine());
        //    students.Add((name, mark));
        //}
        //Student.PassFail(students);

        //13.Index and Value Pair 
        //Console.WriteLine("Enter array elements :");
        //var arr = Console.ReadLine()
        //                .Split(',')
        //                .Select(s => s.Trim())
        //                .ToArray();
        //Index.Value(arr);

        //14.Uppercase Conversion

        //Console.WriteLine("Enter a sentence");
        //var name = Console.ReadLine()
        //                .Split(',')
        //                .Select(s => s.Trim())
        //                .ToList();
        //Upper.Conversion(name);

        //15.Word Length Pairs 

        //Console.WriteLine("Enter the sentence");
        //var arr = Console.ReadLine()
        //                .Split(',')
        //                .Select(s => s.Trim())
        //                .ToArray();
        //Pair.Word(arr);

        //16.Group by First Letter 

        //Console.WriteLine("Enter a Name ");
        //var word = Console.ReadLine()
        //                    .Split(',')
        //                    .Select(w => w.Trim())
        //                    .ToList();
        //Word.Letter(word);

        //17.Group and Count Cities 

        //Console.WriteLine("Enter the Cities name");
        //var word = Console.ReadLine()
        //                    .Split(',')
        //                    .Select(w => w.Trim())
        //                    .ToList();

        //Cities.Count(word);

        //18.Inner Join Students–Departments

        //Console.WriteLine("Enter the number of student list ?: ");
        //var n = Convert.ToInt32(Console.ReadLine());

        //for(int i =0; i < n; i++)
        //{
        //    Console.WriteLine("Enter the student Name:");
        //    var studentName = Console.ReadLine();
        //    Console.WriteLine("Enter the DeptId:");
        //    var deptId = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter the DeptName:");
        //    var deptName = Console.ReadLine();

        //    Perform.StuDep(studentName, deptId, deptName);
        //}

        //19.Left Outer Join Students–Departments 

        //Console.WriteLine("Enter the number of student list ?: ");
        //var n = Convert.ToInt32(Console.ReadLine());

        //for (int i = 0; i < n; i++)
        //{
        //    Console.WriteLine("Enter the student Name:");
        //    var studentName = Console.ReadLine();
        //    Console.WriteLine("Enter the DeptId:");
        //    var deptId = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter the DeptName:");
        //    var deptName = Console.ReadLine();

        //    List.StuDep(studentName, deptId, deptName);
        //}

        //20.Order Groups by Size

        //Console.WriteLine("Enter the number of employees: ");
        //var n = Convert.ToInt32(Console.ReadLine());

        //List<Employees> employees = new List<Employees>();

        //for (int i = 0; i < n; i++)
        //{
        //    Console.WriteLine("Enter the employee name:");
        //    var name = Console.ReadLine();

        //    Console.WriteLine("Enter the DeptId:");
        //    var deptId = Convert.ToInt32(Console.ReadLine());

        //    employees.Add(new Employees {Name = name, DepartmentId = deptId });
        //}

        //Employee(employees);

        //Console.ReadLine();


        //Question

        //1 

        //Question.DecimalVal.MaxMin();

        //2 

        //int number = 200;
        //for (int i = 1; i <= number; i++)
        //{
        //    Console.WriteLine(Question.Number.FizzBuzz(i));
        //}

        //3.Swapping

        //Console.WriteLine("Enter the Number 1 :");
        //var x = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter the Number 2 :");
        //var y = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine($"Before swap number is : a = {x} :b = {y}");
        //Swapping.GetTwoNumber(x, y);


        //4. Formula 
        //Console.WriteLine("Enter First Number :");
        //var x = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter Second Number :");
        //var y = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter Third Number :");
        //var z = Convert.ToInt32(Console.ReadLine());

        //Formula.GetThreeNumber(x,y,z);
    }
}


