using System;

internal class Program
{
    public static void Main(string[] args)
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            string[] input = line.Split(new char[] { ' ' }, StringSplitOptions.None);
            long firstValue = 0;
            long secondValue = 0;
            long.TryParse(input[0], out firstValue);
            long.TryParse(input[1], out secondValue);
            var result = firstValue > secondValue ? firstValue-secondValue : secondValue-firstValue;
            Console.WriteLine($"{result}");
        }
    }
}