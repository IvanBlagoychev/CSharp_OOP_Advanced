using System;
using System.Collections.Generic;
using System.Linq;
using _02.Collection.Models;

namespace _02.Collection
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            ListyIterator<string> iterator = null;
            while (input != "END")
            {
                var tokens = input.Split(' ').ToList();
                switch (tokens[0])
                {
                    case "Create":
                        iterator = new ListyIterator<string>(new List<string>(tokens.Skip(1)));
                        break;
                    case "HasNext":
                        Console.WriteLine(iterator.HasNext());
                        break;
                    case "Move":
                        Console.WriteLine(iterator.Move());
                        break;
                    case "Print":
                        iterator.Print();
                        break;
                    case "PrintAll":
                       iterator.PrintAll();
                        break;
                    default: break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
