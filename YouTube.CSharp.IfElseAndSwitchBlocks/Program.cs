//IF ELSE & SWITCH CASE SATATEMENT

//If Else

/*
int number = 125;

if (number == 523)
{
    Console.WriteLine("The number is 523");
}
else if (number < 100)
{
    Console.WriteLine("The number is less than 100");
}
else if (number < 250 && number> 100)
{
    Console.WriteLine("The number is between 100 - 250");
}
else
{
    Console.WriteLine("The number is not 125");
}



if(number == 12) Console.WriteLine("The number is 12");
else if(number > 12) Console.WriteLine("The number is bigger than 12");
else Console.WriteLine("The number is smaller than 12 and is not 12");


string result = number == 125 ? "Yes, it is 125" : "No it is not 125";
Console.WriteLine(result);

string resultTwo = number == 250 ? "Yes, it is 125" : (number >100 ? "Yes number is bigger than 100" : "No it is not bigger than 100");
Console.WriteLine(resultTwo);


if (number == 523)
{
    Console.WriteLine("The number is 523");
}

if (number < 250)
{
    Console.WriteLine("The number is less than 250");
}

if( number > 100)
{
    Console.WriteLine("The number is bigger than 100");
}


Console.ReadLine();

*/

//Switch Case


/*
string city = "Berlin";

switch (city)
{
    case "London":
        Console.WriteLine("The city is London");
        break;
    case "Antalya":
        Console.WriteLine("The city is Antalya");
        break;
    case "NewYork":
        Console.WriteLine("The city is NewYork");
        break;
    default:
        Console.WriteLine("There is an error here");
        break;
}


string result = city switch
{
    "London" => "The city is London",
    "NewYork" => "The city is NewYork",
    _ => "There is an error here"
};

Console.WriteLine(result);
*/