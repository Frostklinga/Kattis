using MethodTimer;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis.CD
{
    public class InputRecordModel
    {
        int jacksCds, jillsCds;
        public int JacksCds
        {
            get { return jacksCds; }
            set { jacksCds = value; }
        }
        public int JillsCds
        {
            get { return jillsCds; }
            set { jillsCds = value; }
        }
        public readonly string EndOfCdSet = "0 0";
        public HashSet<string> JacksSetOfCds = new HashSet<string>();
        public HashSet<string> JillsSetOfCds = new HashSet<string>();
        public bool SetHasValidStart = false;
        public bool SetHasValidEnd = false;
        public InputRecordModel() { }
        
        public void Add(string cd)
        {
            try
            {
                if (cd == EndOfCdSet)
                    return;
                var input = cd.Split(new char[] { ' ' }, StringSplitOptions.None);
                if (input.Length == 2)
                {
                    int jacks = 0;
                    int jills = 0;
                    int.TryParse(input[0], out jacks);
                    int.TryParse(input[1], out jills);
                    if (jacks > 0 && jills > 0)
                    {
                        JacksCds = jacks;
                        JillsCds = jills;
                        return;
                    }
                    return;
                }
                if (JacksSetOfCds.Count < JacksCds)
                    JacksSetOfCds.Add(cd);
                else
                    JillsSetOfCds.Add(cd);
            }
            catch (Exception e)
            {
                GeneralLogging.Log(e.Message);
            }

        }
    }
}
