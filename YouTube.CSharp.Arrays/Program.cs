//ARRAYS

//Single Dimension Array

string student1 = "Michael";
string student2 = "Bob";
string student3 = "Amanda";

string[] students = new string[3] { "Michael", "Bob", "Amanda" };

string[] teachers = { "George", "Hasan" };

string[] management = new string[2];
management[0] = "Bobby";
management[1] = "Shirley";

Console.WriteLine($@"
Student name is {students[1]}
Teacher name is {teachers[0]}
Management name is {management[1]}
");

students[1] = "Gordon";
teachers[0] = "Elizabeth";
management[1] = "Tony";

Console.WriteLine($@"
Student name is {students[1]}
Teacher name is {teachers[0]}
Management name is {management[1]}
");

//Two Dimensions Array

string[,] listOfStudentList = new string[2, 3]
{
    {"Michael","Bob","Amanda" },
    {"Catherine","Josh","Kimberley" }
};

Console.WriteLine($@"
Third Student name from first list is {listOfStudentList[0,2]}
First Student name from second list is {listOfStudentList[1,0]}
");

listOfStudentList[0, 2] = "Hasan";

Console.WriteLine($@"
Third Student name from first list is {listOfStudentList[0, 2]}
First Student name from second list is {listOfStudentList[1, 0]}
");