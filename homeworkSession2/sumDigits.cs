//This program finds the sum of digits of a number read from the keyboard.

while (true)
{
    Console.Write("Enter a number: ");
    int num = 0;
    try
    {
        num = int.Parse(Console.ReadLine());
        if (num < 0)
        {
            throw new ArgumentException("Number must be positive.");
        }
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        Console.WriteLine("The sum of digits is {0}.", sum);
    }
    catch (FormatException)
    {
        Console.WriteLine("Input string is not a valid integer.");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}
