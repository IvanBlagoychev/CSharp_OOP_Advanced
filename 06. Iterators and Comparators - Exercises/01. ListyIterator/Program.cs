using _01.ListyIterator.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ListyIterator
{
    public class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            ListyIterator<string> iterator = null;
            while (input != "END")
            {
                var command = input.Split(' ').ToArray();
                switch (command[0])
                {
                    case "Create":
                        var collection = new List<string>();
                        for (int i = 1; i < command.Length; i++)
                        {
                            collection.Add(command[i]);
                        }
                        iterator = new ListyIterator<string>(collection);
                        break;
                    case "HasNext": Console.WriteLine(iterator.HasNext());
                        break;
                    case "Move": Console.WriteLine(iterator.Move());
                        break;
                    case "Print": iterator.Print();
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
