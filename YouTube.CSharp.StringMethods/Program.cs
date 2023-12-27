//STRING METHODS
using System.Globalization;

string name = "Byteverse";

Console.WriteLine(name[0]);

foreach (char item in name)
{
    Console.WriteLine(item);
}

string sentence = "My Channel name is ByteVerse";

var result = sentence.Length;
Console.WriteLine(result);

var result2 = sentence.EndsWith("Verse");
Console.WriteLine(result2);

var result3 = sentence.StartsWith("My");
Console.WriteLine(result3);

var result4 = sentence.IndexOf("Chan");
Console.WriteLine(result4);

var result5 = sentence.LastIndexOf(" ");
Console.WriteLine(result5);

var result6 = sentence.Insert(0, "Hello, ");
Console.WriteLine(result6);

var result7 = sentence.Substring(19);
Console.WriteLine(result7);

var result8 = sentence.Substring(3,7);
Console.WriteLine(result8);

var result9 = sentence.ToLower();
Console.WriteLine(result9);

var result10 = sentence.ToUpper();
Console.WriteLine(result10);

var result11 = sentence.Replace(" ", "-");
Console.WriteLine(result11);

var result12 = sentence.Remove(11, 5);
Console.WriteLine(result12);

var result13 = sentence.Remove(11);
Console.WriteLine(result13);

var result14 = sentence.Contains(" is ");
Console.WriteLine(result14);

