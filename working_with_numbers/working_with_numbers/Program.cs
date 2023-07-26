using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace working_with_numbers
{ 
class Program 
{

    static void Main(string[] args)
    {
        //storing numbers in a variable
        int num = 6;
        num++; //increments. add 1 to 6 //num--; = 5
        Console.WriteLine(num);
        
        // different math methods we can call to perform functions
        Console.WriteLine(Math.Abs(-40)); //: absolute value is 40
        Console.WriteLine(Math.Pow(3, 2)); //: 3^2 : = 9
        Console.WriteLine(Math.Pow(3.8, 2)); //: using decimal numbers 3.8^2 : = 14.44
        Console.WriteLine(Math.Sqrt(36)); // square root of a number
        Console.WriteLine(Math.Max(4, 90)); // Max takes 2 parameters and compares them, returns the bigger number
        Console.WriteLine(Math.Min(4, 90)); // Min takes 2 parameters and compares them, returns the smaller number
        Console.WriteLine(Math.Round(4.7)); // Great method to round numbers
            
        Console.ReadLine();
    }
}
}

/*
  4 basics operations to use on numbers:
    1. + --addition
    2. - subtraction
    3. / division
    4. * multiplication
    5. % (mode) return remainder of 5 % 2 = 1

    Oder of operations in mathematical equations
       you can use paranthesis to change the oder of operations
 4 + 2 * 3 = 10
 (4 + 2) * 3 = 18

  5.0 + 8.1 = 13.1 decimal + dec = dec
  5 + 8.1 = 13.1 int + decimal = decimal
   
   5 / 2 returns an int = 2
   5 / 2.0 returns a decimal = 2.5
 */