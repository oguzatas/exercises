using System;
using System.Text.Json;
using System.Windows.Forms;

//210401056 OĞUZHAN ATAŞ    
namespace Calculator
{
    public partial class Form1 : Form
    {
        readonly DynamicExpresso.Interpreter _interpreter;
        readonly CommandsHistory _commandsHistory;
        private readonly WebShell _webShell;

        public Form1()
        {
            InitializeComponent();
            _interpreter = new DynamicExpresso.Interpreter();
            _commandsHistory = new CommandsHistory();
            _interpreter.SetVariable("Commands", _commandsHistory);
            _webShell = new WebShell();
        }

        string userInput = "";
        public double eval(string expression)
        {
            return double.Parse(Calculate(userInput));
        }

        public string Calculate(string expression)
        {
            try
            {
                var result = _webShell.Eval(expression);
                var options = new JsonSerializerOptions { WriteIndented = true };
                var prettifyOutput = JsonSerializer.Serialize(result, options);
                return prettifyOutput;
            }
            catch
            {
                MessageBox.Show("Check your input");
                return "Error";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += "0";
            userInput += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += "1";
            userInput += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += "2";
            userInput += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += "3";
            userInput += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += "4";
            userInput += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += "5";
            userInput += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += "6";
            userInput += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += "7";
            userInput += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += "8";
            userInput += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += "9";
            userInput += "9";
        }
        /* ----------------------------------------OPERATOR BUTTONS-----------------------------------*/
        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += ".";
            userInput += ".";
        }

        private void buttonDivi_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += "/";
            userInput += "/";
        }

        private void buttonMultip_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += "*";
            userInput += "*";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += "-";
            userInput += "-";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            mainDisplay.Text += "+";
            userInput += "+";

        }
        /* ----------------------------------------OPERATOR BUTTONS END-----------------------------------*/
        private void buttonEqual_Click(object sender, EventArgs e) // CALCULATE BUTTON
        {
            try
            {
                
                upperDisplay.Text = mainDisplay.Text;
                mainDisplay.Text = Convert.ToString(eval(userInput));
                userInput = mainDisplay.Text;
            }
            catch { }
        }
        /* ----------------------------------------TRIGONOMETRIC FUNCTIONS, EXP, ROOT AND LOG-----------------------------------*/
        private void buttonSin_Click(object sender, EventArgs e)
        {
            userInput += "Math.Sin(";
            mainDisplay.Text += "sin(";
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            userInput += "Math.Cos(";
            mainDisplay.Text += "cos(";
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            userInput += "Math.Tan(";
            mainDisplay.Text += "tan(";
        }

        private void buttonCot_Click(object sender, EventArgs e)
        {
            userInput += "Math.Cot(";
            mainDisplay.Text += "cot(";
        }

        private void buttonExp_Click(object sender, EventArgs e)
        {
            userInput += "Math.Pow(";
            mainDisplay.Text += "pow(";
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            userInput += "Math.Log(";
            mainDisplay.Text += "log(";
        }

        private void buttonLn_Click(object sender, EventArgs e)
        {

            userInput += "ln(";
            mainDisplay.Text += "ln(";

        }
        /* ----------------------------------------BRACKETS-----------------------------------*/
        private void buttonLbracket_Click(object sender, EventArgs e)
        {
            userInput += "(";
            mainDisplay.Text += "(";


        }

        private void buttonRbracket_Click(object sender, EventArgs e)
        {
            userInput += ")";
            mainDisplay.Text += ")";
        }
        /* ----------------------------------------DELETE BUTTONS-----------------------------------*/
        private void buttonClear_Click(object sender, EventArgs e)
        {
            userInput = "";
            mainDisplay.Text = "";
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            userInput = "";
            mainDisplay.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            userInput += ",";
            mainDisplay.Text += ",";
        }
    }
}
