using System;
using System.Diagnostics;
using System.Threading;

namespace CPUTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int percentage = 100;
            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                (new Thread(() =>
                {
                    Stopwatch watch = new Stopwatch();
                    watch.Start();
                    while (true)
                    {
            if (watch.ElapsedMilliseconds > percentage)
                        {
                            Thread.Sleep(100 - percentage);
                            watch.Reset();
                            watch.Start();
                        }
                    }
                })).Start();
            }
        }
    }
}
