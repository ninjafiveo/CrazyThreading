using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            RunCrazyPC();
        }

        static void RunNoThreading()
        {
            ThreadingSamples.NoThreading.NoThreadHere();
        }

        static void RunThreadingSampleOne()
        {
            ThreadingSamples.ThreadingSampleOne.DemoThread();
        }

        static void RunCrazyPC()
        {
            ThreadingSamples.CrazyPC.CrazyFunctionCall();
        }
    }
}
