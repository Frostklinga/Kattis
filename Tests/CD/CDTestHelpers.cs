using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.CD
{
    public class CDTestHelpers
    {
        public string TestDataPath { get; private set; }
        public string[] TestDataFiles { get; init; }
        public CDTestHelpers(string testDataPath)
        {
            TestDataPath = testDataPath;
            TestDataFiles = Directory.EnumerateFiles(testDataPath, "*.dat").ToArray();
        }
        public CDTestHelpers()
        {
            string path = @"C:\Users\alkal\source\repos\Kattis\Tests\CD\inputData\";
            TestDataFiles = Directory.EnumerateFiles(path, "*.dat").ToArray();
        }
    }
    public class CollectionOfCdSets
    {
        List<SetOfCds> collectionOfSets;
        string[] Input { get; set; }
        public CollectionOfCdSets()
        {
            collectionOfSets = new List<SetOfCds>();
        }
        public void ProcessCdCollections()
        {
            string line = "";

            for (int i = 1; i < Input.Length; i++)
            {
                if (line == SetOfCds.EndOfSet)
                    break;
                var split = line.Split(" ");
                if (split.Length > 1)
                {
                    int jacks = int.Parse(split[0]);
                    int jills = int.Parse(split[1]);
                    collectionOfSets.Add(new SetOfCds(jacks, jills));
                }
                else
                    collectionOfSets.Last().AddCd(line, i);
            }
        }
        public void ReadCollectionsFromFile(string path)
        {
            Input = File.ReadAllLines(path);
        }
    }
    public class SetOfCds
    {
        //public const int EndOfSet = 0;
        public static string EndOfSet = "0 0";
        public int maximumNumberOfCds = 1000000;
        public int JacksCds { get; private set; }
        public int JillsCds { get; private set; }
        HashSet<string> JacksCdCollection { get; set; } = new HashSet<string>();
        HashSet<string> JillsCdCollection { get; set; } = new HashSet<string>();

        public SetOfCds(int jacksCds, int jillsCds)
        {
            JacksCds = jacksCds;
            JacksCds = jacksCds;
        }
        public void AddCd(string cd, int cdCounter)
        {
            if (cdCounter < JacksCds)
                JacksCdCollection.Add(cd);
            else
                JillsCdCollection.Add(cd);
        }
    }
    public class CD
    {
        public int CatalogNumber { get; private set; }
        public CD(int catalogNumber)
        {
            //Not negative

            //Not above 1 mil
            CatalogNumber = catalogNumber;
        }
    }
}
