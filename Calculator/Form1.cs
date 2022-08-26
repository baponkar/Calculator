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
        double firstNumber;
        string operation;
        double memory;



        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }


        private void button4_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            double secondNumber = Convert.ToDouble(textBox1.Text);
            double result;

            if(operation == "+")
            {
                result = firstNumber + secondNumber;
                textBox1.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (operation == "-")
            {
                result = firstNumber - secondNumber;
                if(result < 0)
                {
                    textBox1.Text =  "-" + Convert.ToString(result).Trim('-');
                }
                else
                {
                    textBox1.Text = Convert.ToString(result);
                }

                
                firstNumber = result;
            }
            if (operation == "*")
            {
                result = firstNumber * secondNumber;
                textBox1.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (operation == "/")
            {
                if (secondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    result = (firstNumber / secondNumber);
                    textBox1.Text = Convert.ToString(result);
                    firstNumber = result;
                }
            }
            if(operation == "%")
            {
                result = (firstNumber * secondNumber / 100);
                textBox1.Text = Convert.ToString(result);
                firstNumber = result;
            }
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operation = "+";
            textBox1.Text = "0";
            
        }

        private void productButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operation = "*";
            textBox1.Text = "0";
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operation = "/";
            textBox1.Text = "0";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operation = "-";
            textBox1.Text = "0";
        }

        private void percentageButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operation = "%";
            textBox1.Text = "0";
        }

        private void mrcButton_Click(object sender, EventArgs e)
        {
            memory = 0;
            textBox1.Text = "0";
        }

        private void mPlusButton_Click(object sender, EventArgs e)
        {
            memory += Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void mMinusButton_Click(object sender, EventArgs e)
        {
            memory -= Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
        }

        private void mButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(memory);
        }

        private void sqrtButton_Click(object sender, EventArgs e)
        {
            double result = Math.Sqrt( Convert.ToDouble(textBox1.Text));
            textBox1.Text = Convert.ToString(result);
        }
    }
}
