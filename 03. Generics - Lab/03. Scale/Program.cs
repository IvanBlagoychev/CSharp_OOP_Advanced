using System;

public class Program
{
    static void Main()
    {
        Scale<int> scaleInts = new Scale<int>(1, 5);
        Scale<bool> scaleBool = new Scale<bool>(true, true);
        Scale<string> scaleStrings = new Scale<string>("hi", "hi");

        Console.WriteLine(scaleInts.GetHavier());
        Console.WriteLine(scaleBool.GetHavier());
        Console.WriteLine(scaleStrings.GetHavier());
    }
}