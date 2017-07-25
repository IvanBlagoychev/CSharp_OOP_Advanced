using System;

public static class Program
{
    static void Main()
    {
        var input = Console.ReadLine();
        ICar ferrari = new Ferrari(input);
        Console.WriteLine(ferrari);
    }
}