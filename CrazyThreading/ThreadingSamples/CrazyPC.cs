using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace CrazyThreading.ThreadingSamples
{
    class CrazyPC
    {
        public static Random _random = new Random();// Remember back to creating a random number. Also "_" in front of the variable helps identify it as a global variable.
        public static void CrazyFunctionCall()
        {
            //Creating Thread Objects
            Thread crazyMouseThread = new Thread(new ThreadStart(CrazyMouseThread));

            //Start Thread
            crazyMouseThread.Start();

            //Wait for user input
            Console.ReadKey();

            //Kill the Thread
            crazyMouseThread.Abort();
        }

        static void CrazyMouseThread()
        {
            Console.WriteLine("CrazyMouseThread Started");

            int moveX = 0;
            int moveY = 0;

            while (true)
            {
                moveX = _random.Next(30) - 15;
                moveY = _random.Next(30) - 15;

                Cursor.Position = new System.Drawing.Point(Cursor.Position.X + moveX, Cursor.Position.Y + moveY);
                Thread.Sleep(50);
            }


            
        }

        static void CrazyKeyboardThread()
        {

        }

        static void CrazySoundThread()
        {

        }

        static void CrazyPopupThread()
        {

        }

    }
}


/*Documentation
 * https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.cursor.position?view=netcore-3.1
 * 
 * 
 * 
 * 
 * */
