using System;
using System.Linq;

namespace _04.Froggy
{
    public class Program
    {
        static void Main()
        {
            var inputNums = Console.ReadLine().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Lake game = new Lake(inputNums);
            game.Play();
        }
    }
}
