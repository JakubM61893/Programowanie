using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbMała.Checked)
            {
                this.textBox1.Font = new Font("Times New Roman", 8);
            }

            if (rbDuza.Checked)
            {
                this.textBox1.Font = new Font("Times New Roman", 14);
            }

            if(rbBardzo.Checked)
            {
                this.textBox1.Font = new Font("Times New Roman", 18);
            }

            if (rbCzer.Checked)
            {
                this.textBox1.ForeColor = Color.Red;
            }

            if (rbPomar.Checked)
            {
                this.textBox1.ForeColor = Color.Orange;
            }

            if (rbNie.Checked)
            {
                this.textBox1.ForeColor = Color.Blue;
            }

            if (cbxPogrub.Checked)
            {
                this.textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
            }

            if (cbxPod.Checked)
            {
                this.textBox1.Font = new Font(textBox1.Font, FontStyle.Underline);
            }

            if (cbxPochyl.Checked)
            {
                this.textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }





        }
    }
}
