using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyThreading.ThreadingSamples
{
    class NoThreading
    {
        public static void NoThreadHere()
        {
            NoThread1();
            NoThread2();
        }

        static void NoThread1()
        {
            while (true)
            {
                Console.WriteLine("This is THREAD 1");
            }
        }

        static void NoThread2()
        {
            while (true)
            {
                Console.WriteLine("This is 22222222");
            }
  
        }


    }
}
