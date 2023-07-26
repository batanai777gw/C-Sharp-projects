using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types
{ //a variable are containers we can store variables
    class Program
{

    static void Main(string[] args) //main method,
    {
        //core  data types
        string phrase = "Leaning C# Fundamentals";
        char grade = 'A';
        int age = 30;
        double gpa = 3.3; //float, double, decimal to storee decimals
        bool isMale = true;

        Console.WriteLine(phrase + grade + age + gpa + isMale);

        Console.ReadLine();
    }
}
}

/*
 Data Types:
1.int	    4 bytes	Stores whole numbers from -2,147,483,648 to 2,147,483,647
2.long	8 bytes	Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
3.float	4 bytes	Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
4.double	8 bytes	Stores fractional numbers. Sufficient for storing 15 decimal digits
5.bool	1 bit	Stores true or false values
6.char	2 bytes	Stores a single character/letter, surrounded by single quotes
7.string	2 bytes per character	Stores a sequence of characters, surrounded by double quotes
 */