//GENERICS

/*
Example test = new Example(2);
var result = test.Method(56);
Console.WriteLine(result);




class Example
{
    int _number;

    public Example(int number)
    {
        _number = number;
    }

    public int Method(int number)
    {
        return _number*number;
    }


}
*/

/*
GenericClass<Normal,A,D> test = new GenericClass<Normal, A, D> ();
test.Method();



class GenericClass<Type, Type2, Type3> where Type : class,new() where Type2 : class,new() where Type3 : class,new()
{
    Type test;
    Type2 test2;
    Type3 test3;

    public void Method()
    {
       test = new Type();
       test2 = new Type2();
       test3 = new Type3();
    }


}

class Normal
{

}

class A
{

}

class B : A
{


}

class C : B
{

}

class D
{

}

*/


GenericClassNew<string> newGeneric = new GenericClassNew<string>();
newGeneric.Value = "Hello, World";
Console.WriteLine(newGeneric.Value);

GenericClassNew<int> newGeneric2 = new GenericClassNew<int>();
newGeneric2.Value = 1;
Console.WriteLine(newGeneric2.Value);

GenericClassNew<List<string>> test = new GenericClassNew<List<string>>();
test.Value = new List<string> { "a", "b", "c" };
foreach (string s in test.Value)
{
    Console.WriteLine(s);
}

class GenericClassNew<Type>
{
    private Type _value;

    public Type Value
    {
        get { return _value; }
        set { _value = value; }
    }

}