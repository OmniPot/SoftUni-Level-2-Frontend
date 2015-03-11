using System;

class SquareRoot
{
    static void Main()
    {
        try
        {
            Console.Write("Please enter a number: ");
            string str = Console.ReadLine();
            int number = int.Parse(str);

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid number!");
            }

            Console.WriteLine("Square root of the number: {0}", Math.Sqrt(number));

        }
        catch (FormatException fe)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (ArgumentNullException ane)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (OverflowException oe)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (ArgumentOutOfRangeException oor)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye. :)");
        }

    }
}

