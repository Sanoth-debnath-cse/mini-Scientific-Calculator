using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientific_Cal
{
    public partial class Form1 : Form
    {
        decimal num1;
        decimal num2;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }
        private void input(string a)
        {
            if (result.Text == "0")
                result.Text = a;
            else
                result.Text += a;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0") )
                result.Clear();
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            num2 = decimal.Parse(result.Text);
            switch (operation)
            {
                case "+":
                    result.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    result.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    result.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    result.Text = (num1 / num2).ToString();
                    break;
                case "^":
                    result.Text = (int.Parse(num1.ToString()) ^ int.Parse(num2.ToString())).ToString();
                    break;
                case "%":
                    result.Text = (num1 % num2).ToString();
                    break;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(result.Text);
            operation = "+";
            result.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(result.Text);
            operation = "-";
            result.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(result.Text);
            operation = "/";
            result.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(result.Text);
            operation = "*";
            result.Text = "0";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            result.Text = (Math.Sin(double.Parse(result.Text))).ToString();

        }

        private void button22_Click(object sender, EventArgs e)
        {
            result.Text = (Math.Cos(double.Parse(result.Text))).ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            long f = 1;
            for (long i = 1; i <= long.Parse(result.Text); i++)
            {
                f = f * i;
            }
            result.Text = f.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            result.Text = (Math.Log(double.Parse(result.Text))).ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            result.Text = (Math.Sqrt(double.Parse(result.Text))).ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(result.Text);
            operation = "^";
            result.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Text = (Math.Tan(double.Parse(result.Text))).ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(result.Text);
            operation = "%";
            result.Text = "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Clear();
           
        }

        private void pi_Click(object sender, EventArgs e)
        {
            result.Text = "3.14159";
        }

        private void power_Click(object sender, EventArgs e)
        {
            double a,b;
            b = double.Parse(result.Text);
            a = Math.Pow(2.718281828, b);
            result.Text = a.ToString();
        }

        private void Asin_Click(object sender, EventArgs e)
        {
           
            result.Text = (Math.Asin(double.Parse(result.Text))).ToString();
        }

        private void Acos_Click(object sender, EventArgs e)
        {
            result.Text = (Math.Acos(double.Parse(result.Text))).ToString();
        }

        private void Atan_Click(object sender, EventArgs e)
        {
            result.Text = (Math.Atan(double.Parse(result.Text))).ToString();
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
