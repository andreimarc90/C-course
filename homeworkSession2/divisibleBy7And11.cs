int year;
bool validYear = false;

do
{
    Console.WriteLine("Please input year: ");

    try
    {
        year = int.Parse(Console.ReadLine());
        if (year % 4 == 0)
        {
            if (year % 100 != 0)

            {
                Console.WriteLine("The year provided is a leap year.");
            }
            else
            {
                validYear = (year % 400 == 0);
                Console.WriteLine("The year provided is a leap year.");
            }
            else

            {
                Console.WriteLine("The year provided is a leap year.");
            }
            Console.WriteLine("The year provided is a leap year.");
            validYear = true;
    catch (Exception ex)
    {
        Console.WriteLine("Numeric value was not introduced.");
        Console.WriteLine("Program will stop execution now.");
        validYear = false;

    }
} while (validYear);

Console.WriteLine("The " + primeNumberToFind + "th prime number is: " + primeNumber);
