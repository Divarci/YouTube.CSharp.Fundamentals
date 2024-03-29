﻿// REFLECTION

//1-We are able to reach METADATA files and see object information.



//Get Type
/*
string text = "ByteVerse";
//type  ref  =   object
int number;

var typeOfText1 = typeof(string);
var typeOfText2 = text.GetType();

Type typeOfInt1 = typeof(int);
//Type typeOfInt2 = number.GetType();

Product product;

Type typeOfProduct1 = typeof(Product);
//Type typeOfProduct2 = product.GetType();

Product product2 = new();
Type typeOfProduct2 = product2.GetType();



class Product
{
    public int price = 5;
    public string Name { get; set; } = "marble";

    public void MethodFromProduct()
    {

    }

}


//What we can do with a type

using System.Reflection;
using test;
using YouTube.CSharp.ExceptionHandle;

Type typeOfClient = typeof(Client);
Type typeOfProduct = typeof(Product);
//Client client = new();

var client = Activator.CreateInstance(typeOfClient);

//Console.WriteLine(typeOfClient);
//Console.WriteLine(typeOfProduct);

//Console.WriteLine(typeOfClient.IsAbstract);
//Console.WriteLine(typeOfProduct.IsAbstract);

//var fields = typeOfClient.GetFields();
//foreach (var field in fields)
//{
//    var value = field.GetValue(client);
//    Console.WriteLine(value);
//}

//Console.WriteLine("-------");

//var properties = typeOfClient.GetProperties();
//foreach (var property in properties)
//{
//    var value = property.GetValue(client);
//    Console.WriteLine(value);
//}

//Console.WriteLine("-------");

//var methods = typeOfClient.GetMethods();
//foreach (var method in methods)
//{
//    var value = method.Name;
//    Console.WriteLine(value);
//}

//var myAssembly = Assembly.GetExecutingAssembly();
//Console.WriteLine(myAssembly.FullName);

//var types = myAssembly.GetTypes();
//foreach (var type in types)
//    Console.WriteLine(type.Name);


var anotherAssmbly = Assembly.GetAssembly(typeof(CustomException));
Console.WriteLine(anotherAssmbly);



class Client
{
    public int price = 5;
    public string text = "blabla";
    public string Name { get; set; } = "marble";
    public string Address { get; set; } = "bla bla bla";

    public void MethodFromProduct()
    {

    }
}


namespace test
{
    abstract class Product
    {
        public int price = 5;
        public string Name { get; set; } = "marble";

        public void MethodFromProduct()
        {

        }
    }


}

*/


// 2- IsAssignableFrom()
/*

using System.Collections;
using System.Reflection;
using System.Text.Json;

var assembly = Assembly.GetExecutingAssembly();
var types = assembly.GetTypes();

var classOnly = types.Where(type => type.IsClass && !type.IsInterface && typeof(IService).IsAssignableFrom(type));



foreach (var type in classOnly)
{
    IList list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(type))!;
    for (int i = 0; i < 6; i++)
    {
        var entity =(IService) Activator.CreateInstance(type)!;
        entity.Id = i;
        list.Add(entity);
    }

    Console.WriteLine(type.Name);
    Console.WriteLine(JsonSerializer.Serialize(list));
    Console.WriteLine("*********");
}



interface IService 
{
    public int Id { get; set; }
}

class Product : IService
{
    public int Id { get; set; }

}

class Client : IService
{
    public int Id { get; set; }

}

*/


// 3- Generic Example

using YouTube.CSharp.Reflection;

new FileGenerator<Product>(ProductSeed.products,"Product").GenerateFile();
new FileGenerator<Client>(ClientSeed.clients, "Client").GenerateFile();