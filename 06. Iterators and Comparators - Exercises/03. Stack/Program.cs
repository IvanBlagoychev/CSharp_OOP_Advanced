using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Stack
{
    public class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();
            while (input != "END")
            {
                try
                {
                    var tokens = input.Split(new [] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).ToList();
                    switch (tokens[0])
                    {
                        case "Push":
                            var nums = tokens.Skip(1);
                            nums.ToList().ForEach(n => stack.Push(int.Parse(n)));
                            break;
                        case "Pop":
                            stack.Pop();
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                input = Console.ReadLine();
            }
            if (stack.GetCount() > 0)
            {
                Console.WriteLine(stack);
                Console.WriteLine(stack);
            }
        }
    }
}
