//METHODS

//Void Methods
//Return Methods with parameters
//Methods with Ref and Out Keywords
//Method Overloading
//Params in methods

//Void Methods
/*
using System.Numerics;

Intro();//lesson1
Intro();
Intro();
Intro();
Intro();
Intro();
Intro();
Intro();//lesson 7
Intro();
Intro();
Intro();
Intro();


void Intro()
{
    Console.WriteLine("Hi, Welcome to my Lessons.");
}


//Return Methods with parameters

var result = Multiply(25,2);
Console.WriteLine(result);

int Multiply(int numberOne, int numberTwo)
{
    int result = numberOne * numberTwo;
    return result;
}


int numberOne = 55;
long numberTwo = 15;

var resultTwo = Subtraction(numberOne, numberTwo);
Console.WriteLine(resultTwo);

int Subtraction(int numberOne, long numberTwo)
{
    var result = numberOne - numberTwo;
    return (int)result;
}


//Methods with Ref and Out Keywords

int numberOne = 55;
long numberTwo = 15;

var resultTwo = Subtraction(ref numberOne, numberTwo);
Console.WriteLine(resultTwo);
Console.WriteLine(numberOne);

int Subtraction(ref int x, long y)
{
    x = 125;
    var result = x - y;
    return (int)result;
}

int numberThree;
long numberFour = 15;

var resultThree = Addition(out numberThree, numberFour);
Console.WriteLine(resultThree);
Console.WriteLine(numberThree);

int Addition(out int x, long y)
{
    x = 125;
    var result = x + y;
    return (int)result;
}


//Method Overloading

int numberThree = 55;
long numberFour = 15;

var resultFour = Methods.Addition(numberThree, numberFour, 55);
Console.WriteLine(resultFour);

Console.WriteLine(Methods.Addition(numberThree));


static class Methods
{
    public static int Addition(int x, long y = 95)
    {
        var result = x + y;
        return (int)result;
    }

    public static int Addition(int x, long y, int z)
    {
        var result = x + y + z;
        return (int)result;
    }

    public static int Addition(int x, long y, int z, int k)
    {
        var result = x + y + z + k;
        return (int)result;
    }

}
*/

//Params in methods
int numberOne = 55;
long numberTwo = 15;


var resultTwo = Addition(5, 10, 45, 12);
Console.WriteLine(resultTwo);

int Addition(params int[] numbers)
{
    return numbers.Sum();
}