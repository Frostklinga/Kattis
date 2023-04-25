using System;
using System.Collections.Generic;

namespace Kattis.CD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HashSet<string> JacksCollection = new HashSet<string>();
            HashSet<string> JillsCollection = new HashSet<string>();

            string line;
            int lineCounter = 0;
            int jacksCds = 0;
            int jillsCds = 0;
            line = Console.ReadLine();
            string[] input = line.Split(new char[] { ' ' }, StringSplitOptions.None);
            jacksCds = int.Parse(input[0]);
            jillsCds = int.Parse(input[1]);

            while ((line = Console.ReadLine()) != null)
            {
                input = line.Split(new char[] { ' ' }, StringSplitOptions.None);
                if (line == "0 0")
                    break;

                if (lineCounter < jacksCds)
                    JacksCollection.Add(line);
                else
                    JillsCollection.Add(line);
                lineCounter++;
            }
            HashSet<string> intersection = new HashSet<string>(JacksCollection);
            intersection.IntersectWith(JillsCollection);
             
            Console.WriteLine(intersection.Count);
        }
    }
}
