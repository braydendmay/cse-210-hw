using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary Library = new ScriptureLibrary();
        Library.AddScripture(new Reference("John",3,16));
        Console.WriteLine("press enter to continue or type quit to finish.");
        string ans = Console.ReadLine();
        if (ans == "");
            Console.Clear();
            Console.WriteLine("YYYYYYY");

    }
}