using System;
using System.Collections.Generic;
using System.Linq;
using _06.StrategyPattern.Models;

namespace _06.Strategy_Pattern
{
    public class Program
    {
        static void Main()
        {
            var namesSet = new SortedSet<Person>(new NameComparator());
            var agesSet = new SortedSet<Person>(new AgeComparator());

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var personTokens = Console.ReadLine().Split(' ').ToArray();
                var name = personTokens[0];
                var age = int.Parse(personTokens[1]);
                namesSet.Add(new Person(name, age));
                agesSet.Add(new Person(name, age));
            }

            foreach (Person p in namesSet) Console.WriteLine(p);
            foreach (Person p in agesSet) Console.WriteLine(p);
        }
    }
}
