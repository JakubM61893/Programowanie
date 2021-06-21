using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zamówienie zostało złożone. Czas oczekiwania: 45 minut.", "Udało się!", MessageBoxButtons.OK);
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (rbSmall.Checked)  {
                txbTotal.Text = 28.ToString();
            }

            if (rbMedium.Checked)
            {
                txbTotal.Text = 36.ToString();
            }

            if (rbLarge.Checked)
            {
                txbTotal.Text = 50.ToString();
            }
        }
    }
}
