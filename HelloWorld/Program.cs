using HelloWorld.LeetCode._001_050;
using HelloWorld.LeetCode.Helper;
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
            var link = CSharpHelper.GenerateList(new int[] { 2, 4, 3 });
            var test = new _002_Add_Two_Numbers();
            test.AddTwoNumbers(CSharpHelper.GenerateList(new int[] { 2, 4, 3 }), CSharpHelper.GenerateList(new int[] { 5, 6, 4 }));
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
