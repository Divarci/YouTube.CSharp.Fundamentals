// DELEGATES

//MANUALLY CREATED DELEGATES
// Delegates appoint methods

using Delegates;
using YouTube.CSharp.Delegates;

void Promotion(int reqExp, WorkersData data)
{
    foreach (var worker in data.workers)
    {
        if (worker.Experience > reqExp)
        {
            Console.WriteLine(worker.Name+": Promotion is Granted");
        }
        else
        {
            Console.WriteLine(worker.Name+": Promotion is Declined");
        }
    }

    Console.WriteLine("---------------------");
}

void PromotionTemporary(int reqExp, WorkersData data)
{
    foreach (var worker in data.workers)
    {
        if (worker.Experience >= reqExp)
        {
            Console.WriteLine(worker.Name + ": Promotion is Granted");
        }
        else
        {
            Console.WriteLine(worker.Name + ": Promotion is Declined");
        }
    }
    Console.WriteLine("---------------------");

}

WorkersData workersData = new WorkersData();

//PromotionDelegate promotionDelegate = new PromotionDelegate(Promotion);
//promotionDelegate(6, workersData);

//PromotionDelegate promotionTemporaryDelegate = new PromotionDelegate(PromotionTemporary);
//promotionTemporaryDelegate(2, workersData);

//PromotionDelegate allPromotionDelegates = promotionDelegate + promotionTemporaryDelegate;
//allPromotionDelegates(4,workersData);


PromotionDelegate newPromotionDelegate = new PromotionDelegate((reqExp, data) =>
{
    foreach (var worker in data.workers)
    {
        if (worker.Experience > reqExp)
        {
            Console.WriteLine(worker.Name + ": Promotion is Granted");
        }
        else
        {
            Console.WriteLine(worker.Name + ": Promotion is Declined");
        }
    }

    Console.WriteLine("---------------------");

    Promotion(reqExp+1, workersData);
});

newPromotionDelegate(3, workersData);




//BUILT IN DELEGATES


namespace Delegates
{
    public delegate void PromotionDelegate(int reqExp, WorkersData data);
}