using System;
using System.Diagnostics;
using PostSharp.Aspects;
using PostSharp.Serialization;

namespace AOPExample
{
    [PSerializable]
    public class ExecutionTimeCounterAttribute : OnMethodBoundaryAspect
    {
        private static readonly Stopwatch Stopwatch = new Stopwatch();

        public override void OnEntry(MethodExecutionArgs args)
        {
            Stopwatch.Start();
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            var timeInMilliseconds = Stopwatch.ElapsedMilliseconds;
            Stopwatch.Reset();
            Console.WriteLine($"Execution lasted for {timeInMilliseconds} ms.\n");
        }
    }
}
