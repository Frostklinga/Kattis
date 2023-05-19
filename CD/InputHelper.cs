using MethodTimer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis.CD
{
    public class InputHelper
    {
        string cdProjectTestDataFiles = @"C:\Users\alkal\source\repos\Kattis\Tests\CD\inputData\";
        //var testDataFiles = Directory.EnumerateFiles(path, "*.dat");
        public List<InputRecordModel>? listOfInputRecords;
        public InputRecordModel? inputRecord;
        public InputHelper(InputOption option)
        {
            if (option == InputOption.StandardInput)
                inputRecord = ReadFromStandardInput();
            else
               listOfInputRecords = ReadInputDataFromFile(cdProjectTestDataFiles);
        }
        [Time]
        public InputRecordModel ReadFromStandardInput()
        {
            InputRecordModel inputRecordModel = new InputRecordModel();
            string line = "";
            while ((line = Console.ReadLine()) != null)
            {
                inputRecordModel.Add(line);
            }
            return inputRecordModel;
        }
        [Time]
        public List<InputRecordModel> ReadInputDataFromFileEffectivly(string path)
        {
            listOfInputRecords = new List<InputRecordModel>();
            HashSet<string> input = new HashSet<string>();
            InputRecordModel inputRecordModel;
            var testDataFiles = Directory.EnumerateFiles(path, "*.dat");
            foreach (var file in testDataFiles) 
            { 
                var lines = File.ReadAllLines(file);
                inputRecordModel = new InputRecordModel();
                for (int i = 0; i < lines.Count(); i++)
                {
 

                }
            }
            return listOfInputRecords;
        }
        public string ProcessLine(string line, InputRecordModel model, List<InputRecordModel> list)
        {
            if (line == model.EndOfCdSet)
            {
                model.SetHasValidEnd = true;
                listOfInputRecords.Add(inputRecordModel);
                inputRecordModel = new InputRecordModel();
            }
        }
        [Time]
        public List<InputRecordModel> ReadInputDataFromFile(string path)
        {
            listOfInputRecords = new List<InputRecordModel>();
            HashSet<string> input = new HashSet<string>();
            InputRecordModel inputRecordModel;
            var testDataFiles = Directory.EnumerateFiles(path, "*.dat");
            foreach (var file in testDataFiles)
            {
                var lines = File.ReadAllLines(file);
                inputRecordModel = new InputRecordModel();
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i] == inputRecordModel.EndOfCdSet)
                    { 
                        inputRecordModel.SetHasValidEnd = true;
                        listOfInputRecords.Add(inputRecordModel);
                        inputRecordModel = new InputRecordModel();
                    }
                    if (lines[i].Split(" ").Count() == 2)
                    {
                        int jacks = 0;
                        int jills = 0;
                        var split = lines[i].Split(' ');

                        int.TryParse(split[0], out jacks);
                        int.TryParse(split[1], out jills);
                        if(jacks > 0 && jills > 0)
                        {
                            inputRecordModel = new InputRecordModel();
                            inputRecordModel.JacksCds = jacks;
                            inputRecordModel.JillsCds = jills;
                            inputRecordModel.SetHasValidStart = true;
                        }
                    }
                    //if (lines[i].Contains(' '))
                    //{
                    //    Console.WriteLine("Start of cd set");
                    //    listOfInputRecords.Add(inputRecordModel);
                    //    var split = lines[i].Split(" ");
                    //    inputRecordModel = new InputRecordModel();
                    //    int jacks = 0; 
                    //    int jills = 0;
                    //    int.TryParse(split[0], out jacks);
                    //    int.TryParse(split[1], out jills);
                    //    inputRecordModel.JacksCds = jacks;
                    //    inputRecordModel.JillsCds = jills;
                    //}
                    else if(inputRecordModel.SetHasValidStart)
                    {
                        inputRecordModel.Add(lines[i]);
                    }

                }
                listOfInputRecords.Add(inputRecordModel);
            }
            return listOfInputRecords;
        }
        public enum InputOption
        {
            StandardInput,
            File
        }
    }
}
