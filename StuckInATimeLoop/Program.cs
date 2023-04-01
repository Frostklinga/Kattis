using System;

internal class Program
{
    public static void Main(string[] args)
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            string[] input = line.Split(new char[] { ' ' }, StringSplitOptions.None);
            string magicSpell = "Abracadabra";

            int count;
            int.TryParse(input[0], out count);
            for (int i = 1; i < count + 1; i++)
            {
                Console.WriteLine($"{i} {magicSpell}");
            }
        }
    }
}