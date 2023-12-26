//TYPE CONVERSIONS

//1-Casting
//2-[type].Parse
//3-Convert.To...
//4-ToString()

//Casting => You may loose your data

int numberOne = 2500;

int mod = 2500 % 256; // 0-255
Console.WriteLine(mod);

Console.WriteLine($"{numberOne} is an integer and it is a {numberOne.GetType()}");

byte convertedType = (byte)numberOne;
Console.WriteLine($"We convert {convertedType} to Byte and now it is {convertedType.GetType()}");

float floatNumber = 5.12345678901234567890123456789f;
double doubleNumber = 5.12345678901234567890123456789;
decimal decimalNumber = 5.12345678901234567890123456789m;

float convertedNumberOne = (float)decimalNumber;
float convertedNumberTwo = (float)doubleNumber;

double convertedNumberThree = (double)decimalNumber;

Console.WriteLine(decimalNumber);

Console.WriteLine($"From Decimal to Float {convertedNumberOne}\nFrom Double to Float {convertedNumberTwo}\nFrom Decimal to Double {convertedNumberThree}");

//[Type].Parse => from string to value type like int,byte....

string textOne = "1";

int newTypeOne = int.Parse(textOne);

Console.WriteLine($"{textOne} is converted to {newTypeOne} as a {newTypeOne.GetType()}");

/*
string textTwo = "Byteverse";

int newTypeTwo = int.Parse(textTwo);
Console.WriteLine($"{textTwo} is converted to {newTypeTwo} as a {newTypeTwo.GetType()}");
*/

string textThree = "5";

bool isConverted = int.TryParse(textThree, out int numberNew);
Console.WriteLine($"i am {isConverted} and i am {numberNew}");

string textFour = "Five";

bool isSuccess = int.TryParse(textFour, out _);
Console.WriteLine($"i am {isSuccess}");

//Convert.To

/*
long numberLong = 5896554862654884785;

int newInteger = Convert.ToInt32(numberLong);
*/

short shortNumber = 5623;

int newInteger = Convert.ToInt32(shortNumber);
Console.WriteLine($"New Converted Value is {newInteger}");


string newString = "5";

short newShort = Convert.ToInt16(newString);
Console.WriteLine($"New Converted Value is {newShort}");

/*
string newString2 = "Five";

short newShort2 = Convert.ToInt16(newString2);
Console.WriteLine($"New Converted Value is {newShort2}");
*/

//ToString => It helps us convert from value type to string

decimal numberDecimal = 5.568974587562m;

string newStringTwo = numberDecimal.ToString();
Console.WriteLine($"New value is {newStringTwo} and its type is {newStringTwo.GetType()}");



