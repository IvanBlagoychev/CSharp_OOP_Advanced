using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        // ====== Tasks 11, 12 ======= \\


        var personInfo = Console.ReadLine().Split(' ').ToArray();
        var tuple = new Tuple<string, string, string>($"{personInfo[0]} {personInfo[1]}", personInfo[2], personInfo[3]);
        Console.WriteLine(tuple);

        var drunk = Console.ReadLine().Split(' ').ToArray();
        bool isDrunk;
        var letsSee = drunk[2] == "drunk" ? isDrunk = true : isDrunk = false;
        var beerTuple = new Tuple<string, int, bool>(drunk[0], int.Parse(drunk[1]), isDrunk);
        Console.WriteLine(beerTuple);

        var digits = Console.ReadLine().Split(' ').ToArray();
        var digitTuple = new Tuple<string, double, string>(digits[0], double.Parse(digits[1]), digits[2]);
        Console.WriteLine(digitTuple);
    }
}