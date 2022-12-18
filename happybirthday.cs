using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HappyBirthday
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            string awaitr;


            while (again)
            {
                string hb = "           ~                  ~\r\n     *                   *                *       *\r\n                  *               *\r\n  ~       *                *         ~    *\r\n              *       ~        *              *   ~\r\n                  )         (         )              *\r\n    *    ~     ) (_)   (   (_)   )   (_) (  *\r\n           *  (_) # ) (_) ) # ( (_) ( # (_)       *\r\n              _#.-#(_)-#-(_)#(_)-#-(_)#-.#_\r\n  *         .' #  # #  #  # # #  #  # #  # `.   ~     *\r\n           :   #    #  #  #   #  #  #    #   :\r\n    ~      :.       #     #   #     #       .:      *\r\n        *  | `-.__                     __.-' | *\r\n           |      `````\"\"\"\"\"\"\"\"\"\"\"`````      |         *\r\n     *     |         | ||\\ |~)|~)\\ /         |\r\n           |         |~||~\\|~ |~  |          |       ~\r\n   ~   *   |                                 | *\r\n           |      |~)||~)~|~| ||~\\|\\ \\ /     |         *\r\n   *    _.-|      |~)||~\\ | |~|| /|~\\ |      |-._\r\n      .'   '.      ~            ~           .'   `.  *\r\n   :      `-.__                     __.-'      :\r\n       `.         `````\"\"\"\"\"\"\"\"\"\"\"`````         .'\r\n         `-.._                             _..-'\r\n              `````\"\"\"\"-----------\"\"\"\"`````";
                Console.WriteLine(hb);
                Thread.Sleep(1009);
                Console.Beep(264, 125);
                Thread.Sleep(250);
                Console.Beep(264, 125);
                Thread.Sleep(125);
                Console.Beep(297, 500);
                Thread.Sleep(125);
                Console.Beep(264, 500);
                Thread.Sleep(125);
                Console.Beep(352, 500);
                Thread.Sleep(125);
                Console.Beep(330, 1000);
                Thread.Sleep(250);
                Console.Beep(264, 125);
                Thread.Sleep(250);
                Console.Beep(264, 125);
                Thread.Sleep(125);
                Console.Beep(297, 500);
                Thread.Sleep(125);
                Console.Beep(264, 500);
                Thread.Sleep(125);
                Console.Beep(396, 500);
                Thread.Sleep(125);
                Console.Beep(352, 1000);
                Thread.Sleep(250);
                Console.Beep(264, 125);
                Thread.Sleep(250);
                Console.Beep(264, 125);
                Thread.Sleep(125);
                Console.Beep(528, 500);
                Thread.Sleep(125);
                Console.Beep(440, 500);
                Thread.Sleep(125);
                Console.Beep(352, 250);
                Thread.Sleep(125);
                Console.Beep(352, 125);
                Thread.Sleep(125);
                Console.Beep(330, 500);
                Thread.Sleep(125);
                Console.Beep(297, 1000);
                Thread.Sleep(250);
                Console.Beep(466, 125);
                Thread.Sleep(250);
                Console.Beep(466, 125);
                Thread.Sleep(125);
                Console.Beep(440, 500);
                Thread.Sleep(125);
                Console.Beep(352, 500);
                Thread.Sleep(125);
                Console.Beep(396, 500);
                Thread.Sleep(125);
                Console.Beep(352, 1000);
                Console.WriteLine("Play again? y/n");
                awaitr = Console.ReadLine();
                awaitr = awaitr.ToLower();

                if (awaitr == "y")
                {
                    Console.Clear();
                    again = true;
                }

                else if (awaitr == "n")
                {
                    again = false;
                    Console.WriteLine("Exiting.");
                }
            }
            


        
        }
     }
}
