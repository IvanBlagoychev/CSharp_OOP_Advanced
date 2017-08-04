using System;

public class Program
{
    static void Main()
    {
        var cards = Enum.GetValues(typeof(Card));
        Console.WriteLine("Card Suits:");
        foreach (var c in cards)
        {
            Console.WriteLine($"Ordinal value: {(int)c}; Name value: {c}");
        }
    }
}