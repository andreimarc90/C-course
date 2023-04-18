//By listing the first 6 prime numbers: 2, 3, 5, 7, 11, 13 we can see that the 6th prime is 13
// What is the 47 prime number?


do
{
    int index;
    Console.Write("Enter the index of prime number you want to find: ");
    try
    {
        index = int.Parse(Console.ReadLine());
        if (index < 1)
        {
            throw new ArgumentException("Index must be a positive integer.");
        }
        int count = 0, i = 2;
        while (count < index)
        {
            if (IsPrime(i))
            {
                count++;
            }
            i++;
        }
        Console.WriteLine("The {0}th prime number is {1}.", index, i - 1);
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

static bool IsPrime(int num)
{
    if (num < 2)
    {
        return false;
    }
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            return false;
        }
    }
    return true;
}
