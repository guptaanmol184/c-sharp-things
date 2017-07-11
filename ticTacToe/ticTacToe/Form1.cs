using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ticTacToe
{
    // first move is always made by the user 
    // hence the last move is also always made by the user
    public partial class Form1 : Form
    {
        ArrayList availablePlaces = new ArrayList();
        string RoboMarker = "O";
        string userMarker = "X";
        string roboVictoryMessage = "Bleep Blop. Robo wins. \nBetter luck next time.\nBut really how bad are you that you got beat up by a bot.\n Go get a life.";
        string playerVictoryMessage = "Yay!\nYou win!\nFeels good to beat a robot?\nNo. Go get a life.";
        string gameTiedMessage = "Game Tied.\nYou know what.\nYou are just a robot.\nGo think about this.";

        public Form1()
        {
            InitializeComponent();

            clearBoard();
            initialisePlaces();

        }

        public void clearBoard()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
        }

        public void initialisePlaces()
        {
            availablePlaces.Clear();
            for(int i =1; i<10; i++)
            {
                availablePlaces.Add(i);
            }
        }

        // makes a random move by the robot
        // and removes the selected button from the available places list
        public void roboMove()
        {
            Random randObj = new Random();
            
            // select random spot on board
            int randIndex = randObj.Next(availablePlaces.Count);
            int btnNo = Convert.ToInt32(availablePlaces[randIndex]);
            
            updateButton(btnNo, RoboMarker);  // show move on board

            bool RoboVictory = checkVictory();

            if (RoboVictory)
            {
                MessageBox.Show(roboVictoryMessage);
                this.Close();
            }
        }

        // returs true is the board is full
        public bool checkNoPlaceLeft()
        {
            // check if the board is full
            bool isEmpty = true;

            foreach (int x in availablePlaces)
                isEmpty = false;

            return isEmpty;
        }

        public void updateButton(int index, string marker)
        {
            // marks the selected button as unavailable
            availablePlaces.Remove(index);

            // updates the selected button with the players marker
            switch(index)
            {
                case 1:
                    btn1.Text = marker;
                    break;
                case 2:
                    btn2.Text = marker;
                    break;
                case 3:
                    btn3.Text = marker;
                    break;
                case 4:
                    btn4.Text = marker;
                    break;
                case 5:
                    btn5.Text = marker;
                    break;
                case 6:
                    btn6.Text = marker;
                    break;
                case 7:
                    btn7.Text = marker;
                    break;
                case 8:
                    btn8.Text = marker;
                    break;
                case 9:
                    btn9.Text = marker;
                    break;
            }
        }

        public bool checkVictory()
        {
            if(
               (btn1.Text == btn2.Text && btn2.Text == btn3.Text) && (btn1.Text != "") && (btn2.Text != "") && (btn3.Text != "")  // top row
               ||
               (btn4.Text == btn5.Text && btn5.Text == btn6.Text) && (btn4.Text != "") && (btn5.Text != "") && (btn6.Text != "")  // middle row
               ||
               (btn7.Text == btn8.Text && btn8.Text == btn9.Text) && (btn7.Text != "") && (btn8.Text != "") && (btn9.Text != "")  // bottom row
               ||
               (btn1.Text == btn4.Text && btn4.Text == btn7.Text) && (btn1.Text != "") && (btn4.Text != "") && (btn7.Text != "")  // first column
               ||
               (btn2.Text == btn5.Text && btn5.Text == btn8.Text) && (btn2.Text != "") && (btn5.Text != "") && (btn8.Text != "")  // second column
               ||
               (btn3.Text == btn6.Text && btn6.Text == btn9.Text) && (btn3.Text != "") && (btn6.Text != "") && (btn9.Text != "")  // third column
               ||
               (btn1.Text == btn5.Text && btn5.Text == btn9.Text) && (btn1.Text != "") && (btn5.Text != "") && (btn9.Text != "")  // primary diagonal
               ||
               (btn7.Text == btn5.Text && btn5.Text == btn3.Text) && (btn7.Text != "") && (btn5.Text != "") && (btn3.Text != "")  // secondary diagonal
              )
            {
                return true;
            }

            return false;
        }

        public void isGameTied()
        {
            if (checkNoPlaceLeft() == true)
            {
                MessageBox.Show(gameTiedMessage);
                this.Close();
            }
        }

        // maves the user move on the button clicked by the user
        public void userMove(int buttonIndex)
        {
            updateButton(buttonIndex, userMarker);
            bool victory = checkVictory();

            if (victory == true)
            {
                MessageBox.Show(playerVictoryMessage);
                this.Close();
            }

            isGameTied();

            roboMove();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            userMove(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            userMove(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            userMove(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            userMove(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            userMove(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            userMove(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            userMove(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            userMove(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            userMove(9);
        }
    }
}
