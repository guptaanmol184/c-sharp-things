using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArithmaticExpression
{
    class Program
    {
        static void Main(string[] args)
        {

            string arithmaticExp;
            Console.Write("Enter arithmatic expressions: ");
            arithmaticExp = Console.ReadLine();

            ArrayList numbers = NumberDetector.NumberList(arithmaticExp);
            ArrayList operators = OperatorDetector.OperatorList(arithmaticExp);

            // print numbers and operators
            int result = (int)numbers[0];
            for(int i = 0; i < operators.Count; i++)
            {
                if((string)operators[i] == "+")
                {
                    result += (int)numbers[i + 1];
                }
                else
                {
                    result -= (int)numbers[i + 1];
                }
            }

            Console.WriteLine("Result: " + result);

            Console.ReadKey();
        }
    }

    public static class NumberDetector
    {
        static char[] delimiter = { '+','-' }; // delimiter for seperating numbers

        // takes the input string and prints the numbers appearing in the string in new lines
        public static ArrayList NumberList(string s)
        {

            ArrayList numbers = new ArrayList();
            s.Trim();  // remove leading and triling whitespaces
            string[] words = s.Split(delimiter);  // words are stored in the words array

            foreach (string w in words)
            {
                if (w != "")  // there are empty strings in the array
                    numbers.Add(int.Parse(w));
            }

            return numbers;
        }
    }

    public static class OperatorDetector
    {
        static char[] delimiter = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }; // delimiter for seperating operators

        // takes the input string and prints the operators appearing in the string in new lines
        public static ArrayList OperatorList(string s)
        {
            ArrayList operators = new ArrayList();
            s.Trim();  // remove leading and triling whitespaces
            string[] words = s.Split(delimiter);  // words are stored in the words array

            foreach (string w in words)
            {
                if (w != "")  // there are empty strings in the array
                    operators.Add(w);
            }

            return operators;
        }

       
    }
}
