using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaunBanegaCrorepatiSprint1
{
    class KBCProgram
    {

        // fuction to get input from player
        static public char GetInput()
        {
            char c;

            try
            {
                Console.Write("\nYour answer: ");
                c = Convert.ToChar(Console.ReadLine().ToUpper());
                while(c != 'A' && c != 'B' && c != 'C' && c != 'D')
                { 
                    Console.WriteLine("Please enter one of A, B, C, D.");
                    Console.Write("\nYour answer: ");
                    c = Convert.ToChar(Console.ReadLine().ToUpper());
                }
            }
            catch (Exception e)
            {
                Console.Write("Error: ");
                Console.WriteLine(e.Message);
                Console.WriteLine("\nPlease enter a single character.");

                Console.Write("\nYour answer: ");
                c = Convert.ToChar(Console.ReadLine().ToUpper());
                while (c != 'A' && c != 'B' && c != 'C' && c != 'D')
                {
                    Console.WriteLine("Please enter one of A, B, C, D.");
                    Console.Write("\nYour answer: ");
                    c = Convert.ToChar(Console.ReadLine().ToUpper());
                }
            }

            return c;
        }

        static public int CheckAnswer(char AnswerInput, char CorrectAnswer,int PrizeMoney,ref int QuestionNo)
        {
            if (AnswerInput == CorrectAnswer)
            {
                Console.WriteLine("\nCorrect Answer!");
                Console.WriteLine("You win {0:#,##,##,##0} rupees!!", PrizeMoney);
                Console.Write("\nPress any key to continue...");
                Console.ReadKey();
                QuestionNo++;
            }
            else
                QuestionNo = 0;

            return PrizeMoney;
        }

        static public void PrintRules()
        {
            Console.WriteLine("\n            RULES OF THE GAME");
            Console.WriteLine("-> There will be a total of 10 questions.");
            Console.WriteLine("-> Each question will have 4 options - A, B, C, D.");
            Console.WriteLine("-> There is only one correct answer to each question.");
            Console.WriteLine("-> You have to answer in A, B, C, D.");
            Console.WriteLine("-> Every correct answer will take you to the next stage.");
            Console.WriteLine("-> INCORRECT answer will take place in elimination.");
        }

        static void Main(string[] args)
        {

            Console.WriteLine("\nWelcome to KAUN BANEGA CROREPATI!!!");

            // set up state from question 1
            string PlayerName = "";
            int QuenstionNo = 1; // Stores the question number player is on
            char AnswerInput;    // Stores the Answer Input by the player
            int PrizeMoney = 0;  // Stores the total prize money of the player

            Console.Write("\nPlease enter your name: ");
            PlayerName = Console.ReadLine();
            PrintRules(); // print game rules

            Console.Write("\n{0}, if you are ready to play then press any key...",PlayerName);
            Console.ReadKey();

            while(true)
            {
                switch (QuenstionNo)
                {
                    case 0:
                        {
                            Console.Clear();
                            Console.WriteLine("\nSorry...");
                            Console.WriteLine("Unfortunately that was a wrong answer...");
                            Console.WriteLine("It was great having you here!");
                            Console.WriteLine("You won a total of {1:#,##,##,##0} rupees!", PlayerName,PrizeMoney);
                            Console.WriteLine("Better luck next time.");
                            Console.Write("\nPress any key to continue...");
                            Console.ReadKey();
                            QuenstionNo = 11; // Do to exit splash screen
                            break;
                        }
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("\nHere is question {0} is for 5,000 rupees.", QuenstionNo);
                            Console.WriteLine("\n1. Who is the creator of the linux kernel ?");
                            Console.WriteLine("\nA] Linux Torvalds");
                            Console.WriteLine("B] Steve Jobs");
                            Console.WriteLine("C] Elon Musk");
                            Console.WriteLine("D] Bill Gates");
                            AnswerInput = GetInput();
                            PrizeMoney = CheckAnswer(AnswerInput, 'A',5000,ref QuenstionNo);
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("\nHere is question {0} is for 10,000 rupees.", QuenstionNo);
                            Console.WriteLine("\n1. Who is the owner of Tesla Motors ?");
                            Console.WriteLine("\nA] Sachin Bansal");
                            Console.WriteLine("B] Baba Ramdev");
                            Console.WriteLine("C] Elon Musk");
                            Console.WriteLine("D] Akshay Kumar");
                            AnswerInput = GetInput();
                            PrizeMoney = CheckAnswer(AnswerInput, 'C', 10000, ref QuenstionNo);
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("\nHere is question {0} is for 25,000 rupees.", QuenstionNo);
                            Console.WriteLine("\n1. What is the latest version of the Android operating system ?");
                            Console.WriteLine("\nA] Android N");
                            Console.WriteLine("B] Android L");
                            Console.WriteLine("C] Android M");
                            Console.WriteLine("D] Android O");
                            AnswerInput = GetInput();
                            PrizeMoney = CheckAnswer(AnswerInput, 'D', 25000, ref QuenstionNo);
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("\nHere is question {0} is for 50,000 rupees.", QuenstionNo);
                            Console.WriteLine("\n1. Which country has the fastest supercomputer in the world ?");
                            Console.WriteLine("\nA] USA");
                            Console.WriteLine("B] Japan");
                            Console.WriteLine("C] China");
                            Console.WriteLine("D] Russia");
                            AnswerInput = GetInput();
                            PrizeMoney = CheckAnswer(AnswerInput, 'C', 50000, ref QuenstionNo);
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            Console.WriteLine("\nHere is question {0} is for 1,00,000 rupees.", QuenstionNo);
                            Console.WriteLine("\n1. Which company is the manufacturer of a supercomputer called 'Watson' ?");
                            Console.WriteLine("\nA] IBM");
                            Console.WriteLine("B] Microsoft");
                            Console.WriteLine("C] Apple");
                            Console.WriteLine("D] Dell");
                            AnswerInput = GetInput();
                            PrizeMoney = CheckAnswer(AnswerInput, 'A', 100000, ref QuenstionNo);
                            break;
                        }
                    case 6:
                        {
                            Console.Clear();
                            Console.WriteLine("\nHere is question {0} is for 5,00,000 rupees.", QuenstionNo);
                            Console.WriteLine("\n1. What is the name of the new OS recently launched by google ?");
                            Console.WriteLine("\nA] Fuschsia");
                            Console.WriteLine("B] Sun Temple");
                            Console.WriteLine("C] Sail Fish");
                            Console.WriteLine("D] Arch");
                            AnswerInput = GetInput();
                            PrizeMoney = CheckAnswer(AnswerInput, 'A', 500000, ref QuenstionNo);
                            break;
                        }
                    case 7:
                        {
                            Console.Clear();
                            Console.WriteLine("\nHere is question {0} is for 10,00,000 rupees.", QuenstionNo);
                            Console.WriteLine("\n1. Mario is created by which company ?");
                            Console.WriteLine("\nA] Steam");
                            Console.WriteLine("B] Nickelodeon");
                            Console.WriteLine("C] Sega");
                            Console.WriteLine("D] Nintendo");
                            AnswerInput = GetInput();
                            PrizeMoney = CheckAnswer(AnswerInput, 'D', 1000000, ref QuenstionNo);
                            break;
                        }
                    case 8:
                        {
                            Console.Clear();
                            Console.WriteLine("\nHere is question {0} is for 25,00,000 rupees.", QuenstionNo);
                            Console.WriteLine("\n1. Who created the c programming language ?");
                            Console.WriteLine("\nA] Dennis Ritchie");
                            Console.WriteLine("B] Brian Kernighan");
                            Console.WriteLine("C] Thomas Cormen");
                            Console.WriteLine("D] Bjarne Stroustrup");
                            AnswerInput = GetInput();
                            PrizeMoney = CheckAnswer(AnswerInput, 'A', 2500000, ref QuenstionNo);
                            break;
                        }
                    case 9:
                        {
                            Console.Clear();
                            Console.WriteLine("\nHere is question {0} is for 50,00,000 rupees.", QuenstionNo);
                            Console.WriteLine("\n1. Which of these linux distributions is owned by Canonical Ltd ?");
                            Console.WriteLine("\nA] Arch Linux");
                            Console.WriteLine("B] Linux Mint");
                            Console.WriteLine("C] Fedora");
                            Console.WriteLine("D] Ubuntu");
                            AnswerInput = GetInput();
                            PrizeMoney = CheckAnswer(AnswerInput, 'D', 5000000, ref QuenstionNo);
                            break;
                        }
                    case 10:
                        {
                            Console.Clear();
                            Console.WriteLine("\nHere is question {0} is for 1,00,00,000 rupees.", QuenstionNo);
                            Console.WriteLine("\n1. What Desktop Environment did Ubunutu recently switch over to ?");
                            Console.WriteLine("\nA] Mate");
                            Console.WriteLine("B] Gnome");
                            Console.WriteLine("C] Unity");
                            Console.WriteLine("D] XFCE");
                            AnswerInput = GetInput();
                            PrizeMoney = CheckAnswer(AnswerInput, 'B', 10000000, ref QuenstionNo);
                            break;
                        }
                    case 11:
                        {
                            Console.Clear();
                            Console.WriteLine("\nThis game is brought to you by CoffeeTimeGames");
                            Console.WriteLine("To play more such games please go to www.coffeetimegames.com");
                            Console.WriteLine("It was great having you here!");
                            Console.Write("\nPress any key to exit...");
                            Console.ReadKey();
                            System.Environment.Exit(0);
                            break;
                        }
                    
                }
            }

        }
    }
}
