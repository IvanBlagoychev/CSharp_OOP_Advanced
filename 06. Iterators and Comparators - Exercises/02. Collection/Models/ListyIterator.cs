using System;
using System.Collections;
using System.Collections.Generic;

namespace _02.Collection.Models
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private readonly IList<T> data;
        private int index;

        public ListyIterator(IList<T> collection)
        {
            this.data = new List<T>(collection);
            this.index = 0;
        }

        public bool Move()
        {
            if (this.HasNext())
            {
                this.index++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            if ((this.index + 1) < this.data.Count) return true;
            else return false;
        }

        public void Print()
        {
            if (this.data.Count > 0) Console.WriteLine(this.data[this.index]);
            else Console.WriteLine("Invalid Operation!");
        }

        public void PrintAll()
        {
            Console.WriteLine(string.Join(" ", this.data));
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.data.Count; i++)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}