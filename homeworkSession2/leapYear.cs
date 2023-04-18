//Check whether a given year is a leap year or not.

//Not every four years is a leap year.
//The rule is that if the year is divisible by 100 and not divisible by 400, leap year is skipped.
//The year 2000 was a leap year, for example, but the years 1700, 1800, and 1900 were not.

using System;

int year;
bool validYear = false;

do
{
    Console.WriteLine("Please input year: ");

    try
    {
        year = int.Parse(Console.ReadLine());
        if (year < 1)
        {
            Console.WriteLine("Variable YEAR must be greater than 0.");
            continue;
        } 

        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 != 0) { Console.WriteLine("Year " + year + " is NOT a leap year."); }
                else { Console.WriteLine("Year " + year + " is a leap year."); }
                
            }
            else { Console.WriteLine("Year " + year + " is a leap year."); }
        }
        else { Console.WriteLine("Year " + year + " is NOT a leap year."); }
        validYear = true;
     
    }
    catch (Exception ex)
    {
        Console.WriteLine("Numeric value was not introduced.");
        Console.WriteLine("Program will stop execution now.");
        validYear = false;

    }
} while (validYear);
