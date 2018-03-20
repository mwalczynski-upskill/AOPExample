using System;
using System.Diagnostics;
using PostSharp.Aspects;
using PostSharp.Serialization;

namespace AOPExample
{
    [PSerializable]
    [AttributeUsage(AttributeTargets.Method)]
    public class ExecutionTimeCounterAttribute : OnMethodBoundaryAspect
    {
        private static readonly Stopwatch Timer = new Stopwatch();

        public override void OnEntry(MethodExecutionArgs args)
        {
            Timer.Start();
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            var timeInMilliseconds = Timer.ElapsedMilliseconds;
            Timer.Restart();
            Console.WriteLine($"Execution lasted for {timeInMilliseconds} ms.\n");
        }
    }
}
