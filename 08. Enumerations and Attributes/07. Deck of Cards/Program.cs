using System;

public class Program
{
    static void Main()
    {
        var suits = Enum.GetValues(typeof(Suit));
        var ranks = Enum.GetValues(typeof(Rank));

        foreach (var s in suits)
        {
            foreach (var r in ranks)
            {
                Console.WriteLine($"{r} of {s}");
            }
        }
    }
}