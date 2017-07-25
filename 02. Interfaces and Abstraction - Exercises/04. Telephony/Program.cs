using System;
using System.Linq;

public static class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').ToList();
        var urls = Console.ReadLine().Split(' ').ToList();
        var smartphone = new Smartphone(numbers, urls);
        Console.WriteLine(smartphone);
    }
}