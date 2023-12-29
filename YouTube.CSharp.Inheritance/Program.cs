//INHERITANCE


/*
Client CommunicationLtd = new Client();
CommunicationLtd.Title = "xxx";
CommunicationLtd.Address = "yyy";
CommunicationLtd.CustomerBalance = 55;

//base class
//derived class

lowerClass test = new lowerClass("hello");

class baseClass
{
    string text;
    public baseClass(string text)
    {
        this.text = text;

        Console.WriteLine(text);
    }
    public int MyPropertybase { get; set; }
}

class derivedClass : baseClass
{
    public derivedClass(string text) : base(text)
    {
       // Console.WriteLine("I am coming from derived class");
    }
    public int MyPropertyderived { get; set; }
}

class lowerClass : derivedClass
{
   public lowerClass(string text) : base(text)
    {
       // Console.WriteLine("I am coming from lower class");
    }

    public void test()
    {
        MyPropertybase = 1;
        MyPropertyderived = 2;
    }

}


public class Company
{
    public string Title { get; set; }
    public string Address { get; set; }
}

public class Client : Company
{   
    public int CustomerBalance { get; set; }
}


public class Supplier :Company
{   
    public int OurBalance { get; set; }

}

*/

Test t = new Test();
t.Method(); Console.WriteLine(t.Name);

class Example
{
    public virtual string Name { get; set; }

    public virtual void Method()
    {
        Console.WriteLine("Hello");
    }
}


sealed class Test : Example
{
    public override sealed void Method()
    {
        Console.WriteLine("Hello World I have ovveride base metod");
    }

    public override string Name { get { return "I have been changed by overriding"; } set => base.Name = value; }
}

//class DerivedClass : Test
//{
//    //public override void Method()
//    //{
//    //    base.Method();
//    //}
//}