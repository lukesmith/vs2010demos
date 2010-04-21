using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace WhatsNewInCSharp
{
    public class ParallelLinq
    {
        public static void AsParallel()
        {
            var dataSet = Enumerable.Range(1, 1000000);
            Stopwatch sw = new Stopwatch();
            
            Console.WriteLine("Without parallel");
            sw.Start();
            Console.WriteLine(dataSet.Count(IsPrime));
            sw.Stop();
            ShowElapsedTime(sw.Elapsed);

            Console.ReadLine();
            sw.Reset();
            
            Console.WriteLine("With parallel");
            sw.Start();
            Console.WriteLine(dataSet.AsParallel().Count(IsPrime));
            sw.Stop();
            ShowElapsedTime(sw.Elapsed);
        }

        private static void ShowElapsedTime(TimeSpan ts)
        {
            Console.WriteLine("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
        }

        private static bool IsPrime(int val)
        {
            foreach (var i in Enumerable.Range(2, val))
            {
                if (val % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
