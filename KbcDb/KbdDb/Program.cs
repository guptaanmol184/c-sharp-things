using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace KbdDb
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
                while (c != 'A' && c != 'B' && c != 'C' && c != 'D')
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

        static public int CheckAnswer(char AnswerInput, char CorrectAnswer, int PrizeMoney, ref int QuestionNo)
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

        // prints question and returns the correct answer
        // if question does not exist the prints error message and returns 'X'
        // if other exception in try block then returns 'Z'
        static public char PrintQuestion(int QuestionNo)
        {
            SqlConnection conn;
            SqlDataReader reader;
            string StringCorrectAnswer;
            char CharCorrectAnswer;

            try
            {
                conn = new SqlConnection(Properties.Settings.Default.QuesBankConn);
                conn.Open();

                reader = new SqlCommand("SELECT * FROM QUESTIONS WHERE QNO = " + QuestionNo, conn).ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    //Console.Clear();
                    Console.WriteLine("{0}. {1}\nA] {2}\nB] {3}\nC] {4}\nD] {5} ", QuestionNo, reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                    StringCorrectAnswer = reader.GetString(6);
                    CharCorrectAnswer = StringCorrectAnswer[0];
                }
                else
                {
                    Console.WriteLine("System Error: No Question found.");
                    CharCorrectAnswer = 'X';
                }

                reader.Close();
                return CharCorrectAnswer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 'Z';
            }

        }

        // Conducts a stage
        // Input: prize monwy for this stage and the question number to give
        static public void ConductStage(ref int StagePrizeMoney,ref int QuestionNo)
        {
            Char CorrectAnswer;
            Char AnswerInput;

            Console.Clear();
            Console.WriteLine("\nHere is question {0} is for {1:#,##,##,##0} rupees.\n", QuestionNo, StagePrizeMoney);
            CorrectAnswer = PrintQuestion(QuestionNo);
            AnswerInput = GetInput();
            StagePrizeMoney = CheckAnswer(AnswerInput, CorrectAnswer, StagePrizeMoney,ref QuestionNo);
        }

        static void Main(string[] args)
        { 

            Console.WriteLine("\nWelcome to KAUN BANEGA CROREPATI!!!");

            // set up state from question 1
            string PlayerName = "";
            int QuestionNo = 1; // Stores the question number player is on
            //char AnswerInput;    // Stores the Answer Input by the player
            int PrizeMoney = 0;  // Stores the total prize money of the player

            Console.Write("\nPlease enter your name: ");
            PlayerName = Console.ReadLine();

            //cheat code
            PlayerName.ToLower();
            if(PlayerName == "lucifer" || PlayerName == "darklord")
            {
                Console.WriteLine("\n******Cheat Code Activated!!*********\n");
                Console.WriteLine("You have won the game!! ^.^");
                Console.WriteLine("\n\n\nPeace.");
                PrizeMoney = 100000000;
                QuestionNo = 11;
            }

            PrintRules(); // print game rules

            Console.Write("\n{0}, if you are ready to play then press any key...", PlayerName);
            Console.ReadKey();

            
            while (true)
            {
                switch (QuestionNo)
                {
                    case 0:
                        {
                            Console.Clear();
                            Console.WriteLine("\nSorry...");
                            Console.WriteLine("Unfortunately that was a wrong answer...");
                            Console.WriteLine("It was great having you here!");
                            Console.WriteLine("You won a total of {1:#,##,##,##0} rupees!", PlayerName, PrizeMoney);
                            Console.WriteLine("Better luck next time.");
                            Console.Write("\nPress any key to continue...");
                            Console.ReadKey();
                            QuestionNo = 11; // Do to exit splash screen
                            break;
                        }
                    case 1:
                        { 
                            PrizeMoney = 5000;
                            ConductStage(ref PrizeMoney,ref QuestionNo);
                            break;
                        }
                    case 2:
                        {
                            PrizeMoney = 10000;
                            ConductStage(ref PrizeMoney, ref QuestionNo);
                            break;
                        }
                    case 3:
                        {
                            PrizeMoney = 25000;
                            ConductStage(ref PrizeMoney, ref QuestionNo);
                            break;
                        }
                    case 4:
                        {
                            PrizeMoney = 50000;
                            ConductStage(ref PrizeMoney, ref QuestionNo);
                            break;
                        }
                    case 5:
                        {
                            PrizeMoney = 100000;
                            ConductStage(ref PrizeMoney, ref QuestionNo);
                            break;
                        }
                    case 6:
                        {
                            PrizeMoney = 500000;
                            ConductStage(ref PrizeMoney, ref QuestionNo);
                            break;
                        }
                    case 7:
                        {
                            PrizeMoney = 1000000;
                            ConductStage(ref PrizeMoney, ref QuestionNo);
                            break;
                        }
                    case 8:
                        {
                            PrizeMoney = 2500000;
                            ConductStage(ref PrizeMoney, ref QuestionNo);
                            break;
                        }
                    case 9:
                        {
                            PrizeMoney = 5000000;
                            ConductStage(ref PrizeMoney, ref QuestionNo);
                            break;
                        }
                    case 10:
                        {
                            PrizeMoney = 10000000;
                            ConductStage(ref PrizeMoney, ref QuestionNo);
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
