using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Stack
{
    public class Stack<T> : IEnumerable<int>
    {
        private IList<int> data;

        public Stack()
        {
            this.data = new List<int>();
        }

        public int Push(int element)
        {
            this.data.Add(element);
            return element;
        }

        public string Pop()
        {
            if (this.data.Count > 0)
            {
                var elementToPop = this.data.LastOrDefault();
                this.data.RemoveAt(this.data.Count - 1);
                return elementToPop.ToString();
            }
            throw new ArgumentException("No elements");
        }

        public int GetCount()
        {
            return this.data.Count;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = this.data.Count - 1; i >= 0; i--)
            {
                sb.AppendLine(this.data[i].ToString());
            }
            return sb.ToString().Trim();
        }

        public IEnumerator<int> GetEnumerator()
        {
            return this.data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }


    }
}