using System;
using System.Collections.Generic;

namespace AOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var testLimit = 10000000;
            var testList = new List<int>();

            for (var i = 0; i < testLimit; i++)
                testList.Add(i);

            LoopSpeedTester.StartTest(testList);

            Console.WriteLine("THE END");
            Console.ReadLine();
        }
    }
}
