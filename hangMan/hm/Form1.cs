using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hm
{
    public partial class Form1 : Form
    {
        static string[] words = {"adult", "advice", "attempt", "august", "border", "breeze", "brick",
                          "calm", "canal", "claws", "coach", "constanly", "donkey", "film",
                          "garage", "garbage", "happy", "hunter", "image", "instant", "kids",
                          "mathematics", "monkey", "neighbourhood", "official", "palace", "police",
                          "relationship", "simple", "television", "university", "zoo"};

        string randWord; // stores the selected random word
        string lettersGuessed = "";
        static int attemptCounter = 0; // 8 wrongs is dead

        public Form1()
        {
            InitializeComponent();

            initialiseGame();

            
        }

        /********************** INITIAL GAME SET **********************/
        public void initialiseGame()
        {
            MessageBox.Show("Welcome to HANGMAN!!");

            pictureBox1.Image = Image.FromFile("../../hmpics/0.png");
            

            randWord = getWord();

            displayWord();
        }

        // get random word from the words array
        public string getWord()
        {
            Random randint = new Random();
            int index = randint.Next(words.Length);

            return words[index].ToUpper();
        }

        /********************** IN GAME **********************/
        // used to set the word and also check if all letters have been identified
        public void displayWord()
        {
            string displayString = "";

            foreach(char c in randWord)
            {
                if (lettersGuessed.Contains(c))
                    displayString += c + " ";
                else
                    displayString += "_ ";
            }

            // check word found
            bool wordFound = true;
            foreach (char c in displayString)
                if (c == Convert.ToChar("_"))
                    wordFound = false;

            

            lblWord.Text = displayString.ToUpper();

            if (wordFound)
            {
                pictureBox1.Image = Image.FromFile("../../hmpics/victory.png");
                MessageBox.Show("Holy Mosses.\nYou found the word!!\nNice job ^.^");
                System.Environment.Exit(0);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // check if word contains the letter
            lettersGuessed += btn.Text;
            bool letterIsThere = containsLetter(btn);

            if(letterIsThere == true)
            {
                // display the updated word
                displayWord();

                // disable the btn
                btn.Enabled = false;
            }
            else
            {
                // no need to display as wrong guess

                //disale the btn
                btn.Enabled = false;

                // increase the counter
                attemptCounter++;

                // use counter to set image
                string basePath = "../../hmpics/" + Convert.ToString(attemptCounter) + ".png";
                pictureBox1.Image = Image.FromFile(basePath);

                if (attemptCounter == 7)
                    MessageBox.Show("One more wrong guess and you are dead lad.\nTead carefully.");

                if(attemptCounter == 8)
                {
                    MessageBox.Show("Thanks for playing the game.\nWell tried but the word was \""+ randWord.ToUpper() +"\".\nBetter luck next time.");
                    System.Environment.Exit(0);
                }

            }
            
        }

        public bool containsLetter(Button btn)
        {
            bool containsLetter = false;

            foreach (char c in randWord)
                if (c == Convert.ToChar(btn.Text))
                    containsLetter = true;

            return containsLetter;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblHidden.Text = randWord;
        }
    }
}
