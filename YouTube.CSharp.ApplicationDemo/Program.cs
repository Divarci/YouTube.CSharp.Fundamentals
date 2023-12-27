Console.WriteLine($@"
   WELCOME TO MR.AMAZING CALCULATOR
--------------------------------------
Please Choose One of Following Options

1-Grade Calculator
2-Expense Calculator

");


var selection = UserEntryForSelection();

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
            var examFirst = UserEntry("Exam 1: ");
            var examSecond = UserEntry("Exam 2: ");
            var examThird = UserEntry("Exam 3: ");

            averageResult = (examFirst + examSecond + examThird) / 3;

            Console.WriteLine(@$".......................
The Average Of Three Exam is {averageResult}");
        }

        GradeCalculator(averageResult);

        break;
    case "2":

        int[] pricesOfItems = { 125, 35, 36, 3, 1 };
        int totalCostForEachStudent = 0;

        foreach (int item in pricesOfItems)
            totalCostForEachStudent += item;

        var studentQuantity = StudentNumberEntry();
        int totalCost = totalCostForEachStudent * studentQuantity;

        Console.WriteLine($@"
.....................
Total COST to school this year: £{totalCost}
");

        break;
    default:
        Console.WriteLine("There is an error!!");
        break;
}


int UserEntry(string title)
{
    int examResult = 0;
    bool condition;
    do
    {
        Console.Write(title);
        string userEntry = Console.ReadLine()!;
        if (!string.IsNullOrEmpty(userEntry) && !string.IsNullOrWhiteSpace(userEntry) && int.TryParse(userEntry, out examResult) && examResult >= 0 && examResult <= 100)
        {
            condition = false;
            break;
        }
        Console.WriteLine("\nPlease ENTER a valid value");
        condition = true;

    } while (condition);
    return examResult;
}

string UserEntryForSelection()
{
    string selection;
    bool condition;
    do
    {
        Console.Write("Selection: ");
        selection = Console.ReadLine()!;
        if (!string.IsNullOrEmpty(selection) && !string.IsNullOrWhiteSpace(selection) && selection == "1" || selection == "2")
        {
            condition = false;
            break;
        }
        Console.WriteLine("\nPlease SELECT 1 or 2");
        condition = true;
    } while (condition);
    return selection;
}

void GradeCalculator(int averageResult)
{
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
}

int StudentNumberEntry()
{
    int studentQuantity = 0;
    bool condition;
    do
    {
        Console.Write("How many student is registered :");
        string userEntry = Console.ReadLine()!;
        if (!string.IsNullOrEmpty(userEntry) && !string.IsNullOrWhiteSpace(userEntry) && int.TryParse(userEntry, out studentQuantity))
        {
            condition = false;
            break;
        }
        Console.WriteLine("\nPlease ENTER a valid value");
        condition = true;

    } while (condition);
    return studentQuantity;
}
