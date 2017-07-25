using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        // ========= Problem 1.	Generic Box of String ============ \\

        //int n = int.Parse(Console.ReadLine());
        //for (int i = 0; i < n; i++)
        //{
        //    var input = Console.ReadLine();
        //    Console.WriteLine(new Box<string>(input));
        //}




        // ========= Problem 2.	Generic Box of Integers ============ \\

        //int n = int.Parse(Console.ReadLine());
        //for (int i = 0; i < n; i++)
        //{
        //    var input = int.Parse(Console.ReadLine());
        //    Console.WriteLine(new Box<int>(input));
        //}





        // ========= Problem 3.	Generic Swap Method Strings ============ \\

        //var list = new List<Box<string>>();

        //int n = int.Parse(Console.ReadLine());
        //for (int i = 0; i < n; i++)
        //{
        //    var input = Console.ReadLine();
        //   var box = new Box<string>(input);
        //    list.Add(box);
        //}
        //var positions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //SwapPositionsString(list, positions[0], positions[1]);
        //list.ForEach(x=>Console.WriteLine(x));





        // ========= Problem 4.	Generic Swap Method Integers ============ \\

        //var list = new List<Box<int>>();

        //int n = int.Parse(Console.ReadLine());
        //for (int i = 0; i < n; i++)
        //{
        //    var input = int.Parse(Console.ReadLine());
        //    var box = new Box<int>(input);
        //    list.Add(box);
        //}
        //var positions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        //SwapPositionsInts(list, positions[0], positions[1]);
        //list.ForEach(x => Console.WriteLine(x));
    }

    private static void SwapPositionsInts(List<Box<int>> list, int firstPos, int secondPos)
    {
        var firsBox = list[firstPos];
        list[firstPos] = list[secondPos];
        list[secondPos] = firsBox;
    }

    private static void SwapPositionsString(List<Box<string>> list, int firstPos, int secondPos)
    {
        var firsBox = list[firstPos];
        list[firstPos] = list[secondPos];
        list[secondPos] = firsBox;
    }
}