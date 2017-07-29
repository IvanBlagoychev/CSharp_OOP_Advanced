using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Comparing_Objects
{
    public class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var people = new List<Person>();

            while (input != "END")
            {
                var tokens = input.Split(' ').ToList();
                var name = tokens[0];
                var age = int.Parse(tokens[1]);
                var town = tokens[2];

                Person newPerson = new Person(name, age, town);
                people.Add(newPerson);

                input = Console.ReadLine();
            }

            var position = int.Parse(Console.ReadLine());
            var personForCompare = people[position - 1];
            people.RemoveAt(position - 1);

            var diff = 0;
            var same = 0;

            foreach (Person p in people)
            {
                int comparison = p.CompareTo(personForCompare);
                if (comparison > 0 || comparison < 0)
                {
                    diff++;
                }
                else same++;
            }

            if (same == 0) Console.WriteLine("No matches");
            else Console.WriteLine($"{same + 1} {diff} {people.Count + 1}");

        }
    }
}
