//This program adds even-value numbers of the Fibonacci sequence
//The maximum limit is 1000.

do
{
    Console.Write("Enter the upper limit for Fibonacci sequence (max 1000): ");
    int limit = 0;
    try
    {
        limit = int.Parse(Console.ReadLine());
        if (limit < 0 || limit > 1000)
        {
            throw new ArgumentException("Limit must be a positive integer between 0 and 1000.");
        }
        int sum = 0, a = 1, b = 1, c = 0;
        while (c <= limit)
        {
            if (c % 2 == 0)
            {
                sum += c;
            }
            a = b;
            b = c;
            c = a + b;
        }
        Console.WriteLine("The sum of even-valued terms in the Fibonacci sequence up to {0} is {1}.", limit, sum);
    }
    catch (FormatException)
    {
        Console.WriteLine("Input string is not a valid integer.");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
} while (true);
