Console.WriteLine($@"
   WELCOME TO MR.AMAZING CALCULATOR
--------------------------------------
Please Choose One of Following Options

1-Grade Calculator
2-Expense Calculator

");

Console.Write("Selection: ");
string selection = Console.ReadLine();

switch (selection)
{
    case "1":

        Console.WriteLine($@"
GRADE CALCULATOR FOR STUDENTS
-----------------------------
");
        Console.Write("Student Name: ");
        string studentName = Console.ReadLine();
        int averageResult;

        if (string.IsNullOrEmpty(studentName) || string.IsNullOrWhiteSpace(studentName))
        {
            averageResult = 1;
        }
        else
        {
            Console.Write("Exam 1 : ");
            string examFirst = Console.ReadLine();

            Console.Write("Exam 2 : ");
            string examSecond = Console.ReadLine();

            Console.Write("Exam 3 : ");
            string examThird = Console.ReadLine();

            averageResult = (int.Parse(examFirst) + int.Parse(examSecond) + int.Parse(examThird)) / 3;

            Console.WriteLine(@$".......................
The Average Of Three Exam is {averageResult}");
        }
        if (averageResult > 100)
            Console.WriteLine("Teacher made a mistake");
        if (averageResult <= 100 & averageResult >= 85)
            Console.WriteLine("Grade is Perfect Pass");
        if (averageResult < 85 && averageResult >= 70)
            Console.WriteLine("Grade is Pass");
        if (averageResult < 70 && averageResult >= 55)
            Console.WriteLine("Grade is Pass but student must study harder");
        if (averageResult < 55 && averageResult >= 45)
            Console.WriteLine("Grade is Pass with the condition(Student must have Perfect Pass Next Year). ");
        if (averageResult < 45 && averageResult > 1)
            Console.WriteLine("Grade is FAILED");
        if (averageResult == 1)
            Console.WriteLine("Student forgot to write his/her name");
        if (averageResult < 0)
            Console.WriteLine("There is an error!!");

        break;
    case "2":

        int priceOfUniform = 125;
        int priceOfBag = 35;
        int priceOfBooks = 36;
        int priceOfPen = 3;
        int priceOfEraser = 1;

        Console.Write("How many student is registered :");
        int studentNumber = int.Parse(Console.ReadLine());

        int totalCostForEachStudent = priceOfUniform + priceOfBag + priceOfBooks + priceOfPen + priceOfEraser;
        int totalCost = totalCostForEachStudent * studentNumber;

        Console.WriteLine($@"
.....................
Total COST to school this year: £{totalCost}
");

        break;
    default:
        Console.WriteLine("There is an error!!");
        break;
}
