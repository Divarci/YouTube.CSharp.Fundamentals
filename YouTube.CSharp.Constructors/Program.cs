//CONSTRUCTOR

//Default constructor
//Parameterized Constructor
//Copy Constructor
//Static Constructor
//Private Constructor




//Example test = new Example("test test test");

//Console.WriteLine(test._text);
//Console.WriteLine(test._cost);
//Console.WriteLine(test._condition);
Example example = new();
Example example2 = new();
Example example3 = new();
Example example4 = new();


//Example test2 = new Example(15);
//test2._text = "just testing";
//Console.WriteLine(test2._cost);

//Example copyOftest2 = new Example(test2);
//Console.WriteLine(copyOftest2._cost);
//Console.WriteLine(copyOftest2._text);

class Example
{
    public int _cost;
    public string _text;
    public bool _condition;

    static Example()
    {
        Console.WriteLine("I am coming from Static Constructor.");
    }

    public Example()
    {
        Console.WriteLine("I am coming from Default Constructor.");
    }

    private Example(string text)
    {
        _cost = 25;
        _text = text;
    }

    public Example(int cost)
    {
        _cost = cost;
    }
    public Example(Example exampleClass)
    {
        _cost = exampleClass._cost;
        _text = exampleClass._text;
        _condition = exampleClass._condition;
    }



}

// access modifier must be public
// name of cons. must be the same exactly with the name of class
// there is no return.

