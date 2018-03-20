using System;
using System.Collections.Generic;

namespace AOPExample
{
    public static class LoopSpeedTester
    {
        public static void StartTest(IList<int> testCollection)
        {
            var numberOfElements = testCollection.Count;

            Console.WriteLine($"For loop for {numberOfElements} elements:");
            TestForLoop(testCollection);

            Console.WriteLine($"Another for loop for for {numberOfElements} elements:");
            TestForLoop2(testCollection);

            Console.WriteLine($"Reversed for loop for {numberOfElements} elements:");
            TestForReversed(testCollection);

            Console.WriteLine($"Foreach loop for {numberOfElements} elements:");
            TestForEachLoop(testCollection);

            Console.WriteLine($"While loop for {numberOfElements} elements:");
            TestWhileLoop(testCollection);
        }

        [ExecutionTimeCounter]
        private static void TestForLoop(IList<int> testCollection)
        {
            var numberOfElements = testCollection.Count;
            for (var i = 0; i < numberOfElements; i++)
            {
                if (testCollection[i] == testCollection[numberOfElements - 1])
                {
                    Console.WriteLine("Last element");
                }
            }
        }

        [ExecutionTimeCounter]
        private static void TestForLoop2(IList<int> testCollection)
        {
            var numberOfElements = testCollection.Count;
            for (var i = 0; i < testCollection.Count; i++)
            {
                if (testCollection[i] == testCollection[numberOfElements - 1])
                {
                    Console.WriteLine("Last element");
                }
            }
        }

        [ExecutionTimeCounter]
        private static void TestForReversed(IList<int> testCollection)
        {
            var numberOfElements = testCollection.Count;
            for (var i = numberOfElements; i > 0; i--)
            {
                if (testCollection[i - 1] == testCollection[0])
                {
                    Console.WriteLine("Last element");
                }
            }
        }

        [ExecutionTimeCounter]
        private static void TestForEachLoop(IList<int> testCollection)
        {
            var numberOfElements = testCollection.Count;
            foreach (var i in testCollection)
            {
                if (i == testCollection[numberOfElements - 1])
                {
                    Console.WriteLine("Last element");
                }
            }
        }


        [ExecutionTimeCounter]
        private static void TestWhileLoop(IList<int> testCollection)
        {
            var numberOfElements = testCollection.Count;
            var i = 0;
            while (i++ != numberOfElements)
            {
                if (i == testCollection[numberOfElements - 1])
                {
                    Console.WriteLine("Last element");
                }

            }
        }
    }
}
