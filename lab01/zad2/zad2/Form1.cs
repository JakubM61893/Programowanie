using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad2
{
    public partial class Form1 : Form
    {
        bool startNewNumber = true;
        string znak;
        double num1;
        double num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Numberbt("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Numberbt("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Numberbt("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Numberbt("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Numberbt("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Numberbt("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Numberbt("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Numberbt("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Numberbt("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Numberbt("0");
        }

        private void Numberbt(string number)
        {
            if(startNewNumber == false)
            {
                txb.Text += number;
            }
            else
            {
                txb.Text = number;
                startNewNumber = false;
            }
        }

        private void btnprze_Click(object sender, EventArgs e)
        {
            txb.Text = txb.Text + ",";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            Operation("+");
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            Operation("-");
        }

        private void btnslash_Click(object sender, EventArgs e)
        {
            Operation("/");
        }

        private void btnmnoz_Click(object sender, EventArgs e)
        {
            Operation("*");
        }

        private void Operation(string znak)
        {
            num1 = Convert.ToDouble(txb.Text);
            label1.Text = txb.Text;
            label1.Text += znak;
            this.znak = znak;
            startNewNumber = true;
        }

        private void btnrowna_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txb.Text);
            label1.Text = String.Empty;
            switch(znak)
            {
                case "+":
                    txb.Text = Convert.ToString(num1 + num2);
                    break;
                case "-":
                    txb.Text = Convert.ToString(num1 - num2);
                    break;
                case "*":
                    txb.Text = Convert.ToString(num1 * num2);
                    break;
                case "/":
                    if(num2 == 0)
                    {
                        MessageBox.Show("Nie dziel przez 0!", "Uwaga", MessageBoxButtons.OK);
                    }
                    else
                    {
                        txb.Text = Convert.ToString(num1 / num2);
                    }
                    break;

            }
            znak = String.Empty;
            startNewNumber = true;
        }


        private void btnc_Click(object sender, EventArgs e)
        {
            txb.Clear();
            label1.Text = String.Empty;
            znak = String.Empty;
            startNewNumber = true;
        }
    }
}
