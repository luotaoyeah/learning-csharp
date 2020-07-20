using System;
using System.IO;

namespace P12;

public class Program
{
    public static void Main(string[] args)
    {
        F01();
    }

    private static void F01()
    {
        Directory.CreateDirectory(@"D:/temp/p12/");

        string path = @"D:/temp/p12/000.txt";

        File.WriteAllText(path, "HELLO WORLD");

        string text = File.ReadAllText(path);
        Console.WriteLine(text);

        Console.Read();
    }
}
