using System.Diagnostics;

namespace Mutitasking
{
    public static class Log
    {
        private static readonly Stopwatch Clock = new();

        public static void Reset() => Clock.Restart();

        public static void Write(string message) =>
            Console.WriteLine($"[{Clock.Elapsed.TotalSeconds,4:0.0}s] {message}");
    }
}