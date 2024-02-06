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
        string operation = "";
        double value = 0;
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if ((richTextBox1.Text == "0") || (operation_pressed))
                richTextBox1.Clear();
            Button b = (Button)sender;
            richTextBox1.Text = richTextBox1.Text + b.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if ((richTextBox1.Text == "0") || (operation_pressed))
                richTextBox1.Clear();
            Button b = (Button)sender;
            richTextBox1.Text = richTextBox1.Text + b.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if ((richTextBox1.Text == "0") || (operation_pressed))
                richTextBox1.Clear();
            Button b = (Button)sender;
            richTextBox1.Text = richTextBox1.Text + b.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if ((richTextBox1.Text == "0") || (operation_pressed))
                richTextBox1.Clear();
            Button b = (Button)sender;
            richTextBox1.Text = richTextBox1.Text + b.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((richTextBox1.Text == "0") || (operation_pressed))
                richTextBox1.Clear();
            Button b = (Button)sender;
            richTextBox1.Text = richTextBox1.Text + b.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if ((richTextBox1.Text == "0") || (operation_pressed))
                richTextBox1.Clear();
            Button b = (Button)sender;
            richTextBox1.Text = richTextBox1.Text + b.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((richTextBox1.Text == "0") || (operation_pressed))
                richTextBox1.Clear();
            Button b = (Button)sender;
            richTextBox1.Text = richTextBox1.Text + b.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((richTextBox1.Text == "0") || (operation_pressed))
                richTextBox1.Clear();
            Button b = (Button)sender;
            richTextBox1.Text = richTextBox1.Text + b.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if ((richTextBox1.Text == "0") || (operation_pressed))
                richTextBox1.Clear();
            Button b = (Button)sender;
            richTextBox1.Text = richTextBox1.Text + b.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if ((richTextBox1.Text == "0") || (operation_pressed))
                richTextBox1.Clear();
            Button b = (Button)sender;
            richTextBox1.Text = richTextBox1.Text + b.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(richTextBox1.Text);
            operation_pressed = true;
            Equation.Text = value + "" + operation;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(richTextBox1.Text);
            operation_pressed = true;
            Equation.Text = value + "" + operation;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(richTextBox1.Text);
            operation_pressed = true;
            Equation.Text = value + "" + operation;
        }

        private void button18_Click(object sender, EventArgs e)
        {
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            Equation.Text = "";
            switch (operation)
            {
                case "+":
                    richTextBox1.Text = (value + double.Parse(richTextBox1.Text)).ToString();
                    break;

                case "-":
                    richTextBox1.Text = (value - double.Parse(richTextBox1.Text)).ToString();
                    break;

                case "÷":
                    richTextBox1.Text = (value / double.Parse(richTextBox1.Text)).ToString();
                    break;

                case "×":
                    richTextBox1.Text = (value * double.Parse(richTextBox1.Text)).ToString();
                    break;
                case "%":
                    richTextBox1.Text = (value % double.Parse(richTextBox1.Text)).ToString();
                    break;
                case "1/x":
                    richTextBox1.Text = (1 / double.Parse(richTextBox1.Text)).ToString();
                    break;
                case "x^2":
                    richTextBox1.Text = Math.Pow(double.Parse(richTextBox1.Text),2).ToString();
                    break;
                case "2√x":
                    richTextBox1.Text = Math.Sqrt(double.Parse(richTextBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
            operation_pressed = false;
        }

        public void button_Equal(object o, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "0")
                richTextBox1.Clear();
            Button b = (Button)sender;
            richTextBox1.Text = richTextBox1.Text + b.Text;
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(richTextBox1.Text);
            operation_pressed = true;
            Equation.Text = value + "" + operation;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(richTextBox1.Text);
            operation_pressed = true;
            Equation.Text = value + "" + operation;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            value = 0;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(richTextBox1.Text);
            operation_pressed = true;
            Equation.Text = 1 + "/" + value ;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(richTextBox1.Text);
            operation_pressed = true;
            Equation.Text = value + "^2";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(richTextBox1.Text);
            operation_pressed = true;
            Equation.Text = "√" + value;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
