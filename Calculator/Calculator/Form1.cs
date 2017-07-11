using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double result = 0;
        string op;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbxInput.Text += "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxInput.Text = "";
            result = 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbxInput.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbxInput.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbxInput.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbxInput.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbxInput.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbxInput.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbxInput.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbxInput.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbxInput.Text += "9";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            tbxInput.Text += ".";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string newInputText = "";

            for (int i = 0; i < tbxInput.Text.Length - 1; i++)
                newInputText += tbxInput.Text[i];

            tbxInput.Text = newInputText;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(tbxInput.Text);
            op = "+";
            tbxInput.Text = "";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(tbxInput.Text);
            op = "-";
            tbxInput.Text = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(tbxInput.Text);
            op = "*";
            tbxInput.Text = "";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            result = Convert.ToDouble(tbxInput.Text);
            op = "/";
            tbxInput.Text = "";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double nextInput = Convert.ToDouble(tbxInput.Text);

            switch(op)
            {
                case "+":
                    result += nextInput;
                    break;
                case "-":
                    result -= nextInput;
                    break;
                case "*":
                    result *= nextInput;
                    break;
                case "/":
                    {
                        if (nextInput != 0)
                            result /= nextInput;
                        else
                            lblErr.Text = "ER";
                            break;
                    }
            }

            tbxInput.Text = result.ToString();

        }
    }
}
