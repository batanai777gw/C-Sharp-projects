using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace working_with_strings
{ 
    class Program
{

    static void Main(string[] args) //main method,
    {
        //storing strings inside a variable
        string phrase = "I love programming" + " and hockey"; //concatenating - process of taking one string and appending another string at the end of it

        Console.WriteLine("Leaning\nC#"); // \n prints on a new line
        Console.WriteLine("Leaning\"C#"); // \n printing a quotation mark within a sentence
        Console.WriteLine(phrase); 
        Console.WriteLine(phrase.Length); //returns how many characters are inside the string 
        
         /*a method is a block of code which performs a specific task
         we can use methods on strings to give is information or modify the string*/
         Console.WriteLine(phrase.ToUpper());
         Console.WriteLine(phrase.ToLower());

         // FInding out if a string contains a subtext
         Console.WriteLine(phrase.Contains("love")); //returns true/false value depending on wether or not the phrase conrains love

         // accessing individual characters in a string
         Console.WriteLine(phrase[7]); // using index 0, 1, 2

         // using indexOf tells us if a value exists and at what index in a string
         Console.WriteLine(phrase.IndexOf("hockey")); 
         Console.WriteLine(phrase.IndexOf('I')); // in adding of passing a string, we can also pass a character
         Console.WriteLine(phrase.IndexOf('z')); // if a char doesn't exist the output will be -1, signifies that the char is not in the string phrase
         Console.WriteLine(phrase.Substring(23)); // a parameter of 23, returns the string starting at index 1 
            Console.WriteLine(phrase.Substring(7, 7));   //you can parse starting index and how many characters you want returned. 7 charcters after index 7

            Console.ReadLine();
        }
    }
}

/*
 string methods:

#1) Clone() --The clone method in C# is used to duplicate a string type object. It returns a clone of the same data as the object type.

string a = "hello";
string b = (string)a.Clone();
Console.WriteLine(b); output: hello
  
#2) Concat() --A concat method in C# helps combine or concatenate several strings. It returns a combined string

Concat(String, String)
string a = "Hello";
string b = "World";
Console.WriteLine(string.Concat(a,b));

#3) Contains() --Contain method in C# is used to determine if a particular substring is present inside a given string or not

string a = "HelloWorld";
string b = "World";
Console.WriteLine(a.Contains(b));

#4) Copy( ) --The Copy method in C# is used to produce a new string instance with the same value as a different declared string.
string a = "Hello";
string b = string.Copy(a);
Console.WriteLine(b);

#5) Equals( ) --The Equals method in C# is used to validate if the two given strings are the same or not. returns true/false

string a = "Hello";
string b = "World";
Console.WriteLine(a.Equals(b));

#6) IndexOf( ) --The IndexOf method in C# is used to find the index of a specific character inside a string

string a = "Hello";
int b = a.IndexOf('o');
Console.WriteLine(b);

#7) Insert( )  --The Insert method in C# is used for inserting a string at a specific index point.
string a = "Hello";
string b = a.Insert(2, “_World_”);
Console.WriteLine(b); output: He_World_llo

#8) Replace( )  --The Replace method in C# is used to replace a certain set of concurrent characters from a given string

string a = "Hello";
string b = a.Replace(“lo”, “World”);
Console.WriteLine(b); output: HelWorld

#9) SubString( )  --The SubString method in C# is used to get a part of the string from a given string.

string a = "Hello";
string b = a.Substring(2);
Console.WriteLine(b); output:llo

#10) Trim( ) --The Trim method in C# is used to remove all the whitespace characters at the start and end of a string

string a = "Hello ";
string b = a.Trim();
Console.WriteLine(b); output: Hello
 */