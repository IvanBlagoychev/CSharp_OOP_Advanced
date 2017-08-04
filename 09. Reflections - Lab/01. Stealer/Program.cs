using System;

public class Program
{
    static void Main()
    {
        Spy spy = new Spy();

        // ==== Task 1 ==== \\
        //string result = spy.StealFieldInfo("Hacker", "username", "password");

        // ==== Task 2 ==== \\
        //string result = spy.AnalyzeAcessModifiers("Hacker");

        // ==== Task 3 ==== \\
        //string result = spy.RevealPrivateMethods("Hacker");

        // ==== Task 4 ==== \\
        string result = spy.CollectGettersAndSetters("Hacker");

        Console.WriteLine(result);
    }
}