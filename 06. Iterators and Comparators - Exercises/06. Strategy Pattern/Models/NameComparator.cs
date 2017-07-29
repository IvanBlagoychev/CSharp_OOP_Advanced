using System.Collections.Generic;

namespace _06.StrategyPattern.Models
{
    public class NameComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.Name.Length.CompareTo(y.Name.Length) != 0)
            {
                return x.Name.Length.CompareTo(y.Name.Length);
            }
            return char.ToLower(x.Name[0]).CompareTo(char.ToLower(y.Name[0]));
        }
    }
}