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
            RunNoThreading();
        }

        static void RunNoThreading()
        {
            ThreadingSamples.NoThreading.NoThreadHere();
        }
    }
}
