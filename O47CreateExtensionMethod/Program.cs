using System;
using System.Globalization;
using System.Runtime.InteropServices;

public class Program
{
    static void Main()
    {
        int Number = 7;
        Console.WriteLine(Number.IsEven());
        Console.WriteLine(8.IsEven());
        Number = 46;
        Console.WriteLine(Number.IsEven());
        7.IsOdd();
    }

}

public static class EvenChecker
{
    public static bool IsEven(this int Number)
    {
        if (Number % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

     public static bool IsOdd(this int Number)
    {
        if (Number % 2 == 0)
        {
            Console.WriteLine(false);
            return false;
        }
        else
        {
           Console.WriteLine(true);
            return true;        
        }
    }
}