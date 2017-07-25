using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        // ========== 05. Generic Count Method String ========== \\

        //var list = new List<Box<string>>();

        //int n = int.Parse(Console.ReadLine());
        //for (int i = 0; i < n; i++)
        //{
        //    var box = new Box<string>(Console.ReadLine());
        //    list.Add(box);
        //}
        //var element = Console.ReadLine();
        //Console.WriteLine(CompareElementsCount(list, element));




        // ========== 06. Generic Count Method Double ========== \\

        var list = new List<Box<double>>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var box = new Box<double>(double.Parse(Console.ReadLine()));
            list.Add(box);
        }
        var element = double.Parse(Console.ReadLine());
        Console.WriteLine(CompareElementsCount(list, element));
    }

    private static int CompareElementsCount<T>(List<Box<T>> list, T element)
        where T : IComparable<T>
    {
        int count = list.Count(x=>x.GivenVal.CompareTo(element) > 0);
        return count;
    }
}