using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{ //a variable are containers we can store variables
    class Program
    {

        static void Main(string[] args) //main method,
        {
            string characterName = "John";
            int characterAge; 
            characterAge = 35;

            Console.WriteLine("There once was a name called " + characterName);
            Console.WriteLine("He was " + characterAge+ " years old");

            //modifying the value of the varibales.     you can give a variable a value and later on change that value in the program
            characterName = "Mike";
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);

            Console.ReadLine();
        }
    }
}

/*
 Data types in C#:
    int myNum = 5; integer(whole number)
    DOUBLE myDoubleNum = 5.99D; Floating point number/decimal
    char myLetter = 'D'; characters
    bool myBool = true; Boolean - true/false values
    string myText = "Hello"; string - for storing
 */

/*
1.int	    4 bytes	Stores whole numbers from -2,147,483,648 to 2,147,483,647
2.long	8 bytes	Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
3.float	4 bytes	Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
4.double	8 bytes	Stores fractional numbers. Sufficient for storing 15 decimal digits
5.bool	1 bit	Stores true or false values
6.char	2 bytes	Stores a single character/letter, surrounded by single quotes
7.string	2 bytes per character	Stores a sequence of characters, surrounded by double quotes
 */