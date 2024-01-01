// DELEGATES

//MANUALLY CREATED DELEGATES
// Delegates appoint methods

//using Delegates;
//using YouTube.CSharp.Delegates;

//void Promotion(int reqExp, WorkersData data)
//{
//    foreach (var worker in data.workers)
//    {
//        if (worker.Experience > reqExp)
//        {
//            Console.WriteLine(worker.Name+": Promotion is Granted");
//        }
//        else
//        {
//            Console.WriteLine(worker.Name+": Promotion is Declined");
//        }
//    }

//    Console.WriteLine("---------------------");
//}

//void PromotionTemporary(int reqExp, WorkersData data)
//{
//    foreach (var worker in data.workers)
//    {
//        if (worker.Experience >= reqExp)
//        {
//            Console.WriteLine(worker.Name + ": Promotion is Granted");
//        }
//        else
//        {
//            Console.WriteLine(worker.Name + ": Promotion is Declined");
//        }
//    }
//    Console.WriteLine("---------------------");

//}

//WorkersData workersData = new WorkersData();

//PromotionDelegate promotionDelegate = new PromotionDelegate(Promotion);
//promotionDelegate(6, workersData);

//PromotionDelegate promotionTemporaryDelegate = new PromotionDelegate(PromotionTemporary);
//promotionTemporaryDelegate(2, workersData);

//PromotionDelegate allPromotionDelegates = promotionDelegate + promotionTemporaryDelegate;
//allPromotionDelegates(4,workersData);


//PromotionDelegate newPromotionDelegate = new PromotionDelegate((reqExp, data) =>
//{
//    foreach (var worker in data.workers)
//    {
//        if (worker.Experience > reqExp)
//        {
//            Console.WriteLine(worker.Name + ": Promotion is Granted");
//        }
//        else
//        {
//            Console.WriteLine(worker.Name + ": Promotion is Declined");
//        }
//    }

//    Console.WriteLine("---------------------");

//    Promotion(reqExp+1, workersData);
//});

//newPromotionDelegate(3, workersData);



//using YouTube.CSharp.Delegates;

//namespace Delegates
//{
//    public delegate void PromotionDelegate(int reqExp, WorkersData data);
//}




//BUILT IN DELEGATES

//ACTION DELEGATE

//using YouTube.CSharp.Delegates;

//void Promotion(int reqExp, WorkersData data)
//{
//    foreach (var worker in data.workers)
//    {
//        if (worker.Experience > reqExp)
//        {
//            Console.WriteLine(worker.Name + ": Promotion is Granted");
//        }
//        else
//        {
//            Console.WriteLine(worker.Name + ": Promotion is Declined");
//        }
//    }

//    Console.WriteLine("---------------------");
//}

//void Method()
//{
//    Console.WriteLine("I have no parameter and i am void");
//}

//Action promotion = new Action(Method);

//promotion();

//Action promotionNew = (() =>
//{
//    Method();
//    Console.WriteLine("I have no method name");
//});

//promotionNew();





//ACTION<> DELEGATE

//WorkersData workersData = new WorkersData();
////Action<int, WorkersData> actionDelegateWithPr = new Action<int, WorkersData>(Promotion);
////actionDelegateWithPr(3, workersData);

//Action<int, WorkersData> actionDelegateWithPr2 = new Action<int, WorkersData>((reqExp, data) =>
//{
//    foreach (var worker in data.workers)
//    {
//        if (worker.Experience > reqExp)
//        {
//            Console.WriteLine(worker.Name + ": Promotion is Granted");
//        }
//        else
//        {
//            Console.WriteLine(worker.Name + ": Promotion is Declined");
//        }
//    }

//    Console.WriteLine("---------------------");

//    Promotion(reqExp-2, workersData);
//});

//actionDelegateWithPr2(6, workersData);




//PREDICATE<>




//bool Example(int test)
//{

//    if (test > 0)
//        return true;
//    else
//        return false;
//}

//Predicate<int> test = ((number) =>
//{
//    if (number == 0)
//        return true;
//    else
//        return false;

//});

//Predicate<int> test2 = Example;

//var result = test(45);
//var result2 = test2(25);

//Console.WriteLine(result);
//Console.WriteLine(result2);





//FUNC<>

using YouTube.CSharp.Delegates;

string Method()
{
    return "i am learning delegates";
}

decimal Method2(decimal n1, decimal n2)
{
    return n1 + n2;
}

//Func<string> example = Method;
//var result = example();
//Console.WriteLine(result);
WorkersData workersData = new WorkersData();

//Func<decimal, decimal, decimal> decimaldelegate = Method2;
//var result5 = decimaldelegate(1.235m, 2.2356m);
//Console.WriteLine(result5);


string Example (int count, int reqSalary, WorkersData data)
{
    foreach (var worker in data.workers)
    {
        if (reqSalary < worker.Salary)
        {
            count++;
        }


    }
    if (count < 3)
    {
        return "Condition of workers is good";
    }
    else
    {
        return "Condition of workers is not good";
    }
}

Func<int, int, WorkersData, string> exampleDelegate = new Func<int, int, WorkersData, string>((count, reqSalary, data) =>
{
    var resultTemporary = Example(count, reqSalary, data);


    foreach (var worker in data.workers)
    {
        if (reqSalary < worker.Salary)
        {
            count++;
        }


    }
    if (count > 3 && resultTemporary == string.Empty)
    {
        return "Condition of workers is good";
    }
    else
    {
        return "Condition of workers is not good";
    }

});

var result = exampleDelegate(0, 1850, workersData);
Console.WriteLine(result);






