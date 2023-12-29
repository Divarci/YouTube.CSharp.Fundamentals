// REFERANCE AND VALUE TYPES

////value type
//int number = 5;

//int number2 =8;

//number2 = number;

//number = 7;

//Console.WriteLine(number2);//5

//referance type

string[] test = new string[3] { "a", "b", "c" }; // m bc
string[] test2 = new string[3] { "x", "y", "z" };

test2 = test;// a b c

test[0] = "m";

Console.WriteLine(test2[0]);//m
