using System;
using System.Collections.Generic;
using System.Linq;

public class CommandInterpreter
{
    
    public void Run()
    {
        var input = Console.ReadLine();
        var list = new CustomList<string>();

        while (input !="END")
        {
            var tokens = input.Split(' ').ToArray();

            switch (tokens[0])
            {
                case "Add":
                    list.Add(tokens[1]);
                    break;
                case "Remove":
                    list.Remove(int.Parse(tokens[1]));
                    break;
                case "Contains":
                    Console.WriteLine(list.Contains(tokens[1]));
                    break;
                case "Swap":
                    list.Swap(int.Parse(tokens[1]), int.Parse(tokens[2]));
                    break;
                case "Greater":
                    Console.WriteLine(list.CountGreaterThan(tokens[1]));
                    break;
                case "Max":
                    Console.WriteLine(list.Max());
                    break;
                case "Min":
                    Console.WriteLine(list.Min());
                    break;
                case "Print":
                    Console.WriteLine(list.Print());
                    break;
                case "Sort":
                    Sorter<string> sorter = new Sorter<string>();
                    list = Sorter<string>.Sort(list);
                    break;
            }
            input = Console.ReadLine();
        }
    }
}