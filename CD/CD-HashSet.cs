using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD
{
    public class CD_HashSet
    {
        HashSet<string> jackCds;
        HashSet<string> jillCds;
        string initialRow;
        string endOfFile = "0 0";
        static string filename = "randomTestData.txt";
        public static string[] Input { get; private set; }
        public CD_HashSet()
        {
            
        }

        public void ReadInputFromFile()
        {
            Input = File.ReadAllLines(filename);
        }

        public void ProcessInput()
        {
            foreach (string input in Input)
            {
                if(input.Split(" ").Length > 1) 
                {
                    var cdSetSize = input.Split(" ");

                }
            }
        }
    }
}
