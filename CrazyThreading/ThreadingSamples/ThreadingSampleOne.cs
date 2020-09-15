using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CrazyThreading.ThreadingSamples
{
    class ThreadingSampleOne
    {
        public static void DemoThread()
        {
            Thread sampleThread1 = new Thread(new ThreadStart(SampleThread1));//This requires a function to pass through it. Otherwise there is nothing to run/thread.
            Thread sampleThread2 = new Thread(new ThreadStart(SampleThread2));
            Thread sampleThread3 = new Thread(new ThreadStart(SampleThread3));

            sampleThread1.Start();
            sampleThread2.Start();
            sampleThread3.Start();

            Console.ReadKey();
            sampleThread1.Abort();
            sampleThread2.Abort();
            sampleThread3.Abort();
        }
        static void SampleThread1()
        {
            while (true)
            {
                Console.WriteLine("ARRRGH THREAD 1... Thats Cappin yo.");
                Thread.Sleep(5000);
            }
        }
        static void SampleThread2()
        {
            while (true)
            {
                Console.WriteLine("You Boppin Thread 2.");
                Thread.Sleep(1000);
            }
        }

        static void SampleThread3()
        {
            double divisibleBy = 3;
            double countToNumber = 20;
            double theSum = 0;

                for (int i = 0; i <= countToNumber; i++)
                {
                    if (i % divisibleBy == 0)
                    {
                        Console.WriteLine($"{i} is divisible by {divisibleBy}.");
                        theSum = theSum + i;
                    Console.Beep();
                    Thread.Sleep(2000);
                    }
                }
                Console.WriteLine($"The sum of all the numbers divisible by {divisibleBy} and {countToNumber} is {theSum}.");
        }
    }
}

/*
Documentation:
https://docs.microsoft.com/en-us/dotnet/api/system.threading.thread?view=netcore-3.1

https://docs.microsoft.com/en-us/dotnet/standard/threading/using-threads-and-threading


*/
