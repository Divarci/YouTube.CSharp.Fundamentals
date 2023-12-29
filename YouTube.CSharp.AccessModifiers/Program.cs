//ACCESS MODIFIERS
Service test = new Service();
test.Add();
//test.Update();
//test.Remove();
test.GetList();
test.Select();



public class Service
{
    public void Add() { }
    private void Update() { }
    protected void Remove() { }
    protected internal void GetList() { }
    internal void Select() { }



    private void TestMethod()
    {
        Add();
        Update();
        Remove();
        GetList();
        Select();
    }
}



class Example : Service
{
    public void MethodIntherit()
    {
        Add();
      //Update();
        Remove();
        GetList();
        Select();

    }

}


class ExampleNormal
{
    Service test = new Service();

    public void ExampleNorm()
    {
        test.Add();
     // test.Update();
     // test.Remove();
        test.GetList();
        test.Select();
    }

}