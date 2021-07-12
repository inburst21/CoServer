
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;

namespace Redux.Utility
{
    class COLogger
    {
        private static ConcurrentDictionary<string, Stopwatch> timers = new ConcurrentDictionary<string, Stopwatch>();

        public static void StartTimer(string timer)
        {
            var currTimer = timers.GetOrAdd(timer, new Stopwatch());
            currTimer.Restart();
        }

        public static void StopTimer(string timer)
        {
            Stopwatch stopwatch = timers[timer];
            stopwatch.Stop();

            TimeSpan timeTaken = stopwatch.Elapsed;
            Console.WriteLine(timer + " - Time taken: " + timeTaken.ToString(@"m\:ss\.fff"));
            stopwatch.Reset();
        }
    }
}