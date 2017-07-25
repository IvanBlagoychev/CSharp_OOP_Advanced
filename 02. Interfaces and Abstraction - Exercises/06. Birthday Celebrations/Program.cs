using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        ICollection<ILivingPersonallty> personallities = new List<ILivingPersonallty>();
        ICollection<IPersonallity> robots = new List<IPersonallity>();
        var input = Console.ReadLine();

        while (input != "End")
        {
            var tokens = input.Split(' ').ToArray();
            switch (tokens[0])
            {
                case "Pet": personallities.Add(new Pet(tokens[1], tokens[2])); break;
                case "Citizen": personallities.Add(new Citizen(tokens[3], tokens[1], int.Parse(tokens[2]), tokens[4])); break;
                case "Robot":robots.Add(new Robot(tokens[2], tokens[1])); break;
            }

            input = Console.ReadLine();
        }
        var year = Console.ReadLine();


        personallities.Where(x => x.BirthDate.EndsWith(year)).ToList().ForEach(x => Console.WriteLine(x.BirthDate));
    }
}