using HelloWorld.LeetCode._001_050;
using HelloWorld.Logical_Problems;
using System;

namespace HelloWorld.exercise
{
    partial class Program
    {
        private static conditionsTest test;
        private static LoopTest loop;
        private static Array_List array;
        private static stringBuilder mass;

        static void Main(string[] args)
        {
            //test = new conditionsTest();
            //test.exec4();
            //loop = new LoopTest();
            //array = new Array_List();
            //exercise runs
            // mass = new stringBuilder();
            // mass.exec5();
            //MainStopwatch();
            //logical problems calling
            var test = new _001_Two_Sum();
            test.TwoSum(new int [] {1, 3, 6 },9);
            //test.Method3();
        }


        static void MainStopwatch()
        {
            var sw = new Stopwatch();
            while (true)
            {
                var input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "start":
                        sw.Start();
                        break;
                    case "stop":
                        Console.WriteLine(sw.Stop()); 
                        break;
                    default:
                        Console.WriteLine("Sorry didn't get that ");
                        break;
                        
                }
            }

        }

    }
}
