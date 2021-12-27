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
    public partial class form1 : Form
    {
        enum operators
        {
            None,
            Add,
            Subtract,
            Multiply,   
            Divide,
            Result
        }
        operators currentOperator = operators.None;
        Boolean operatorChangeFlag = false;
        int firstOperand = 0;
        int secondOperand = 0;
        public form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "1";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "3";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "6";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void buttonresult_Click(object sender, EventArgs e)
        {

        }

        private void buttonresult_Click_1(object sender, EventArgs e)
        {
            secondOperand = Int32.Parse(display.Text);
            if(currentOperator == operators.Add)
            {
                firstOperand += secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if(currentOperator == operators.Subtract)
            {
                firstOperand -= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if(currentOperator == operators.Multiply)
            {
                firstOperand *= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if(currentOperator == operators.Divide)
            {
                if(secondOperand == 0)
                {
                    display.Text = "0으로 나눌 수 없습니다";
                }
                else
                {
                    firstOperand /= secondOperand;
                    display.Text = firstOperand.ToString();
                }
            }
        }

        private void ButtonSeven_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "7";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "8";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "9";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = operators.Divide;
            operatorChangeFlag = true;
            display.Text = "÷";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "4";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "5";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = operators.Multiply;
            operatorChangeFlag = true;
            display.Text = "x";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = operators.Subtract;
            operatorChangeFlag = true;
            display.Text = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator = operators.Add;
            operatorChangeFlag = true;
            display.Text = "+";
        }

        private void buttonpoint_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "0";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void buttonallclear_Click(object sender, EventArgs e)
        {
            firstOperand = 0;
            secondOperand = 0;
            currentOperator = operators.None;
            display.Text = "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "2";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }
    }
}
