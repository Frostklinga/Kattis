using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Serilog.Sinks.SystemConsole;
using Serilog.Core;
using MethodTimer;

namespace Kattis.CD
{
    public class Program
    {
        
        [Time]
        public static void Main(string[] args)
        {
            if(args.Length == 0) 
                args = new string[] { "file" };
            InputHelper inputHelper;
            if (args[0] == "file")
                inputHelper = new InputHelper(InputHelper.InputOption.File);
            else
                inputHelper = new InputHelper(InputHelper.InputOption.StandardInput);
            ProcessInput processInput = new ProcessInput(inputHelper);
            processInput.ValidateData();
            Console.WriteLine("The end");
            //string[] input;

            //HashSet<string> JacksCollection = new HashSet<string>();
            //HashSet<string> JillsCollection = new HashSet<string>();

            //HashSet<string> intersection = new HashSet<string>();
            //int lineCounter = 0;
            //int jacksCds = 0;
            //int jillsCds = 0;
            //string line = "";
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //Console.WriteLine("start processing");

            //while ((line = Console.ReadLine()) != null)
            //{
            //    input = line.Split(new char[] { ' ' }, StringSplitOptions.None);
            //    //foreach (var line in File.ReadAllLines(file))
            //    if (input.Length > 1)
            //    {
            //        //The end
            //        if (line == "0 0")
            //        {
            //            intersection = new HashSet<string>(JacksCollection);
            //            intersection.IntersectWith(JillsCollection);
            //            Console.WriteLine(intersection.Count);
            //            JacksCollection.Clear();
            //            JillsCollection.Clear();
            //            intersection.Clear();
            //            jacksCds = 0;
            //            jillsCds = 0;
            //            lineCounter = 0;
            //            //Console.WriteLine("End of collection");
            //        }
            //        //Console.WriteLine("New collection initiated");
            //        //otherwise its a beginning of a new collection
            //        jacksCds = int.Parse(input[0]);
            //        jillsCds = int.Parse(input[1]);
            //        JacksCollection.Clear();
            //        JillsCollection.Clear();
            //        intersection.Clear();
            //        lineCounter = 0;
            //    }


            //    else if (lineCounter < jacksCds)
            //    {
            //        JacksCollection.Add(line);
            //        lineCounter++;
            //    }
            //    else
            //    {
            //        JillsCollection.Add(line);
            //        lineCounter++;
            //    }
        //}
        }
    }
    
}


//public static void ProcessData(string[] input)
//{
//    HashSet<string> JacksCollection = new HashSet<string>();
//    HashSet<string> JillsCollection = new HashSet<string>();
//    HashSet<string> intersection = new HashSet<string>();
//    int lineCounter = 0;
//    int jacksCds = 0;
//    int jillsCds = 0;

//    foreach (var line in input)
//    {
//        if (line == "0 0")
//        {
//            intersection = new HashSet<string>(JacksCollection);
//            intersection.IntersectWith(JillsCollection);
//            Console.WriteLine(intersection.Count);
//            JacksCollection.Clear();
//            JillsCollection.Clear();
//            intersection.Clear();
//            jacksCds = 0;
//            jillsCds = 0;
//            lineCounter = 0;
//            break;
//        }
//        input = line.Split(new char[] { ' ' }, StringSplitOptions.None);
//        if (input.Length > 1)
//        {
//            jacksCds = int.Parse(input[0]);
//            jillsCds = int.Parse(input[1]);
//            JacksCollection.Clear();
//            JillsCollection.Clear();
//            intersection.Clear();
//            lineCounter = 0;
//        }
//        else if (lineCounter < jacksCds)
//        {
//            JacksCollection.Add(line);
//            lineCounter++;
//        }
//        else
//        {
//            lineCounter++;
//            JillsCollection.Add(line);
//        }
//    }
//}
