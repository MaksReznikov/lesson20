using lesson20.Exceptions;

namespace lesson20;

class Program
{
    static void Main(string[] args)
    {
        // 6 2 8
        // 3 1 4
        //int a = GetNumber();
        //Console.WriteLine("Your nyumber is " + a);
        // try
        // {
        //     GetEx();
        // }
        // catch (DivideByZeroException ex)
        // {
        //     Console.WriteLine("Error!");
        //     Console.WriteLine(ex.StackTrace);
        // }

        string[] a = File.ReadAllLines("../../../test.txt");
        Console.WriteLine(a[0]);
        string[] numbers = a[0].Split(" ");
        foreach (string i in numbers)
        {
            Console.WriteLine(i);
        }
    }

    static int GetNumber()
    {
        Console.WriteLine("Enter number between 1 and 10");
        try
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0 && number < 11)
                return number;
            throw new MyRangeException("Number must be between 1 and 10");
        }
        catch (FormatException)
        {
            Console.WriteLine("You entered wrong! you must enter number!");
            return GetNumber();
        }
        catch (MyRangeException ex)
        {
            Console.WriteLine(ex.Message);
            return GetNumber();
        }
    }

    static void GetEx()
    {
        try
        {
            int a = 0;
            int b = a / 0;
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine("This is message from GetEx");
            Console.WriteLine(ex.StackTrace);
            throw;
        }
    }
}