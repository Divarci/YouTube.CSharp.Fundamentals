// COLLECTIONS

//why we need...

using System.Collections;
using System.Security.Cryptography.X509Certificates;
/*
string[] cities = new string[3] { "London", "Manchester", "Birmingham" };
cities[3] = "NewYork";

Console.WriteLine(cities[3]);
*/


//ArrayList
/*
ArrayList list = new ArrayList();
list.Add("Carpet");
//list.Add(5);
//list.Add(false);
//list.Add('X');

foreach (var item in list)
{
    Console.WriteLine(item);
}
*/

//we able to add any item anytime anywhere we want.
//array list accept any kind of data type

//List...
/*
List<string> product = new List<string>()
{
    "Stone","Iron","Stone","Paint"
};
product.Add("Marble");

product.Remove("Stone");
product.Insert(2, "Test");

string[] productsNew = { "Brick", "Cement" };

product.AddRange(productsNew);
product.RemoveAll(item => item.Length < 6);

foreach (var item in product)
{
    Console.WriteLine(item);
}
//product.Clear();

Console.WriteLine(product.Count);
Console.WriteLine(product.Contains("Iron"));
Console.WriteLine(product.IndexOf("Stone"));
Console.WriteLine(product.LastIndexOf("Stone"));
*/
//Dictionary

Dictionary<int, string> client = new()
{
    {1,"Hasan" },{2,"Michael"},{3,"George"}
};

foreach (var item in client)
{
    Console.WriteLine(item);
}

Console.WriteLine(client.ContainsKey(1));

Console.WriteLine(client.TryGetValue(12,out _));




