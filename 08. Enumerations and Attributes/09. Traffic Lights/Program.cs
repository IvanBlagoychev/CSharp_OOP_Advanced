using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    static void Main()
    {

        var signalOrder = Console.ReadLine().Split(' ');
        var trafficLights = new List<TrafficLight>();

        foreach (var s in signalOrder)
        {
            trafficLights.Add(new TrafficLight(s));
        }

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            trafficLights.ForEach(x=>x.Spinaroud());
            Console.WriteLine(string.Join(" ", trafficLights));
        }
    }
}