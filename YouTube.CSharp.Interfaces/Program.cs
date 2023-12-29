//INTERFACES

//abstract data types
//smilarty with abstract classes
//uses signature of methods and props without access modifier
//inheritance is a must
//we can not create new object from an interface. but we can use polymorphism rules to create one
//inheritance can be used many times


/*

ITest test = new Test();
test.Method();

INewTest newTest = new Test();
newTest.NewMethod();

Test allMethods = new Test();
allMethods.MethodNormal();  


interface ITest
{
    void Method();

}

interface INewTest
{
    void NewMethod();
}

class NormalClass
{
    public void MethodNormal()
    {
        Console.WriteLine("i am normal class");
    }
}

class SecondClass
{

}

class Test :NormalClass, ITest , INewTest
{
    public void Method()
    {
        Console.WriteLine("test is still runnig");
    }

    public void NewMethod()
    {
        Console.WriteLine("new_test has been done");
    }
}

*/

IInt1 test1 = new A();


interface IInt1
{
    void x();
    void y();
    void z();
}

interface IInt2
{
    void x();
    void m();
    void n();
}

class A : IInt1, IInt2
{
    void IInt2.m()
    {
        throw new NotImplementedException();
    }

    void IInt2.n()
    {
        throw new NotImplementedException();
    }

    void IInt1.x()
    {
        throw new NotImplementedException();
    }

    void IInt2.x()
    {
        throw new NotImplementedException();
    }

    void IInt1.y()
    {
        throw new NotImplementedException();
    }

    void IInt1.z()
    {
        throw new NotImplementedException();
    }
}