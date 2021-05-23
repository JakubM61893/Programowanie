using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbxStan_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (cbxStan.Checked)
            try
            { 
                float x = float.Parse(textBox1.Text);
                lblWynik.Text = (x - 100).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("podano błędne dane", "Uwaga!", MessageBoxButtons.OK);
            }
            if (cbxIde.Checked && rbKobieta.Checked)
            try
            {
                    float x = float.Parse(textBox1.Text);
                    lblWynik.Text = ((x - 100) * 0.85).ToString();
            }
                catch (Exception)
                {
                    MessageBox.Show("podano błędne dane", "Uwaga!", MessageBoxButtons.OK);
                }
            if (cbxIde.Checked && rbMez.Checked)
                try
                {
                    float x = float.Parse(textBox1.Text);
                    lblWynik.Text = ((x - 100) * 0.9).ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("podano błędne dane", "Uwaga!", MessageBoxButtons.OK);
                }
        }

       
    }
}
