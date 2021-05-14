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

        private void btnSuma_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(txbx.Text);
                float y = float.Parse(txby.Text);
                float z = float.Parse(txbz.Text);
                txbWynik.Text = (x + y + z).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("podano błędne dane", "Uwaga!", MessageBoxButtons.OK);
            }
        }

        private void btnIloczyn_Click(object sender, EventArgs e)
        {
            try
            {
                float x = float.Parse(txbx.Text);
                float y = float.Parse(txby.Text);
                float z = float.Parse(txbz.Text);
                txbWynik.Text = (x * y * z).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("podano błędne dane", "Uwaga!", MessageBoxButtons.OK);
            }
        }

        private void btnWyjscie_Click(object sender, EventArgs e)
        {
            Application.Exit();    
        }
    }
}
