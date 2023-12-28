// STATIC CLASS-METHOD-PROPERTY


//Example test = new Example();
//test.Method();

Example.Method();
Example.Name = "Test";
Console.WriteLine(Example.Name);


static class Example
{
    public static string Name { get; set; }

    public static void Method()
    {
        Console.WriteLine( " I am a method");
    }
}