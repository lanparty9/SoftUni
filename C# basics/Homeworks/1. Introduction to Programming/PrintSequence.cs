using System;

class PrintSequence
{
    static void Main()
    {
        int[] myArray = { 2, -3, 4, -5, 6, -7, 8, -9, 10, -11 };
        foreach (int number in myArray)
        Console.Write(number + ", ");
    }
}

