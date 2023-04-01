```C#
using System;

internal class Program
{
    public static void Main(string[] args)
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            string[] input = line.Split(new char[] { ' ' }, StringSplitOptions.None);
        }
    }
}

//ReadInputFromFile debug = new ReadInputFromFile();
public class ReadInputFromFile
{
    string fileName = "A.0.in";
    public string[] Input { get; private set; }
    public ReadInputFromFile()
    {
        Input = File.ReadAllLines(fileName);
    }
}
```