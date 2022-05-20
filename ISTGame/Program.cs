using System;
using System.Collections;
using System.Collections.Generic;
using TextToAsciiArt;

namespace ISTGame
{
    class Program
    {
        static void Main(string[] args)
        {
            IArtWriter writer = new ArtWriter();



            var settings = new ArtSetting
            {
                ConsoleSpeed = 100,
                IsBreakSpace = true,
                SpaceWidth = 2,
                Text = "█",
                BgText = "H"
            };
            returnhere:
            Console.WriteLine("Enter a difficulty. (Easy/Medium/Hard)", settings);
            string Answer = Console.ReadLine();
            string difficulty = "";
            if (Answer == "Easy" || Answer == "easy")
            {
                Console.WriteLine("You selected Easy difficulty.");
                difficulty = "Easy";
            }
            else if (Answer == "Medium" || Answer == "medium")
            {
                Console.WriteLine("You have selected Medium difficulty.");
                difficulty = "Medium";
            }
            else if (Answer == "Hard" || Answer == "hard")
            {
                Console.WriteLine("You have selected Hard difficulty");
                difficulty = "Hard";
            }
            else
            {
                Console.WriteLine("Invalid Answer.");
                goto returnhere;
            }

            int streak = 0;
        returnhere2:

            Random rnd = new Random();
            
            int rndNum1 = rnd.Next(1, 13);
            int rndNum2 = rnd.Next(1, 13);
            int rndNum3 = rnd.Next(0, 4);
            int qAnswer = 0;
            int questionnum = 1;
            Console.WriteLine("Question " + questionnum + ".");
            List<string> symbols = new List<string>();
            symbols.Add("+");
            symbols.Add("-");
            symbols.Add("x");
            symbols.Add("/");
            string symbol = symbols[rndNum3];
            Console.WriteLine("What is " + rndNum1 + " " + symbol + " " + rndNum2);
            if (symbol == "+")
            {
                qAnswer = rndNum1 + rndNum2;
            }
            else if (symbol == "-")
            {
                qAnswer = rndNum1 - rndNum2;
            }

            else if (symbol == "x")
            {
                qAnswer = rndNum1 * rndNum2;
            }
            else if (symbol == "/")
            {
                qAnswer = rndNum1 / rndNum2;
            }
            int response = Convert.ToInt32(Console.ReadLine());
            if (response == qAnswer)
            {
                Console.WriteLine("Correct!");
                streak = streak + 1;
                Console.WriteLine("Your current streak is " + streak);
                Console.Clear();
                questionnum++;
            }
            else
            {
                Console.WriteLine("Incorrect.");
                questionnum = 1;
                Console.Clear();
            }

        }
    }
}
