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

namespace NumberPuzzle
{
    public partial class Form1 : Form
    {
        int clkCount = 1;
        string text1; // stores text on first click
        string text2; // stores text on second click
        int btnId;
        public Form1()
        {
            InitializeComponent();

            MessageBox.Show("Click two boxes to exchange numbers.\nGet them in ascending order from left to right.");

            ArrayList numbers = new ArrayList();
            numbers.Add(0);
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(8);
            numbers.Add(9);
            numbers.Add(10);
            numbers.Add(11);
            numbers.Add(12);
            numbers.Add(13);
            numbers.Add(14);
            numbers.Add(15);

            button1.Text = getText(numbers);
            button2.Text = getText(numbers);
            button3.Text = getText(numbers);
            button4.Text = getText(numbers);
            button5.Text = getText(numbers);
            button6.Text = getText(numbers);
            button7.Text = getText(numbers);
            button8.Text = getText(numbers);
            button9.Text = getText(numbers);
            button10.Text = getText(numbers);
            button11.Text = getText(numbers);
            button12.Text = getText(numbers);
            button13.Text = getText(numbers);
            button14.Text = getText(numbers);
            button15.Text = getText(numbers);

            string btn0txt = Convert.ToString(numbers[0]);

            if (btn0txt == "0")
                btn0txt = "";

            button0.Text = btn0txt;


        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (clkCount == 1)
            {
                text1 = button0.Text;
                clkCount = 2;
                btnId = 0;
            }
            else if (clkCount == 2)
            {
                text2 = button0.Text;
                UpdateText(btnId, text2);
                button0.Text = text1;
                clkCount = 1;

                CheckSuccess();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clkCount == 1)
            {
                text1 = button1.Text;
                clkCount = 2;
                btnId = 1;
            }
           else if (clkCount == 2)
            {
                text2 = button1.Text;
                UpdateText(btnId, text2);
                button1.Text = text1;
                clkCount = 1;

                CheckSuccess();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clkCount == 1)
            {
                text1 = button2.Text;
                clkCount = 2;
                btnId = 2;
            }
            else if (clkCount == 2)
            {
                text2 = button2.Text;
                UpdateText(btnId, text2);
                button2.Text = text1;
                clkCount = 1;

                CheckSuccess();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (clkCount == 1)
            {
                text1 = button3.Text;
                clkCount = 2;
                btnId = 3;
            }
            else if (clkCount == 2)
            {
                text2 = button3.Text;
                UpdateText(btnId, text2);
                button3.Text = text1;
                clkCount = 1;

                CheckSuccess();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (clkCount == 1)
            {
                text1 = button4.Text;
                clkCount = 2;
                btnId = 4;
            }
            else if (clkCount == 2)
            {
                text2 = button4.Text;
                UpdateText(btnId, text2);
                button4.Text = text1;
                clkCount = 1;

                CheckSuccess();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (clkCount == 1)
            {
                text1 = button5.Text;
                clkCount = 2;
                btnId = 5;
            }
            else if (clkCount == 2)
            {
                text2 = button5.Text;
                UpdateText(btnId, text2);
                button5.Text = text1;
                clkCount = 1;

                CheckSuccess();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (clkCount == 1)
            {
                text1 = button6.Text;
                clkCount = 2;
                btnId = 6;
            }
            else if (clkCount == 2)
            {
                text2 = button6.Text;
                UpdateText(btnId, text2);
                button6.Text = text1;
                clkCount = 1;

                CheckSuccess();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (clkCount == 1)
            {
                text1 = button7.Text;
                clkCount = 2;
                btnId = 7;
            }
            else if (clkCount == 2)
            {
                text2 = button7.Text;
                UpdateText(btnId, text2);
                button7.Text = text1;
                clkCount = 1;

                CheckSuccess();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (clkCount == 1)
            {
                text1 = button8.Text;
                clkCount = 2;
                btnId = 8;
            }
            else if (clkCount == 2)
            {
                text2 = button8.Text;
                UpdateText(btnId, text2);
                button8.Text = text1;
                clkCount = 1;

                CheckSuccess();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (clkCount == 1)
            {
                text1 = button9.Text;
                clkCount = 2;
                btnId = 9;
            }
            else if (clkCount == 2)
            {
                text2 = button9.Text;
                UpdateText(btnId, text2);
                button9.Text = text1;
                clkCount = 1;

                CheckSuccess();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (clkCount == 1)
            {
                text1 = button10.Text;
                clkCount = 2;
                btnId = 10;
            }
            else if (clkCount == 2)
            {
                text2 = button10.Text;
                UpdateText(btnId, text2);
                button10.Text = text1;
                clkCount = 1;

                CheckSuccess();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (clkCount == 1)
            {
                text1 = button11.Text;
                clkCount = 2;
                btnId = 11;
            }
            else if (clkCount == 2)
            {
                text2 = button11.Text;
                UpdateText(btnId, text2);
                button11.Text = text1;
                clkCount = 1;

                CheckSuccess();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (clkCount == 1)
            {
                text1 = button12.Text;
                clkCount = 2;
                btnId = 12;
            }
            else if (clkCount == 2)
            {
                text2 = button12.Text;
                UpdateText(btnId, text2);
                button12.Text = text1;
                clkCount = 1;

                CheckSuccess();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (clkCount == 1)
            {
                text1 = button13.Text;
                clkCount = 2;
                btnId = 13;
            }
            else if (clkCount == 2)
            {
                text2 = button13.Text;
                UpdateText(btnId, text2);
                button13.Text = text1;
                clkCount = 1;

                CheckSuccess();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (clkCount == 1)
            {
                text1 = button14.Text;
                clkCount = 2;
                btnId = 14;
            }
            else if (clkCount == 2)
            {
                text2 = button14.Text;
                UpdateText(btnId, text2);
                button14.Text = text1;
                clkCount = 1;

                CheckSuccess();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (clkCount == 1)
            {
                text1 = button15.Text;
                clkCount = 2;
                btnId = 15;
            }
            else if (clkCount == 2)
            {
                text2 = button15.Text;
                UpdateText(btnId, text2);
                button15.Text = text1;
                clkCount = 1;

                CheckSuccess();
            }
        }

        public void UpdateText(int id,string text)
        {
            switch(id)
            {
                case 0:
                    button0.Text = text;
                    break;
                case 1:
                    button1.Text = text;
                    break;
                case 2:
                    button2.Text = text;
                    break;
                case 3:
                    button3.Text = text;
                    break;
                case 4:
                    button4.Text = text;
                    break;
                case 5:
                    button5.Text = text;
                    break;
                case 6:
                    button6.Text = text;
                    break;
                case 7:
                    button7.Text = text;
                    break;
                case 8:
                    button8.Text = text;
                    break;
                case 9:
                    button9.Text = text;
                    break;
                case 10:
                    button10.Text = text;
                    break;
                case 11:
                    button11.Text = text;
                    break;
                case 12:
                    button12.Text = text;
                    break;
                case 13:
                    button13.Text = text;
                    break;
                case 14:
                    button14.Text = text;
                    break;
                case 15:
                    button15.Text = text;
                    break;
            }
        }  
        
        public void CheckSuccess()
        {
            if(button1.Text == "1" 
               &&
               button2.Text == "2"
               &&
               button3.Text == "3"
               &&
               button4.Text == "4"
               &&
               button5.Text == "5"
               &&
               button6.Text == "6"
               &&
               button7.Text == "7"
               &&
               button8.Text == "8"
               &&
               button9.Text == "9"
               &&
               button10.Text == "10"
               &&
               button11.Text == "11"
               &&
               button12.Text == "12"
               &&
               button13.Text == "13"
               &&
               button14.Text == "14"
               &&
               button15.Text == "15"
               &&
               button0.Text == ""
               )
            {
                MessageBox.Show("You won!");
                System.Environment.Exit(0);
            }
        } 

        public string getText(ArrayList numbers)
        {
            Random rand = new Random();

            int randNum = rand.Next(numbers.Count);

            string text = Convert.ToString(numbers[randNum]);
            numbers.Remove(numbers[randNum]);

            if (text == "0")
                text = "";

            return text;
        }
    }
}
