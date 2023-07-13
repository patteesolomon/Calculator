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
        private bool operatorCall = false;
        readonly Memory d = new Memory();
        double con1 = 0.0;
        string demi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            d.Mem += textBox1.Text;
            //d.ShortT1 = "";

            if (d.Mem != string.Empty)
                d.Mem += d.ShortT2;
            d.ShortT2 = "";
            textBox1.Clear();
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            //recal time
            if (d.Mem != string.Empty)
            {
                textBox1.Text = d.Mem;
                d.ShortT1 = "";
            }
            else
            {
                d.Mem = "0";
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if ((this.textBox1.Text == "0")||operatorCall == true)
            {
                textBox1.Clear();
                operatorCall = false;
            }
            
            if(button.Text == ".")
            {
                if(!textBox1.Text.Contains("."))
                    textBox1.Text += button.Text;
            }
            else 
            {
                textBox1.Text += button.Text;
            }
        }

        private void Operator_click(object s, EventArgs e)
        {
            operatorCall = true;
            Button button = (Button)s; // without this im bricked. dont fuck with THIS 
            if (con1 != 0.0)
            {
                enter.PerformClick();
                demi += button.Text;
                equation.Text = con1 + " " + demi;
            }
            else
            {
                demi = button.Text;
                con1 = Double.Parse(textBox1.Text);
                equation.Text = con1 + " " + demi;
            }
        }
        /// <summary>
        /// enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button8_Click(object sender, EventArgs e)
        {
            //
            equation.Text = "";
            switch (demi)
            {
                case "*":
                    string v = (con1 * Double.Parse(textBox1.Text)).ToString();
                    textBox1.Text =
                        v;
                    break;
                case "^":
                    string v1 = (((int)con1) ^ ((int)Double.Parse(textBox1.Text))).ToString();
                    textBox1.Text =
                        v1;
                    break;
                case "-":
                    string v2 = (con1 - Double.Parse(textBox1.Text)).ToString();
                    textBox1.Text =
                        v2;
                    break;
                case "+":
                    string v3 = (con1 + Double.Parse(textBox1.Text)).ToString();
                    textBox1.Text =
                        v3;
                    break;
                case "/":
                    try
                    {
                        string v4 = (con1 / Double.Parse(textBox1.Text)).ToString();
                        textBox1.Text =
                            v4;
                    }
                    catch (DivideByZeroException)
                    {
                        textBox1.Text = "Cannot Divide By zero";
                    }
                    break;
                case "%":
                    string v5 = (con1 % Double.Parse(textBox1.Text)).ToString();
                    textBox1.Text =
                        v5;
                    break;
                case "Abs":
                    string v6 = Math.Abs(con1 = Double.Parse(textBox1.Text)).ToString();
                    textBox1.Text =
                        v6;
                    break;
                case "sqrt":
                    string v7 = Math.Sqrt(con1 % Double.Parse(textBox1.Text)).ToString();
                    textBox1.Text =
                        v7;
                    break;

                case "nⁿ":
                    string v8 = Math.Pow(con1, Double.Parse(textBox1.Text)).ToString();
                    textBox1.Text = v8;
                    break;

                default:
                    textBox1.Text = "0";
                    break;
            }
            con1 = double.Parse(textBox1.Text);
            demi = "";
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            con1 = 0;
            d.typS = 0;
            d.Mem = "";
            equation.Text = "";
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
            switch(e.KeyChar.ToString())
            {
                case "0":
                    zero.PerformClick();
                    break;
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                default :
                    break;
            }
        }
    }
}
