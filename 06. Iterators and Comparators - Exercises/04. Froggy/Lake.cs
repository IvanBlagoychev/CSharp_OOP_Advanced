using System;
using System.Collections;
using System.Collections.Generic;

namespace _04.Froggy
{
    public class Lake : IEnumerable<int>
    {
        private IList<int> stones;

        public Lake(IList<int> stoneList)
        {
            this.stones = new List<int>(stoneList);
        }

        public void Play()
        {
            var returnNums = new List<string>();
            for (int i = 0; i < this.stones.Count; i++)
            {
                if (i % 2 == 0) { returnNums.Add(this.stones[i].ToString());}
            }
            for (int i = this.stones.Count - 1; i >= 0; i--)
            {
                if (i % 2 == 1) { returnNums.Add(this.stones[i].ToString()); }
            }
            Console.WriteLine(string.Join(", ", returnNums));
        }

        public IEnumerator<int> GetEnumerator()
        {
            return this.stones.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
