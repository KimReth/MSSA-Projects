//Author: Kimberly Retherford
//Date: January 27th, 2021
//Lab 3D Math App

using System;
using System.Windows.Forms;

namespace MathApp
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           WelcomeLabel.Text = "Welcome!\nThis application can add, subtract, multiply, and divide two\nnumbers that you enter. First enter the two numbers that you\nwish to manipulate in their appropriate box. Then click the\ncorresponding button for the operation you wish to execute.\nWhen you're finished, click exit.\nHappy Calculating!";
           VerificationLabel.Visible = false;
           VerificationLabel2.Visible = false;
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Text)
            {
                case "Addition": 
                    AddNumbers();
                    break;
                case "Subtraction":
                    SubtractNumbers();
                    break;
                case "Multiplication":
                    MultiplyNumbers();
                    break;
                case "Division":
                    DivideNumbers();
                    break;
                case "Exit":
                    ExitProgram();
                    break;
            }
        }
        private void ExitProgram()
        {
            MessageBox.Show("Thanks for stopping by!");
            this.Close();
        }
        private void DivideNumbers()
        {
            double numOne, numTwo, result;
            bool one = double.TryParse(firstNum.Text, out numOne);
            bool two = double.TryParse(secondNum.Text, out numTwo); 
            Verify(one, two);            
            if (two == false)
            {                   
                VerificationLabel2.Visible = true;
                VerificationLabel2.Text = "That is not a valid number!";
            }
            else if (numTwo == 0)
            {
                VerificationLabel2.Visible = true;                           
                VerificationLabel2.Text = "Cannot divide by 0 or be blank!";
            }
            else
            {
                result = Math.Round(numOne / numTwo, 2);
                OutputLabel.Text = ($"Output: The result of {numOne} / {numTwo} is {result}!");
             }
        }
        private void MultiplyNumbers()
        {
            double numOne, numTwo, result;
            bool one = double.TryParse(firstNum.Text, out numOne);
            bool two = double.TryParse(secondNum.Text, out numTwo);
            bool Verified = Verify(one, two);
            if (Verified)
            {
                result = Math.Round(numOne * numTwo, 2);
                OutputLabel.Text = ($"Output: The result of {numOne} x {numTwo} is {result}!");
            }
        }
        private void SubtractNumbers()
        {
            double numOne, numTwo, result;
            bool one = double.TryParse(firstNum.Text, out numOne);
            bool two = double.TryParse(secondNum.Text, out numTwo);
            bool Verified = Verify(one, two);
            if (Verified)
            {
                result = Math.Round(numOne - numTwo, 2);
                OutputLabel.Text = ($"Output: The result of {numOne} - {numTwo} is {result}!");
            }
        }
        private void AddNumbers()
        {
            double numOne, numTwo, result;
            bool one = double.TryParse(firstNum.Text, out numOne);
            bool two = double.TryParse(secondNum.Text, out numTwo);
            bool Verified = Verify(one, two);
            if (Verified)
            {
                result = Math.Round(numOne + numTwo, 2);
                OutputLabel.Text = ($"Output: The result of {numOne} + {numTwo} is {result}!");
            }   
        }        
        private bool Verify (bool one, bool two)
        {
            VerificationLabel.Visible = !one;
            VerificationLabel2.Visible = !two;
            return (one && two);            
        }        
    }
}
