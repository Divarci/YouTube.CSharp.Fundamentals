// EXCEPTION HANDLE



using YouTube.CSharp.ExceptionHandle;

try
{
    Console.Write("Select :");
    var userEntry = Console.ReadLine();
    if(userEntry == "1")
    {

        string[] students = new string[3] { "Michael", "Bob", "Amanda" };
        students[3] = "Bobby";
    }
    else if(userEntry == "2")
    {
        throw new NotImplementedException();
    }
    else if(userEntry == "3")
    {

        throw new CustomDivideByZero("ERROR", new CustomException("You can not divide by zero"));
    }
    else if (userEntry == "4")
    {
        throw new CustomException("I am coming from my custom exception constructor");
    }
    else
    {
        throw new Exception();
    }

}
catch (Exception ex)
{
    var message = HandleExceptions(ex);
    
    Console.WriteLine(message);
    Console.ReadLine();
}

string HandleExceptions(Exception x)
{
    

    var choosenException = x switch
    {
        CustomDivideByZero => $"Message: {x.Message} Inner Message: {x.InnerException!.Message}",
        NotImplementedException => "I have created by manually",
        IndexOutOfRangeException => "You can not add a nee customer",
        CustomException => x.Message,
        _ => "There is an unknown error"

    };

    return choosenException;
}
