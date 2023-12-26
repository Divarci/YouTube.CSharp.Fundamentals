// CALCULATIONS AND OPERATORS


//Calculations => + , - , / , * , %
/*
byte byteOne = 5;
byte byteTwo = 10;

byte resultByte =(byte)(byteOne * byteTwo);
int newResultInt = byteOne * byteTwo;
var commonResultForByte = byteOne * byteTwo;

Console.WriteLine($"I am Byte {resultByte}, I am int {newResultInt}, i am here with var keyword {commonResultForByte}");
//----

short shortOne = 500;
short shortTwo = 250;

short resultShort = (short)(shortOne - shortTwo);
int newResultIntTwo = shortOne - shortTwo;
var commonResultForShort = shortOne - shortTwo;

Console.WriteLine($"I am Short {resultShort}, I am int {newResultIntTwo}, i am here with var keyword {commonResultForShort}");
//----

int intOne = 60000;
int intTwo = 45000;

int resultInt = intOne + intTwo;
long resultLongFromInt = intOne + intTwo;

Console.WriteLine($"I am int {resultInt}, I am long {resultLongFromInt}");
//----

long longOne = 125000;
long longTwo = 25000;

long resultLong = longOne / longTwo;
int resultInfFromLong = (int)(longOne / longTwo);
int resultInfFromLongTwo = Convert.ToInt32(longOne / longTwo);

Console.WriteLine($"I am long {resultLong}, I am int by casting {resultInfFromLong}, I am int by converting {resultInfFromLongTwo}");


//--
var newCalculationsWithMixedDataTypes = byteOne * shortTwo + intOne / longTwo - intTwo;
                                        // 5    *   250    + 60000  / 25000   - 45000
                                        //    1250         +   2              - 45000

Console.WriteLine(newCalculationsWithMixedDataTypes);// -43748

var newCalculationsWithMixedDataTypesTwo = byteOne * (shortTwo + intOne) / longTwo - intTwo;
                                            // 5   *       60250         / 25000   - 45000
                                            //                  12                 - 45000
                                            
Console.WriteLine(newCalculationsWithMixedDataTypesTwo);// -44988


//--

string newText = "25";

var newResultWithString = newText + " " +shortOne;
                       //  25     +   500
Console.WriteLine(newResultWithString);//"25""500"

var newResultWithStringTwo = short.Parse(newText) - shortTwo;

Console.WriteLine(newResultWithStringTwo);//-225


//--

string newTextTwo = "Book";

string sentence = "I bought " + newText+ " "+ newTextTwo+"s " + "last week";

Console.WriteLine(sentence);

*/


//Operators

bool conditionOne = 500 == 400;
Console.WriteLine(conditionOne);

bool conditionTwo = 500 != 400;
Console.WriteLine(conditionTwo);

bool conditionThree = "London" != "Manchester";
Console.WriteLine(conditionThree);

bool conditionFour = "London" != "London";
Console.WriteLine(conditionFour);

bool conditionFive = 500 > 400;
Console.WriteLine(conditionFive);

bool conditionSix = 500 < 400;
Console.WriteLine(conditionSix);

bool conditionSeven = 500 <= 400;
Console.WriteLine(conditionSeven);

bool conditionEight = 500 >= 500;
Console.WriteLine(conditionEight);

bool conditionNine = 500 <= 400 && "Antalya" != "London";
Console.WriteLine(conditionNine);

bool conditionTen = 500 <= 400 || "Antalya" != "London";
Console.WriteLine(conditionTen);

//--

int initialNumber = 25;
Console.WriteLine(initialNumber);

initialNumber++;
Console.WriteLine(initialNumber); //26

initialNumber++;
Console.WriteLine(initialNumber); //27

initialNumber--;
Console.WriteLine(initialNumber); //26










