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
            Thread crazyKeyboardThread = new Thread(new ThreadStart(CrazyKeyboardThread));

            //Start Thread
            crazyMouseThread.Start();
            crazyKeyboardThread.Start();

            //Wait for user input
            //Console.ReadKey();

            //Kill the Thread
            crazyMouseThread.Abort();
            //crazyKeyboardThread.Abort();
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
            //Need Send.SendWait Method
            Console.WriteLine("CrazyKeyboardThread Started.");

            while (true)
            {
                //Create random letters. But letters need associated with a number. To do that use the ASCII table - http://www.asciitable.com

                char key = (char)(_random.Next(50) + 45);
                //SendKeys.SendWait("b");

                if (_random.Next(2)==0)
                {
                    key = Char.ToLower(key);
                }
                SendKeys.SendWait(key.ToString());
                Thread.Sleep(500);

            }
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
 * https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.sendkeys.sendwait?view=netcore-3.1
 * 
 * https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.sendkeys.send?view=netcore-3.1
 * 
 * */
