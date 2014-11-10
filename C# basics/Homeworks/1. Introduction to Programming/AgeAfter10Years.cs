using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Please input your birthday (for example 1972/04/28): ");
        DateTime input = DateTime.Parse(Console.ReadLine());
        DateTime present = DateTime.Now;
        TimeSpan currentAge = present - input;
        double age = currentAge.TotalHours / 8765.81;
        Console.WriteLine("You are {0} years old.", (int)age);
        Console.WriteLine("In 10 years, you will be {0} years old.", (int)age + 10);
    }
}
