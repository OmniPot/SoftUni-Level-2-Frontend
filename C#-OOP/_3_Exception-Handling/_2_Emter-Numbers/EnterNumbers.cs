using System;

public class EnterNumbers
{
    public static int min = 1;

    public static void Main()
    {
        int count = 0;
        int max = 100;

        while (count < 10)
        {
            try
            {
                ReadNumber(min, max);
                count++;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number! Try again.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Invalid number! Try again.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid number! Try again.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid number! Try again.");
            }
        }
    }

    public static void ReadNumber(int start, int end)
    {
        Console.Write("Enter number in range ({0}...{1}): ", start, end);
        int num = int.Parse(Console.ReadLine());
        if (num <= start || num >= end)
        {
            throw new ArgumentOutOfRangeException();
        }
        min = num;
    }
}

