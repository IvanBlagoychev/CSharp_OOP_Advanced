using System;
using System.Collections.Generic;

namespace _05.Comparing_Objects
{
    public class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string town;
         

        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public string Name { get=> this.name; private set => this.name = value; }
        public int Age { get=> this.age; private set => this.age = value; }
        public string Town { get => this.town; private set => this.town = value; }


        public int CompareTo(Person other)
        {
            if (this.Name.CompareTo(other.Name) != 0)
            {
                return this.Name.CompareTo(other.Name);
            }

            if (this.Age.CompareTo(other.Age) != 0)
            {
                return this.Age.CompareTo(other.Age);
            }

            return this.Town.CompareTo(other.Town);
        }
    }
}
