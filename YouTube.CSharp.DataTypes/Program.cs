// Byte
// Short
// Int
// Long
// Enum

// Byte => 8 bit (1 byte)
byte numberOne = 5;
byte maxByte = byte.MaxValue;
byte minByte = byte.MinValue;

//Console.WriteLine("Max Byte is {0}, Min Byte is {1}, Curren Byte Value is {2}",maxByte,minByte,numberOne);
Console.WriteLine($"Max Byte is {maxByte}, Min Byte is {minByte}, Curren Byte Value is {numberOne}");


// Short => 16 bit (2 byte)
short numberTwo = 5;
short maxShort = short.MaxValue;
short minShort = short.MinValue;

Console.WriteLine($"Max Short is {maxShort}, Min Short is {minShort}, Curren Short Value is {numberTwo}");

// Int => 32 bit (4 byte)
int numberThree = 25;
int maxInt = int.MaxValue;
int minInt = int.MinValue;

Console.WriteLine($"Max Int is {maxInt}, Min Int is {minInt}, Curren Int Value is {numberThree}");

// Long => 64 bit (8 byte)
long numberFour = 25;
long maxLong = long.MaxValue;
long minLong = long.MinValue;

Console.WriteLine($"Max Long is {maxLong}, Min Long is {minLong}, Curren Long Value is {numberFour}");

//float
//double
//decimal if we would like to have more precise in our calculations we should use decimal
//char
//bool

//Float => 32 bit (4 byte)

float numberFive = 5.12345678901234567890123456789f; // we allowed to use 6 digit after dot
Console.WriteLine($"Float is allowed to use like this : {numberFive}");

//Double => 64 bit (8 byte)

double numberSix = 15.12345678901234567890123456789; // we allowed to use 15 digit after dot
Console.WriteLine($"Double is allowed to use like this : {numberSix}");

//Decimal => 128 bit (16 byte)

decimal numberSeven = 15.12345678901234567890123456789m; // we allowed to use 27 digit after dot
Console.WriteLine($"Decimal is allowed to use like this : {numberSeven}");

//char => 16 bit (2 byte)

char character = 'B';

int convertedChar = (int)character; 

Console.WriteLine($"Current char value is : {character}, and also current int value of Character is {convertedChar}");

string name = "Byteverse"; // 9 char character have been used to make a name string.

//bool => 8 bit (1 byte)

bool conditionOfCar = true; 
bool conditionOfBus = false;

bool isBiggerThanHundred = 200 > 100;
Console.WriteLine($"Is 200 bigger than 100 : {isBiggerThanHundred}"); //we use bools mostly with if blocks





