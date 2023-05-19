using MethodTimer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis.CD
{
    public class ProcessInput
    {
        InputHelper helper;
        public ProcessInput(InputHelper inputHelper) 
        {
            helper = inputHelper;
        }
        [Time]
        public void ProcessSets()
        {
            var list = helper.listOfInputRecords ?? throw new NullReferenceException();
            foreach(var set in list)
            { 
                
            }
        }
        [Time]
        public void ValidateData()
        {
            var list = helper.listOfInputRecords ?? throw new NullReferenceException();
            foreach(var set in list)
            {
                foreach(var record in set.JacksSetOfCds)
                { 
                    var split = record.Split(' ');
                    if(split.Length > 1) 
                    {
                        Console.WriteLine(split);
                    }
                }
                foreach (var record in set.JillsSetOfCds)
                {
                    var split = record.Split(' ');
                    if (split.Length > 1)
                    {
                        Console.WriteLine(split);
                    }
                }
            }
        }
    }
}
