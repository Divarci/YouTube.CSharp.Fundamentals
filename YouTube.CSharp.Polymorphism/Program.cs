//POLYMORPHISM

/*
A test = new A();
B test2 = new B();

A test3 = new B();

int number = "string";


class A
{

}

class B
{

}

*/

BaseClass test = new DerivedClass();
test.baseProp = 6;

DerivedClass newclass = (DerivedClass)test;



BaseClass bc = new();
bc.baseProp = 2;

DerivedClass dc = new();
dc.baseProp = 5;
dc.derivedProp = 3;

class BaseClass
{
    public int baseProp { get; set; }
}

class DerivedClass: BaseClass
{
    public int derivedProp { get; set; }
}