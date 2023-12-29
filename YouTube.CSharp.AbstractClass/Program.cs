// ABSTRACT CLASS

//How to...

/*
NormalClass test = new NormalClass();

class NormalClass
{

}

abstract class AbstractClass
{
    //use all features with normal class except creating new object
    //abstract class has its own features
}
*/

//why can not create....

//Example test2 = new Example();

/*
abstract class Example
{
    public int number;
    public int MyProperty { get; set; }
    void MethodNormal() { }
    public virtual void MethodVirtual() { }

    public abstract void MethodAbstract();
    public abstract int MyProperty1 { get; set; }
}

class TestClass : Example
{
    private int number;
    public override int MyProperty1 { get => number; set => number = value+5; }

    public override void MethodAbstract()
    {
        Console.WriteLine("i am coming from abstract");
    }

    public override void MethodVirtual()
    {
        base.MethodVirtual();
    }
}

*/

//real example

/*
Product marble = new Product();
marble.Title = "Marble";
marble.CreateTime = DateTime.Now;
Console.WriteLine(marble.Title);
Console.WriteLine(marble.CreateTime);
marble.Add();
marble.Remove();

Console.WriteLine("***********");

Client SunLtd = new Client();
SunLtd.Title = "SunLtd";
SunLtd.CreateTime = DateTime.Now;
Console.WriteLine(SunLtd.Title);
Console.WriteLine(SunLtd.CreateTime);
SunLtd.Add();
SunLtd.Remove();

abstract class Service
{
    public void Remove()
    {
        Console.WriteLine( "Data is removed");
    }

    public DateTime CreateTime { get; set; }

    public abstract void Add();
    public abstract string Title { get; set; }
}

class Product : Service
{
    private string _title;
    public override string Title { get => _title; set => _title = value.ToUpper(); }

    public override void Add()
    {
        Console.WriteLine("Product is added");
    }
}

class Client : Service
{
    private string _title;

    public override string Title { get => _title; set => _title = value.ToLower(); }

    public override void Add()
    {
        Console.WriteLine("Client is added");
    }
}

class Supplier : Service
{
    public override string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override void Add()
    {
        throw new NotImplementedException();
    }
}
*/

//real example two

Client client = new Client();
Supplier supplier = new Supplier();

//Company company = new Company();

abstract class Company
{
    public virtual int Id { get; set; }
    public virtual string Title { get; set; }
}

class Client : Company
{
    public int ClientBalance { get; set; }
    public override string Title { get => base.Title; set => base.Title = value; }
}

class Supplier : Company
{
    public int SupplierBalance { get; set; }

}