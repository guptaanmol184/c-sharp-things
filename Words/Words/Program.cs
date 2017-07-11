using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;

            Console.Write("Enter a string: ");
            input = Console.ReadLine();
            input = input.Trim();

            Words.PrintState(input);

            Console.ReadKey();
        }

        public static class Words
        {
            static char[] delimiter = { ' ', ',', '\t', '!', '.', ':', '"', '?', ';', '(', ')', '@', '-', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }; // delimiter for seperating words
            static char[] lower = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            static char[] upper = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            // takes the input string and prints the words appearing in the string in new lines
            public static void PrintWords( string s )
            {
                s.Trim();  // remove leading and triling whitespaces
                string[] words = s.Split(delimiter);  // words are stored in the words array

                foreach (string w in words)
                {
                    if (w != "")  // there are empty strings in the array
                        Console.WriteLine("\"" + w + "\"");
                }
            }

            public static void PrintState(string s)
            {
                int wordCtr = 0;
                int upperCtr = 0;
                int lowerCtr = 0;
                int upperlowerCtr = 0;

                s.Trim();  // remove leading and triling whitespaces
                string[] words = s.Split(delimiter);  // words are stored in the words array

                foreach (string w in words)
                {
                    if (w != "")  // there are empty strings in the array
                    {
                        wordCtr++;  // new word found :)
                        int intState = WordState(w);
                        string[] stringState = { "lower", "upper", "upperlower" }; 
                        Console.WriteLine("\"" + w + "\"" + ": " + stringState[intState]);

                        if (intState == 0)
                            lowerCtr++;
                        else if (intState == 1)
                            upperCtr++;
                        else
                            upperlowerCtr++;
                    }
                }

                // print analysis

                Console.WriteLine("Total words: " + wordCtr);
                Console.WriteLine("Total lower case words: " + lowerCtr);
                Console.WriteLine("Total upper case words: " + upperCtr);
                Console.WriteLine("Total mixed case words: " + upperlowerCtr);
            }

            
            //  0 -> lower
            //  1 -> UPPER
            //  2 -> Upperlower
            public static int WordState( string word)
            {
                bool isUpper = false;
                bool isLower = false;
                

                foreach(char c in word)
                {
                    if (lower.Contains(c))
                        isLower = true;
                    if (upper.Contains(c))
                        isUpper = true;

                    if (isLower == true && isUpper == true)
                        return 2;
                }

                if (isLower == true)
                    return 0;
                else
                    return 1;
            }
        }
    }
}
