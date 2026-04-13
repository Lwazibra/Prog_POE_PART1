using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace POE_PART1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(" (                   (       )            )          \r\n )\\ )      (         )\\ ) ( /(      (  ( /(   *   )  \r\n(()/((     )\\     ( (()/( )\\())   ( )\\ )\\())` )  /(  \r\n /(_))\\  (((_)    )\\ /(_)|(_)\\    )((_|(_)\\  ( )(_)) \r\n(_))((_) )\\___ _ ((_|_))   ((_)  ((_)_  ((_)(_(_())  \r\n/ __| __((/ __| | | | _ \\ / _ \\   | _ )/ _ \\|_   _|  \r\n\\__ \\ _| | (__| |_| |   /| (_) |  | _ \\ (_) | | |    \r\n|___/___| \\___|\\___/|_|_\\ \\___/   |___/\\___/  |_|    \r\n                                                     ");
            Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>>");
            Console.WriteLine("              ,\r\n     __  _.-\"` `'-.\r\n    /||\\'._ __{}_(\r\n    ||||  |'--.__\\\r\n    |  L.(   ^_\\^\r\n    \\ .-' |   _ |\r\n    | |   )\\___/\r\n    |  \\-'`:._]\r\n   \\__/;      '-.\r\n");
            Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>>");

            Console.ForegroundColor = ConsoleColor.Green;
           
            
            Greeting greet = new Greeting();
            AskName ask1 = new AskName();

            Console.WriteLine("Enter your Name: ");
            ask1.Name = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>>");

            Console.WriteLine("             ,\r\n        _.-\"` `'-.\r\n       '._ __{}_(\r\n         |'--.__\\\r\n        (   ^_\\^\r\n         |   _ |\r\n         )\\___/\r\n     .--'`:._]\r\n   /  \\      '-.\r\n");

            Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>>");


            Console.WriteLine($"{ask1.Name} Here will learn about Cyber Securty");

            
            Welcome wlc = new Welcome();
    

        }
    }
}
