using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        ICollection<IPersonallity> personallities = new List<IPersonallity>();
        var input = Console.ReadLine();

        while (input != "End")
        {
            var tokens = input.Split(' ').ToArray();
            if (tokens.Length == 3) personallities.Add(new Citizen(tokens[2], tokens[0], int.Parse(tokens[1])));
            else if (tokens.Length == 2) personallities.Add(new Robot(tokens[1], tokens[0]));
            input = Console.ReadLine();
        }
        var lastDigits = Console.ReadLine();

        personallities.Where(x=>x.Id.EndsWith(lastDigits)).ToList().ForEach(x=>Console.WriteLine(x.Id));
    }
}