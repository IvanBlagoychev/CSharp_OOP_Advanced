using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        ICollection<IPerson> personallities = new List<IPerson>();

        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine().Split(' ').ToArray();
            if (line.Length == 4) personallities.Add(new Citizen(line[2], line[0], int.Parse(line[1]), line[3]));
            else if(line.Length == 3) personallities.Add(new Rebel(line[0], line[2], int.Parse(line[1])));
        }

        var input = Console.ReadLine();
        var totalFood = 0;
        while (input != "End")
        {
           
            if (personallities.Any(x => x.Name.Equals(input)))
            {
                IBuyer person = (IBuyer) personallities.First(x => x.Name.Equals(input));
                person.BuyFood();
            }
            input = Console.ReadLine();
        }
        foreach (var p in personallities)
        {
            var personP = (IBuyer) p;
            totalFood += personP.Food;
        }
        Console.WriteLine(totalFood);
    }
}