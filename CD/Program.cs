using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Kattis.CD
{
    public class Program
    {
       
        public static void Main(string[] args)
        {
            Cds cds = new Cds();
        }
        
    }
    public class Cds
    {
        List<string> jacksCollection = new List<string>();
        List<string> jillsCollection = new List<string>();
        List<string> testList = new List<string>();
        string[] testArray;
        int jacksCds = 0;
        int jillsCds = 0;
        int coOwnedCds = 0;
        int index = 1;
        int rowNumber = -1;
        public Cds() 
        {
            string[] input = File.ReadAllLines("./randomTestData.txt");
            
            var program = new Kattis.CD.Program();
            foreach (var item in input)
            {
                Execute(item);
            }
        }

        public void Execute(string line)
        {
            //string line;
            //testList.Add(line);
            var result = line.Split(" ");
            if (result.Length > 1)
            {
                int.TryParse(result[0], out jacksCds);
                int.TryParse(result[1], out jillsCds);
                
            }
            if (rowNumber < jacksCds && rowNumber >= 0)
            {
                jacksCollection.Add(result[0]);
                
            }
            else if (rowNumber > jacksCds)
            {
                jillsCollection.Add(result[0]);
                
            }
            if(rowNumber == jacksCds*2-1)
            {

                
                int cds = 0;
                foreach (var item in jacksCollection)
                {
                    foreach(var jillCds in jillsCollection)
                    {
                        
                    }
                    //if(jillsCollection.First(item))
                    //{
                    //    cds++;
                    //}
                }
                Console.WriteLine("Collection contains co-owned cds:" + cds.ToString());
            }
            rowNumber++;
            //else
            //{
            //    if (jacksCollection[index] == line)
            //        coOwnedCds++;

            //    index++;
            //}
            //rowNumber++;  //Could be that if the list is sorted in order. When the sequence breaks - you dont have to keep looking for any more matches.
            //if(testList.Count > jacksCds ) 
            //{
            //    Console.WriteLine( "foo");
            //}
            //switch(line.Length)
            //{
            //    case 1:
            //        jacksCollection.Add(int.Parse(line));
            //        break;
            //    case 2:
            //        Console.WriteLine("Test");
            //        break; 
            //}

            //if(firstRun) 
            //{
            //string[] input = line.Split(new char[] { ' ' }, StringSplitOptions.None);
            //    int.TryParse(input[0], out jacksCds);
            //    int.TryParse(input[1], out jillsCds);
            //    firstRun = false;
            //}
            //string[] input = new string[2] { "3", "3" };
            //while ((line = Console.ReadLine()) != null)
            //{
            //string[] input = line.Split(new char[] { ' ' }, StringSplitOptions.None);
            //if (input[0] == "0")
            //break;
            //return;
            //if (line.Length > 1)
            //{
            //int.TryParse(input[0], out jacksCds);
            //int.TryParse(input[1], out jillsCds);
            //}
            //else
            //{
            //int.TryParse(input[0], out int catalogNumber);
            //if (jacksCds > jacksCollection.Count)
            //{
            //    jacksCollection.Add(catalogNumber);
            //}
            //else
            //{
            //    if (index < jacksCds)
            //        if (jacksCollection[index] == catalogNumber)
            //            coOwnedCds++;
            //    index++;
            //}
            //}

            //Console.WriteLine(coOwnedCds);
        }
    }
}
