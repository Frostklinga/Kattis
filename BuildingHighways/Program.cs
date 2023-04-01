// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

namespace BuildingHighways
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            var cities = Enumerable.Range(1, 5);
            
            foreach (var c in cities)
            {
                Console.WriteLine(c);
            }

        }
    }
    public class Distance
    {
        public int MyProperty { get; private set; }
        public Distance(int Ai, int Aj)
        {
            
        }
        record DistanceBetweenCities(int Ai, int Aj);
    }
}