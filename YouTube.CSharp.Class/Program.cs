//CLASS

//Definition
//Fields and Properties
//Partial Class


using YouTube.CSharp.Class;

Example test = new Example();
//refence    // real object

Example.SubExample subClass = new Example.SubExample();
subClass.test = 5;


School elementary = new School();
//elementary.name = "High Way Elemantary School";
//Console.WriteLine(elementary.name);

elementary.Name = "high way elementary school";
Console.WriteLine(elementary.Name);
Console.WriteLine(elementary.Cost);

Product product = new Product();
product.Name = "Marble";
product.Cost = 5;
Console.WriteLine(product.Name);
Console.WriteLine(product.Cost);
product.Add();
product.Remove();

class Example
{
    public string name;
    public string Name { get; set; }

    public Example() { }

    public void Method() { }

    public class SubExample
    {
        public int test;
    }
}


//Fields and Properties



class School
{
    private string name;

    public string Name
    {
        get { return name.ToUpper(); }
        set { name = value; }
    }

    public int Cost { get; set; } = 2000000;
}

