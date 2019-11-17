using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            Greeting();
            while (true)
            {
                //int correctNumb = 5;

                Random randNumb = new Random();
                int correctNumb = randNumb.Next(0, 10);

                int guess = 0;

                Console.WriteLine("Guess a number between 0 and 10");

                while (guess != correctNumb)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMssg(ConsoleColor.Red, "Enter Valid Number ");
                        continue;
                    }

                    guess = int.Parse(input);
                    if (guess != correctNumb)
                    {
                        PrintColorMssg(ConsoleColor.Red, "Wrong number, guesss another one ");
                    }
                    if (guess > 10)
                    {
                        PrintColorMssg(ConsoleColor.DarkGray, "See the limit");
                    }
                }
                PrintColorMssg(ConsoleColor.DarkYellow, "Your guess is correct");
                Console.WriteLine("Play Again? Y/N");
                string reply = Console.ReadLine().ToUpper();
                if (reply == "Y")
                {
                    continue;
                }
                else if (reply == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

        }
        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "HAbd";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0} : Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }

        static void Greeting()
        {
            Console.WriteLine("Write your name ");
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, lets play a game ...", inputName);
        }

        static void PrintColorMssg(ConsoleColor color, string PrintMssg)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(PrintMssg);
            Console.ResetColor();
        }
    }
}
